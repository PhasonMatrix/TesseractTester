using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TesseractTester.Models;
using TesseractTester.Services;
using System.Drawing;
using System.Drawing.Imaging;

namespace TesseractTester.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _appEnvironment;
        char ds = Path.DirectorySeparatorChar; // hashtag cross platform

        public HomeController(IHostingEnvironment appEnvironment) // DI provides
        {
            _appEnvironment = appEnvironment;
        }


        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Ocr(IFormFile file)
        {
            try
            {
                if (file == null || file.Length == 0)
                {
                    return Content("Error: No file uploaded");
                }
                if (file.ContentType.IndexOf("image", StringComparison.OrdinalIgnoreCase) < 0)
                {
                    return Content("Error: File is not an image");
                }

                string appRootPath = _appEnvironment.WebRootPath;
                string storedFileName = $"{DateTime.Now.ToString("yyyyMMdd_HHmmsss")} _{file.FileName}";
                string imagePath = $@"{appRootPath}{ds}UserFiles{ds}{storedFileName}";

                using (FileStream stream = new FileStream(imagePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                // convert if tiff
                if(Path.GetExtension(imagePath) == ".tif" || Path.GetExtension(imagePath) == ".tiff")
                {
                    Bitmap bm = new Bitmap(imagePath);
                    storedFileName = $"{Path.GetFileNameWithoutExtension(imagePath)}.png";
                    imagePath = $@"{appRootPath}{ds}UserFiles{ds}{storedFileName}";
                    bm.Save(imagePath, ImageFormat.Png);
                }



                // get tesseract to OCR
                TessRunner tess = new TessRunner(imagePath);

                ViewData["ImageFileName"] = storedFileName;
                ViewData["RawTsv"] = tess.RawTsv;
                // JSON for presentation in page
                ViewData["JsonText"] = JsonConvert.SerializeObject(tess.Page, Formatting.Indented);
                // JSON for deserialization
                ViewData["Json"] = JsonConvert.SerializeObject(tess.Page);
                List<Word> allWords = tess.Page.Blocks.SelectMany(b => b.Paragraphs.SelectMany(p => p.Lines.SelectMany(l => l.Words))).ToList();
                ViewData["WordCount"] = allWords.Count;
                ViewData["AverageConfidence"] = allWords.Average(w => w.Confidence);
                ViewData["PageText"] = tess.PageText;

                // get image properties
                Bitmap bitmap = new Bitmap(imagePath);
                ViewData["ImageDimensions"] = $"Width: {bitmap.Width}, Height: {bitmap.Height}";
                ViewData["ImageResolution"] = $"{Math.Ceiling(bitmap.HorizontalResolution)}dpi";

                return View("OcrResult");
            }
            catch (Exception ex)
            {
                Log(ex.Message);
                return View ("Error");
            }
        }


        [HttpGet] // user has clicked on a sample image
        [Route("Home/Ocr/{id}")]
        public IActionResult Ocr(int id)
        {
            try 
            {
                string imageFileName = "";
                switch (id)
                {
                    case 1:
                        imageFileName = "Ada_newspaper.jpg";
                        break;
                    case 2:
                        imageFileName = "Font_test.jpg";
                        break;
                    case 3:
                        imageFileName = "Financial_statement.png";
                        break;
                    default:
                        System.Console.WriteLine("GET: Home/Ocr/{id} - no ID provided");
                        Log("GET: Home/Ocr/{id} - no ID provided");
                        break;
                }


                string appRootPath = _appEnvironment.WebRootPath;
                string imagePath = $@"{appRootPath}{ds}images{ds}OcrSamples{ds}{imageFileName}";

                if (!System.IO.File.Exists(imagePath))
                {
                    return Content("File does not exist");
                }

                TessRunner tess = new TessRunner(imagePath);

                ViewData["ImageFileName"] = System.IO.Path.GetFileName(imagePath);
                ViewData["RawTsv"] = tess.RawTsv;
                ViewData["JsonText"] = JsonConvert.SerializeObject(tess.Page, Formatting.Indented);
                ViewData["Json"] = JsonConvert.SerializeObject(tess.Page);
                List<Word> allWords = tess.Page.Blocks.SelectMany(b => b.Paragraphs.SelectMany(p => p.Lines.SelectMany(l => l.Words))).ToList();
                ViewData["WordCount"] = allWords.Count;
                ViewData["AverageConfidence"] = allWords.Average(w => w.Confidence);
                ViewData["PageText"] = tess.PageText;

                // get image properties
                Bitmap bitmap = new Bitmap(imagePath);
                ViewData["ImageDimensions"] = $"Width: {bitmap.Width}, Height: {bitmap.Height}";
                ViewData["ImageResolution"] = $"{Math.Ceiling(bitmap.HorizontalResolution)}dpi";
                ViewData["SampleImageFile"] = imageFileName;
                return View("OcrResult");
            }
            catch (Exception ex)
            {
                Log(ex.Message);
                return View ("Error");
            }
        }


        public IActionResult About()
        {
            return View();
        }


        // Dodgy logging. Should use logging provider instead.
        private void Log(string logMessage)
        {
            string appRootPath = _appEnvironment.WebRootPath;
            string logPath = $@"{appRootPath}{ds}application.log";
            System.Console.WriteLine("Logging to " + logPath);
            System.IO.File.AppendAllText(logPath, DateTime.Now.ToString("yyyy-MM-dd HH:mm:sss") + " " + logMessage + Environment.NewLine);
        }



    }
}
