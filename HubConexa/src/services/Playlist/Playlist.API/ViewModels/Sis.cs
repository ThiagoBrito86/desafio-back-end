using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Playlist.API.ViewModels
{
    public class Sis
    {
        [JsonProperty("country")]
        public string Pais { get; set; }
    }
}
