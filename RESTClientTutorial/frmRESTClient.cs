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

        #region Helpers

        private void WriteResponse(string response)
        {
            Debug.Write(response + Environment.NewLine);
            txtResponse.Text = txtResponse.Text + response + Environment.NewLine;
            txtResponse.SelectionStart = txtResponse.TextLength;
            txtResponse.ScrollToCaret();
        }

        #endregion

        #region Event Handlers

        private void btnGo_Click(object sender, EventArgs e)
        {
            var restClient = new RestClient(txtRestUri.Text);
            WriteResponse(restClient.MakeRequest());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResponse.Clear();
        }

        #endregion
    }
}