using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesseractTester.Models
{
    public class Rect
    {
        [JsonProperty("left")]
        public int Left { get; set; }
        [JsonProperty("top")]
        public int Top { get; set; }
        [JsonProperty("right")]
        public int Right { get { return Left + Width; } }
        [JsonProperty("bottom")]
        public int Bottom { get { return Top + Height; } }

        [JsonProperty("width")]
        public int Width { get; set; }
        [JsonProperty("height")]
        public int Height { get; set; }
    }
}

