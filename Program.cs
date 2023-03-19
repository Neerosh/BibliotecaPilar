using BibliotecaPilar.Data;
using BibliotecaPilar.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;

namespace BibliotecaPilar
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            InitialData initialDate = new InitialData();

            Application.Run(new Login());
        }
    }
}