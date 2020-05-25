using Playlist.API.Model;
using Playlist.API.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Playlist.API.Services
{
    public interface ISpotifyService
    {
      
            Task<List<Musica>> GetPlayList(tipoGenero genero, string regiao);
            
        
    }
}
