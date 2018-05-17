using System;
using System.Windows.Forms;
using RestClientTutorial.JsonObjects;
using RestClientTutorial.Services;

namespace RestClientTutorial.Forms
{
    public partial class frmJsonParser : Form
    {
        public frmJsonParser()
        {
            InitializeComponent();
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();

            var person = JsonService.GetDeserializedObject<Person>(txtRawJson.Text);

            WinFormService.WriteToTextBox(person.ToString(), txtOutput);
            WinFormService.WriteToTextBox("Last name: " + person.lastname, txtOutput);
            WinFormService.WriteToTextBox("Address: " + person.address.streetaddress, txtOutput);
            foreach (var phonenumber in person.phonenumbers) WinFormService.WriteToTextBox("Phone number: " + phonenumber.number, txtOutput);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRawJson.Clear();
            txtOutput.Clear();
        }
    }
}