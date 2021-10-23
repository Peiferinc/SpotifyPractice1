using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyServices
{
    public interface ISpotifyService
    {
        Task<IEnumerable<Release>> GetNewReleases(string countryCode, int limit, string accessToken);
    }
}
