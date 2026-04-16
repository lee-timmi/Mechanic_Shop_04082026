using System;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Threading.Tasks;

namespace MehcnicShop.Helper
{
    public class VehicleInfo
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
    }

    public class VehicleApiService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        // The ONLY method you need
        public async Task<VehicleInfo> GetVehicleByVIN(string vin)
        {
            // Thimmy GOAL 00 : Validate VIN input
            if (string.IsNullOrWhiteSpace(vin) || vin.Length != 17)
            {
                throw new ArgumentException("VIN must be exactly 17 characters");
            }

            try
            {
                // Thimmy GOAL 01 : GET request to NHTSA API
                string url = $"https://vpic.nhtsa.dot.gov/api/vehicles/DecodeVinValues/{vin}?format=json";
                HttpResponseMessage response = await _httpClient.GetAsync(url);

                // Check if the response is successful
                if (!response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        throw new Exception("API rate limit exceeded. Please wait a moment.");
                    }
                    
                    else if ((int)response.StatusCode == 429)
                    {
                        throw new Exception("API endpoint not found. Please try again later.");
                    }
                    else
                    {
                        throw new Exception($"API error: {response.StatusCode}");
                    }
                }
                   
               
                // Thimmy GOAL 02 : Parse JSON to C# object
                string json = await response.Content.ReadAsStringAsync();
                var serializer = new JavaScriptSerializer();
                dynamic result = serializer.Deserialize<dynamic>(json);

                // Check if we got JSON data and if it contains the expected "Results" array
                if (result?["Results"] == null || result["Results"].Length == 0)
                {
                    return null; // No data found for this VIN
                }


                if (result["Results"] != null && result["Results"].Length > 0)
                {
                    dynamic vehicle = result["Results"][0];

                    // Thimmy GOAL 03 : POPULATE: Map to VehicleInfo
                    return new VehicleInfo 
                    {
                        Make = vehicle["Make"] ?? "",
                        Model = vehicle["Model"] ?? "",
                        Year = vehicle["ModelYear"] ?? ""
                    };
                }
                return null;
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Network error: Cannot reach API. {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception($"JSON parsing error: {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Unexpected error: {ex.Message}");
            }
        }
    }
}