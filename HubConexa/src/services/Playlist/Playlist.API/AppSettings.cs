using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Playlist.API
{
    public class AppSettings
    {
        public string MarketingUrl { get; set; }
        public  string KeyClima { get; set; }

        public bool ActivateCampaignDetailFunction { get; set; }
        public Logging Logging { get; set; }
        public bool UseCustomizationData { get; set; }
    }

    public class Logging
    {
        public bool IncludeScopes { get; set; }
        public Loglevel LogLevel { get; set; }
    }

    public class Loglevel
    {
        public string Default { get; set; }
        public string System { get; set; }
        public string Microsoft { get; set; }
    }
}
