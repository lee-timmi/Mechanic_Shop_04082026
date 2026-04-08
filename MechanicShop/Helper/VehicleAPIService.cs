using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MechanicShopSystem.Helpers
{
    public class VehicleApiService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<List<string>> GetAllMakes()
        {
            try
            {
                string url = "https://vpic.nhtsa.dot.gov/api/vehicles/GetAllMakes?format=json";
                HttpResponseMessage response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    return ParseMakesFromJson(json);
                }
                return new List<string>();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"API Error: {ex.Message}");
                return new List<string>();
            }
        }

        private List<string> ParseMakesFromJson(string json)
        {
            var makes = new List<string>();
            var serializer = new JavaScriptSerializer();

            // Deserialize to a dynamic object
            dynamic result = serializer.Deserialize<dynamic>(json);

            foreach (var item in result["Results"])
            {
                string makeName = item["Make_Name"];
                if (!string.IsNullOrEmpty(makeName))
                {
                    makes.Add(makeName);
                }
            }

            return makes;
        }
    }
}