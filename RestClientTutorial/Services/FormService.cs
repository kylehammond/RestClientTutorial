using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RestClientTutorial.Services
{
    //todo: can these be extension methods?
    public static class FormService
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