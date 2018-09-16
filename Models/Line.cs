using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesseractTester.Models
{
    public class Line
    {
        [JsonProperty("lineNumber")]
        public int LineNumber { get; set; }
        [JsonProperty("rect")]
        public Rect Rect { get; set; }
        [JsonProperty("words")]
        public List<Word> Words { get; set; } = new List<Word>();
    }
}