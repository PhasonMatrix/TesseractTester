using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesseractTester.Models
{
    public class Page
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }
        [JsonProperty("rect")]
        public Rect Rect { get; set; }
        [JsonProperty("blocks")]
        public List<Block> Blocks { get; set; } = new List<Block>();
    }
}