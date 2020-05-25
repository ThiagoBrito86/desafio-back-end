using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Playlist.API.Model;
using Playlist.API.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;



namespace Playlist.API.Services
{
    public class SpotifyService : ISpotifyService
    {
        private readonly IOptions<AppSettings> _settings;
        private readonly HttpClient _httpClient;
        private readonly ILogger<SpotifyService> _logger;
        private readonly string _token = "BQC4LVrAJRXiXgIobJDPLZy88EOqUQfvPrf6z6ybiNWq3WZe_JNgO3iejVQ-cKyEviAjRU3Ofb8HOVQW3XYYA6eTtsnoES9iVJMJbF8nRMLWg-dxJ8IZszUKXkGotjUYdvDgdIzAdD9PkHq9Z8n1CNzGwivnUxOmRbKIbMsRDLB8lz4hkA&refresh_token=AQA4E197gZCXaaOxSCbyxvhs7OpBXA1BNcoa-i1nlLhGv0sUzL5VfOILfXnJLgJIK49YC2Xeov6k-yilMgKg8A6j-Y9Xy1eeW5pCEBUFLne0RN8Lqan-EVinBoTA-fF75wg";
        private readonly string _clienteId = "fd5ffc2af5784c87805e6429ad4d6e0a";
        private readonly string _clienteSecreto = "a44dd7dfc0564d8c9d43d14d0575da10";

        private readonly string _remoteServiceBaseUrl;

        public SpotifyService(HttpClient httpClient, ILogger<SpotifyService> logger, IOptions<AppSettings> settings)
        {
            _httpClient = httpClient;
            _settings = settings;
            _logger = logger;

            _remoteServiceBaseUrl = $"https://api.spotify.com/v1/";
        }

      

        public async Task<List<Musica>> GetPlayList(tipoGenero genero, string regiao)
        {

            var uri = Infrastructure.API.Spotify.GetMusicas(_remoteServiceBaseUrl,genero,regiao);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
            var responseString = await _httpClient.GetStringAsync(uri);
            var playlist = JsonConvert.DeserializeObject<Faixa>(responseString);

            return playlist.faixas;

        }


       



    }
}

