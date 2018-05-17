using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RestClientTutorial
{
    public partial class frmRestClient : Form
    {
        public frmRestClient()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            var restClient = new RestClient(txtRestUri.Text);
            Services.WriteToTextBox(restClient.MakeRequest(), txtResponse);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResponse.Clear();
        }
    }
}