
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using NUnit.Framework;
using Playlist.API;
using Playlist.API.Model;
using Playlist.API.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace UnitTest.Catalog.Application
{
    public class PlaylistControllerTest
    {
        private IPlaylistService playlistService;
        private ServiceCollection services;
        public PlaylistControllerTest()
        {
            services = new ServiceCollection();
            services.AddTransient<IPlaylistService, PlaylistService>();
          
            var serviceProvider = services.BuildServiceProvider();

        }

        [Fact]
        public async Task Get_GeneroMusical()
        {
            //Arrange
            
            var TemperaturaFesta = 31;
            var TemperaturaPop = 16;
            var TemperaturaRock = 11;
            var TemperaturaClassica = 1;
           
            //Act
            var actFesta = playlistService.getGeneroMusical(TemperaturaFesta);
            var actPop = playlistService.getGeneroMusical(TemperaturaPop);
            var actRock = playlistService.getGeneroMusical(TemperaturaRock);
            var actClassica = playlistService.getGeneroMusical(TemperaturaClassica);
           
            //Assert

            Assert.Equals(actFesta ,tipoGenero.festa);
            Assert.Equals(actPop, tipoGenero.pop);
            Assert.Equals(actRock, tipoGenero.rock);
            Assert.Equals(actClassica, tipoGenero.classica);
        }


     

    }

 

}
