using Playlist.API.Model;
using Playlist.API.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Playlist.API.Services
{
     public interface IPlaylistService
    {
        Task<List<Musica>> GetPlaylist(double temperatura, string regiao);
        public tipoGenero getGeneroMusical(double temperatura);
    }
}
