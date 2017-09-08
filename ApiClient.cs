using HttpHandler;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbAPI
{
    public class ApiClient
    {
        Client client = null;

        /// <summary>
        /// Initialize Client with Base Url of API and user-key
        /// </summary>
        /// <param name="api_base_url">API base Url</param>
        public ApiClient(string api_base_url)
        {
            client = new Client(api_base_url);
            
        }

        /// <summary>
        /// Set API Auth Header if required
        /// </summary>
        /// <param name="key">Header Key</param>
        /// <param name="value">Header Value</param>
        public void SetAuthHeader(string key, string value)
        {
            client.AddHeader(key, value);
        }

        public async Task<List<Game>> GetGamesAsync()
        {
            return await client.GetDataAsync<List<Game>>("games/?fields=*&limit=50");
        }

        public async Task<Game> GetGameAsync(long id)
        {
            var result = await client.GetDataAsync<List<Game>>(string.Format("games/{0}/?fields=*", id));
            return result == null ? null : result.FirstOrDefault();
        }

        public async Task<List<Platform>> GetPlatformsAsync()
        {
            return await client.GetDataAsync<List<Platform>>("platforms/?fields=*&limit=50");
        }

        public async Task<Platform> GetPlatformAsync(long id)
        {
            var result = await client.GetDataAsync<List<Platform>>(string.Format("platforms/{0}/?fields=*", id));
            return result == null ? null : result.FirstOrDefault();
        }

        public async Task<List<Game>> GetPlatformGamesAsync(long id)
        {
            return await client.GetDataAsync<List<Game>>(string.Format("platforms/{0}/games/?fields=*", id));
        }

        public async Task<List<Collection>> GetCollectionsAsync()
        {
            return await client.GetDataAsync<List<Collection>>("collections/?fields=*&limit=50");
        }

        public async Task<Collection> GetCollectionAsync(long id)
        {
            var result = await client.GetDataAsync<List<Collection>>(string.Format("collections/{0}/?fields=*", id));
            return result == null ? null : result.FirstOrDefault();
        }

        public async Task<List<Company>> GetCompaniesAsync()
        {
            return await client.GetDataAsync<List<Company>>("companies/?fields=*&limit=50");
        }

        public async Task<Company> GetCompanyAsync(long id)
        {
            var result = await client.GetDataAsync<List<Company>>(string.Format("companies/{0}/?fields=*", id));
            return result == null ? null : result.FirstOrDefault();
        }

        public async Task<List<Game>> GetCompanyGamesAsync(long id)
        {
            return await client.GetDataAsync<List<Game>>(string.Format("companies/{0}/games/?fields=*", id));
        }


        public async Task<List<People>> GetPeoplesAsync()
        {
            return await client.GetDataAsync<List<People>>("people/?fields=*&limit=50");
        }

        public async Task<People> GetPeopleAsync(long id)
        {
            var result = await client.GetDataAsync<List<People>>(string.Format("people/{0}/?fields=*", id));
            return result == null ? null : result.FirstOrDefault();
        }

        public async Task<List<Game>> GetPeopleGamesAsync(long id)
        {
            return await client.GetDataAsync<List<Game>>(string.Format("people/{0}/games/?fields=*", id));
        }


        public async Task<List<Franchise>> GetFranchisesAsync()
        {
            return await client.GetDataAsync<List<Franchise>>("franchises/?fields=*&limit=50");
        }

        public async Task<Franchise> GetFranchiseAsync(long id)
        {
            var result = await client.GetDataAsync<List<Franchise>>(string.Format("franchises/{0}/?fields=*", id));
            return result == null ? null : result.FirstOrDefault();
        }

        public async Task<List<Game>> GetFranchiseGamesAsync(long id)
        {
            return await client.GetDataAsync<List<Game>>(string.Format("franchises/{0}/games/?fields=*", id));
        }

    }
}
