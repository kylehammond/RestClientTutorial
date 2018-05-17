using System;
using System.Windows.Forms;
using RestClientTutorial.JsonObjects;
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

            var person = JsonService.GetDeserializedJson<Person>(txtRawJson.Text);

            FormService.WriteToTextBox(person.ToString(), txtOutput);
            FormService.WriteToTextBox("Last name: " + person.lastname, txtOutput);
            FormService.WriteToTextBox("Address: " + person.address.streetaddress, txtOutput);
            foreach (var phonenumber in person.phonenumbers)
            {
                FormService.WriteToTextBox("Phone number: " + phonenumber.number, txtOutput);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRawJson.Clear();
            txtOutput.Clear();
        }

        #endregion
    }
}