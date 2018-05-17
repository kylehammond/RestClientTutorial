using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestClientTutorial
{
    public static class Services
    {
        public static void WriteToTextBox(string response, TextBox textBox)
        {
            Debug.Write(response + Environment.NewLine);
            textBox.Text = textBox.Text + response + Environment.NewLine;
            textBox.SelectionStart = textBox.TextLength;
            textBox.ScrollToCaret();
        }
    }
}
