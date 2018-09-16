using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TesseractTester.Models;

namespace TesseractTester.Services
{
    public class TessRunner
    {
        public Page Page { get; set; }
        public string RawTsv { get; set; }
        public string PageText { get; set; }

        private string _filePath;
        private string _tessExePath;


        
        public TessRunner(string filePath)
        {
            string osNameAndVersion = System.Runtime.InteropServices.RuntimeInformation.OSDescription;
            if (osNameAndVersion.Contains("Windows")) 
            {
                _tessExePath = @"C:\Program Files (x86)\Tesseract-OCR\tesseract.exe";
            }
            else if (osNameAndVersion.Contains("Linux")) 
            {
                _tessExePath = @"/usr/bin/tesseract";
            }

            Page = new Page { PageNumber = 1 }; // For this application we'll only do one page. We'll add blocks to this
            _filePath = filePath;
            Process();
        }


        public void Process()
        {
            PageText = "";

            Process proc = new Process();
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.FileName = _tessExePath;
            proc.StartInfo.Arguments = $"\"{_filePath}\" stdout -c tessedit_create_tsv=1";

            proc.Start();
            RawTsv = proc.StandardOutput.ReadToEnd();
            proc.WaitForExit();
            if (proc.ExitCode == 0)
            {
                // Exit code: success.
                string[] outputLines = RawTsv.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                foreach (string line in outputLines)
                {
                    string[] cells = line.Split('\t');
                    
                    if (cells.Length == 12 && cells[0] != "level") // else empty line
                    {
                        int level = int.Parse(cells[0]);
                        int pageNumber = int.Parse(cells[1]);
                        int blockNumber = int.Parse(cells[2]);
                        int paraNumber = int.Parse(cells[3]);
                        int lineNumber = int.Parse(cells[4]);
                        int wordNumber = int.Parse(cells[5]);
                        Rect rect = new Rect {
                            Left = int.Parse(cells[6]),
                            Top = int.Parse(cells[7]),
                            Width = int.Parse(cells[8]),
                            Height = int.Parse(cells[9])
                        };
                        int confidence = int.Parse(cells[10]);
                        string text = cells[11];

                        if (level == 1) // 1=page
                        {
                            Page.Rect = rect;
                        }

                        if (level == 2) // 2=block
                        {
                            Page.Blocks.Add(new Block{ BlockNumber = blockNumber,
                                Rect = rect
                            });
                        }
                        
                        if (level == 3) // 3=paragraph
                        {
                            Page.Blocks.Find(b => b.BlockNumber == blockNumber).Paragraphs.Add(new Paragraph {
                                ParagraphNumber = paraNumber,
                                Rect = rect
                            });
                            PageText += Environment.NewLine;
                        }

                        if (level == 4) // 4=line
                        {
                            Page.Blocks.Find(b => b.BlockNumber == blockNumber).
                                Paragraphs.Find(p => p.ParagraphNumber == paraNumber).Lines.Add(new Line {
                                    LineNumber = lineNumber,
                                    Rect = rect
                                });
                            PageText += Environment.NewLine;
                        }

                        if (level == 5 && text!=" ") // 5=word
                        {
                            Page.Blocks.Find(b => b.BlockNumber == blockNumber).
                                Paragraphs.Find(p => p.ParagraphNumber == paraNumber).
                                    Lines.Find(l => l.LineNumber == lineNumber).Words.Add(new Word {
                                        WordNumber = wordNumber,
                                        Rect = rect,
                                        Confidence = confidence,
                                        Text = text
                                    });
                            PageText += $"{text} ";
                        }

                    }
                    else
                    {
                        //Console.WriteLine("non-data line ");
                    }
                }

                // take the last space off each line
                string tempPageText = "";
                foreach(string line in PageText.Split(Environment.NewLine))
                {
                    tempPageText += line.Trim() + Environment.NewLine;
                }
                PageText = tempPageText;

            }
            else
            {
                throw new Exception("Error. Tesseract stopped with an error code = " + proc.ExitCode);
            }
            proc.Close();

        }

        private bool StringIsInt(string s)
        {
            return int.TryParse(s, out int n);
        }

    }
}
