﻿using System;
using System.Windows.Forms;
using RestClientTutorial.Forms;

namespace RestClientTutorial
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmRestClient());
            Application.Run(new frmJsonParser());
        }
    }
}