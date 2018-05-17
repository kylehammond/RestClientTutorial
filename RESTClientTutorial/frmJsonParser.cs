using System;
using System.Windows.Forms;

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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRawJson.Clear();
            txtOutput.Clear();
        }

        #endregion
    }
}