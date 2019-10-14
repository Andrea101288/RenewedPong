using System;
using System.Windows.Forms;
using PongManciniWeglarz.Controller;

namespace PongManciniWeglarz.View
{
    public partial class PunteggioView : Form
    {
        // Dichiarazione degli attributi privati della classe
        private string[,] highscore;
        private const int LARGHEZZA_SCHERMO = 270;
        private const int ALTEZZA_SCHERMO = 320;

        GiocoController giocoController;

        /* costruttore */
        public PunteggioView(string[,] highscore, GiocoController giocoController)
        {
            // Assegnamento dei valori passati
            this.highscore = highscore;
            this.giocoController = giocoController;
            InitializeComponent();
            this.Width = LARGHEZZA_SCHERMO;
            this.Height = ALTEZZA_SCHERMO;
        }


        // Caricamento della PunteggioView
        private void PunteggioView_Load(object sender, EventArgs e)
        {
            // crea la grafica per la schermata Punteggio
            this.giocoController.CaricaHighscore(this.highscore);
        }

        // Disegno PunteggioView
        private void PunteggioView_Paint(object sender, PaintEventArgs e)
        {
            // disegna la schermata Punteggio
            this.giocoController.DisegnaHighscore(e);
        }
    }
}
