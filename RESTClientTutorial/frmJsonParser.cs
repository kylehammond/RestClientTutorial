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
            txtOutput.Clear();

            var deserializedObject = JsonService.GetDeserializedJson(txtRawJson.Text);

            FormService.WriteToTextBox(deserializedObject.ToString(), txtOutput);
            FormService.WriteToTextBox("Random property: " + deserializedObject.lastname, txtOutput);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRawJson.Clear();
            txtOutput.Clear();
        }

        #endregion
    }
}