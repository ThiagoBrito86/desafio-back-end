using Catalog.FunctionalTests;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Playlist.FunctionalTests
{
    public class PlaylistCenarios
       : PlaylistCenariosBase
    {
        [Fact]
        public async Task Get_get_playlist_by_cidade_and_response_ok_status_code()
        {
            using (var server = CreateServer())
            {
                var response = await server.CreateClient()
                    .GetAsync(Get.PlaylistByCidade("Goiania"));

                response.EnsureSuccessStatusCode();
            }
        }

      

        [Fact]
        public async Task Get_get_playlist_by_cidade_and_response_not_found_status_code()
        {
            using (var server = CreateServer())
            {
                var response = await server.CreateClient()
                    .GetAsync(Get.PlaylistByCidade("CidadeInexistente"));

                Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
            }
        }
    }
}
