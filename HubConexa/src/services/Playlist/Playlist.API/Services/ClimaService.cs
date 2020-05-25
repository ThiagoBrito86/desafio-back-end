using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Playlist.API.ViewModels;
using System.Net.Http;
using System.Threading.Tasks;



namespace Playlist.API.Services
{
    public class ClimaService : IClimaService
    {
        private readonly IOptions<AppSettings> _settings;
        private readonly HttpClient _httpClient;

        private readonly string _keyClima = "6820a32460a168648ccfe775dcfd6772";
        private readonly string _remoteServiceBaseUrl;

        public ClimaService(HttpClient httpClient, IOptions<AppSettings> settings)
        {
            _httpClient = httpClient;
            _settings = settings;
         
            _remoteServiceBaseUrl = $"http://api.openweathermap.org/data/2.5/";
        }

        public async Task<Clima> GetTemperatura(string cidade)
        {
            var uri = Infrastructure.API.Clima.GetAllTemperatura(_remoteServiceBaseUrl, cidade, _keyClima);
            var responseString = await _httpClient.GetStringAsync(uri);
            var clima = JsonConvert.DeserializeObject<Clima>(responseString);

            return clima;
        }

        public async Task<Clima> GetTemperatura(double longitude, double latitude)
        {
            var uri = Infrastructure.API.Clima.GetAllTemperatura(_remoteServiceBaseUrl, latitude, longitude, _keyClima);
            var responseString = await _httpClient.GetStringAsync(uri);
            var clima = JsonConvert.DeserializeObject<Clima>(responseString);

            return clima;
        }
    }
}

