using Newtonsoft.Json;
using System;

namespace Playlist.API.ViewModels
{
    public class Clima
    {
        [JsonProperty("main")]
        public Main Main { get; set; }

        [JsonProperty("sys")]
        public Sis Sys  { get; set; }

      
        public double getTemperatura()
        {
            return Main.Temp;
        }
    }
}
