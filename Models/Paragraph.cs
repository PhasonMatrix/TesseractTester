using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesseractTester.Models
{
    public class Paragraph
    {
        [JsonProperty("paragraphNumber")]
        public int ParagraphNumber { get; set; }
        [JsonProperty("rect")]
        public Rect Rect { get; set; }
        [JsonProperty("lines")]
        public List<Line> Lines { get; set; } = new List<Line>();

    }
}