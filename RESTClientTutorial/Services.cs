using System;
using System.Diagnostics;
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