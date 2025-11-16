using System.Collections.Generic;

namespace BeatLeader.Models {
    internal enum BeatLeaderServer {
        COM_DOMAIN,
        NET_DOMAIN,
    }

    internal static class BeatLeaderServerUtils {
        public static readonly List<BeatLeaderServer> ServerOptions = new List<BeatLeaderServer>() {
            BeatLeaderServer.COM_DOMAIN,
            BeatLeaderServer.NET_DOMAIN
        };
        
        public static string GetName(this BeatLeaderServer server) {
            switch (server) {
                case BeatLeaderServer.NET_DOMAIN: return "localhost:5000";
                case BeatLeaderServer.COM_DOMAIN:
                default: return "gamble.lapis.codes";
            }
        }

        public static string GetAPIUrl(this BeatLeaderServer server) {
            switch (server) {
                case BeatLeaderServer.NET_DOMAIN: return "http://localhost:5000";
                case BeatLeaderServer.COM_DOMAIN:
                default: return "https://gamble.lapis.codes";
            }
        }

        public static string GetWebsiteUrl(this BeatLeaderServer server) {
            switch (server) {
                case BeatLeaderServer.NET_DOMAIN: return "http://localhost:5000";
                case BeatLeaderServer.COM_DOMAIN:
                default: return "https://gamble.lapis.codes";
            }
        }
    }
}
