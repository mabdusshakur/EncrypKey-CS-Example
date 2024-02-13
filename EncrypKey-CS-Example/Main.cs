using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace EncrypKey_CS_Example
{
    public partial class Main : Form
    {
        private string baseUrl = "http://127.0.0.1:8000/api/check-license";

        public Main()
        {
            InitializeComponent();
        }

        private void license_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private async void activate_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> data = new Dictionary<string, string>();
                data.Add("owner_id", "");
                data.Add("secret", "");
                data.Add("name", "");
                data.Add("license_key", license_tb.Text.ToString());
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

                        MessageBox.Show(responseContent);
                    }
                    else
                    {
                        var er = "errr".ToString() + response.StatusCode + await response.Content.ReadAsStringAsync();
                        MessageBox.Show(er);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
