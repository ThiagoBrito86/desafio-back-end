

using Playlist.API.Model;

namespace Playlist.API.Infrastructure
{
    public static class API
    {

        public static class Clima
        {
            public static string GetAllTemperatura(string baseUri, string cidade, string key)
            {
              
                return $"{baseUri}weather?q={cidade}&appid={key}&units=metric";
            }


            public static string GetAllTemperatura(string baseUri, double latitude, double longitude, string key)
            {

                return $"{baseUri}weather?&lat={latitude}&lon={longitude}&appid={key}&units=metric";
            }

        }

        public static class Spotify
        {
            public static string GetMusicas(string baseUri, tipoGenero genero, string country)
            {

                return $"{baseUri}recommendations?limit=50&market={country}&seed_genres={genero.ToString()}";
            }

           
        }
    }


}
