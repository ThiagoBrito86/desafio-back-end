using Playlist.API.Model;
using Playlist.API.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Playlist.API.Services
{ 
    public class PlaylistService : IPlaylistService
    {

        private ISpotifyService _spotifyService;


        public PlaylistService(ISpotifyService spotifyService)
        {
            _spotifyService = spotifyService;

        }





        public Task<List<Musica>> GetPlaylist(double temperatura, string regiao)
        {
            var genero = getGeneroMusical(temperatura);

             return _spotifyService.GetPlayList(genero, regiao);
          
        }

        public tipoGenero getGeneroMusical(double temperatura)
        {
            var genero = tipoGenero.classica;

            genero = tipoGenero.classica;

            if (temperatura > 30)
            {
                genero = tipoGenero.festa;
            }
            else if (temperatura >= 15 && temperatura <= 30)
            {
                genero = tipoGenero.pop;
            }
            else if (temperatura >= 10 && temperatura <= 14)
            {
                genero = tipoGenero.rock;
            }
           
            return genero;

        }
       


    }
}
