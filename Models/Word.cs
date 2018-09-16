using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesseractTester.Models
{
    public class Word
    {
        [JsonProperty("wordNumber")]
        public int WordNumber { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("confidence")]
        public int Confidence { get; set; }
        [JsonProperty("rect")]
        public Rect Rect { get; set; }
    }
}