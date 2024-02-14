using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Security.Principal;

namespace EncrypKey_CS_Example
{
    internal class Api
    {
        private string ownerId;
        private string secret;
        private string name;

        public Api(string ownerId, string secret, string name)
        {
            this.ownerId = ownerId;
            this.secret = secret;
            this.name = name;
        }

        public async Task<string> PostData(string baseUrl, string licenseKey)
        {
            try
            {
                Dictionary<string, string> data = new Dictionary<string, string>();
                data.Add("owner_id", ownerId);
                data.Add("secret", secret);
                data.Add("name", name);
                data.Add("license_key", licenseKey);
                data.Add("hwid", WindowsIdentity.GetCurrent().User.Value);

                // Create JSON content
                var jsonContent = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");

                // Create HttpClient and send request
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.PostAsync(baseUrl, jsonContent);

                    // Check for successful response
                    if (response.IsSuccessStatusCode)
                    {
                        // Read response content
                        string responseContent = await response.Content.ReadAsStringAsync();

                        // Parse response data (modify based on your API's response format)
                        Dictionary<string, object> responseData = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseContent);

                        return responseContent;
                    }
                    else
                    {
                        var er = "errr".ToString() + response.StatusCode + await response.Content.ReadAsStringAsync();
                        return er;
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
