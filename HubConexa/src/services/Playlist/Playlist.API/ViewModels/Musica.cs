using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Playlist.API.ViewModels
{
    public class Musica
    {
        [JsonProperty("name")]
        public string Nome { get; set; }
    }
}
