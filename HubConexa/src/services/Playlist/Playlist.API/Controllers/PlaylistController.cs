using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Playlist.API.Services;
using Playlist.API.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Playlist.API
{
    [Route("api/[controller]")]
    public class PlaylistController : Controller
    {
        private IClimaService _climaService;
        private IPlaylistService _playlistService;

        public PlaylistController(IClimaService climaService, IPlaylistService playlistService)
        {
            _climaService = climaService;
            _playlistService = playlistService;
        }

        [HttpGet("GetPlaylistCidade/{nomeCidade}")]
        public async Task<IActionResult> GetPlaylistCidade(string nomeCidade)
        {
            if (string.IsNullOrEmpty(nomeCidade))
                return BadRequest("Nome da cidade não pode ser vazio!");


            var clima = await _climaService.GetTemperatura(nomeCidade);
            if (clima == null)
                return NotFound("Clima não encontrado para cidade " + nomeCidade);
           
            var playlist = await _playlistService.GetPlaylist(clima.getTemperatura(), clima.Sys.Pais);
            if (playlist == null)
                return NotFound("Playlist não encontrada para cidade " + nomeCidade);

            return Ok( playlist);           
        }


        [HttpGet("GetPlaylistLocalizacao/{latitude}/{longitude}")]
        public async Task<IActionResult> GetPlaylistLocalizacao(double latitude, double longitude)
        {
            var clima = await _climaService.GetTemperatura(longitude,latitude);
            if (clima == null)
                return NotFound("Clima não encontrado para esta localização latitude:" + latitude.ToString() + " longitude: " + longitude.ToString());

            var playlist = await _playlistService.GetPlaylist(clima.getTemperatura(), clima.Sys.Pais);
            if (playlist == null)
                return NotFound("Playlist não encontrada para esta localização latitude:" + latitude.ToString() + " longitude: " + longitude.ToString());

            return Ok(playlist);
        }

    }
}
