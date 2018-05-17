using System;
using System.Windows.Forms;
using RestClientTutorial.Services;

namespace RestClientTutorial.Forms
{
    public partial class frmRestClient : Form
    {
        public frmRestClient()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            var restClient = new RestService(txtRestUri.Text);
            WinFormService.WriteToTextBox(restClient.MakeRequest(), txtResponse);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResponse.Clear();
        }
    }
}