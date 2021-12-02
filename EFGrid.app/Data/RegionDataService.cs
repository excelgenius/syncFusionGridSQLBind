using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using EFGrid.classes.DbModel;

namespace EFGrid.app.Data
{
    public class RegionDataService : IRegionDataService
    {
        private readonly HttpClient _httpClient;
        string sReqUri = "api/region";

        public RegionDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Region>> Regions()
        {

            //string s1 = _httpClient.GetStringAsync($"{sReqUri}").Result.ToString();

            //System.IO.Stream xx;
            //xx = await _httpClient.GetStreamAsync($"{sReqUri}");

            return await JsonSerializer.DeserializeAsync<IEnumerable<Region>>
                    (await _httpClient.GetStreamAsync($"{sReqUri}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }



        public async Task<Region> GetByID(int nID)
        {
            return await JsonSerializer.DeserializeAsync<Region>
                (await _httpClient.GetStreamAsync($"{sReqUri}/{nID}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }


        public async Task<Region> AddNew(Region cCLS)
        {
            var vJson =
                new StringContent(JsonSerializer.Serialize(cCLS), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync($"{sReqUri}", vJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<Region>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }



        public async Task UpdateRec(Region cCLS)
        {
            //Console.WriteLine("FieldAliasDataService.UpdateRec");
            var vJson =
                new StringContent(JsonSerializer.Serialize(cCLS), Encoding.UTF8, "application/json");

            await _httpClient.PutAsync($"{sReqUri}", vJson);
        }



        public async Task DeleteRec(int nID)
        {
            await _httpClient.DeleteAsync($"{sReqUri}/{nID}");
        }


       
    }
}
