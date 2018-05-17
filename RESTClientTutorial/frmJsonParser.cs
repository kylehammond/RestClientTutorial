using System;
using System.Windows.Forms;
using RestClientTutorial.Services;

namespace RestClientTutorial
{
    public partial class frmJsonParser : Form
    {
        public frmJsonParser()
        {
            InitializeComponent();
        }

        #region EventHandlers

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            Helpers.WriteToTextBox(JsonService.GetDeserializedJson(txtRawJson.Text).ToString(), txtOutput);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRawJson.Clear();
            txtOutput.Clear();
        }

        #endregion
    }
}