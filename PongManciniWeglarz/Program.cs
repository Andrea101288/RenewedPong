using System;
using System.Windows.Forms;
using PongManciniWeglarz.View;


namespace PongManciniWeglarz
{
    static class Program
    {
        /// Punto di ingresso principale dell'applicazione.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GiocoView());
        }
    }
}


