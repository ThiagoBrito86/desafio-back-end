using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Playlist.API.ViewModels
{
    public class Faixa
    {
        [JsonProperty("tracks")]
        public List<Musica> faixas { get; set; }
    }
}
