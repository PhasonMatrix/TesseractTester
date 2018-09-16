using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesseractTester.Models
{
    public class Block
    {
        [JsonProperty("blockNumber")]
        public int BlockNumber { get; set; }
        [JsonProperty("rect")]
        public Rect Rect { get; set; }
        [JsonProperty("paragraphs")]
        public List<Paragraph> Paragraphs { get; set; } = new List<Paragraph>();
    }
}