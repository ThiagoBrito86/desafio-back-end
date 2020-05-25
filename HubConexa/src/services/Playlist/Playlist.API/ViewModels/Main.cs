using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Playlist.API.ViewModels
{
    public class Main
    {
        [JsonProperty("temp")]
        public double Temp { get; set; }
    }
}
