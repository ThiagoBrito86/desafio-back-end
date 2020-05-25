using Playlist.API.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Playlist.API.Services
{
    public interface IClimaService
    {
        Task<Clima> GetTemperatura(string cidade);
        Task<Clima> GetTemperatura(double longitude, double latitude);
    }
}
