using System;
using System.Windows.Forms;

namespace EncrypKey_CS_Example
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private async void activate_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string baseUrl = "http://127.0.0.1:8000/api/check-license";
                string ownerId = ""; // Set the owner ID
                string secret = ""; // Set the secret
                string name = ""; // Set the name

                Api api = new Api(ownerId, secret, name);
                string responseContent = await api.PostData(baseUrl, license_tb.Text.ToString());

                MessageBox.Show(responseContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
