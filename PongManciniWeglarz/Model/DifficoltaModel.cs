using System;
using System.Windows.Forms;
using PongManciniWeglarz.Model.Forme;

namespace PongManciniWeglarz.Model
{
    class DifficoltaModel
    {
        // Dichiarazione attributi privati della classe
        private int iaOffSet;
        private int iaOffSetContatore;
        private int iaOffSetCiclo;
        private int vDiffLivello;
        private Random difficoltàCasuale;
        
        /* Costruttore */
        public DifficoltaModel()
        {
            iaOffSetCiclo = 7;
            vDiffLivello = 20;
            difficoltàCasuale = new Random();
        }

        // Difficoltà IA (calcola i suoi sbagli)
        public void IACambioOffSet()
        {
            if (iaOffSetContatore >= iaOffSetCiclo)
            {
                iaOffSet = difficoltàCasuale.Next(-305 + vDiffLivello, 305 - vDiffLivello);
                iaOffSetContatore = 1;
            }
            else
            {
                iaOffSetContatore++;
            }
        }

        // Aumenta la difficoltà di gioco: pallina più veloce, IA più capace
        public void AumentoDifficoltà(PallinaModel pallina)
        {
            pallina.VelocitàPallaX += 1;
            pallina.VelocitàPallaY += 1;

            iaOffSetCiclo += 1;
            vDiffLivello += 10;
        }

        // Proprietà le legge/imposta l'errore dell'IA
        public int IAOffSet{ get => iaOffSet; set => iaOffSet = value; }

        // Proprietà le legge/imposta ogni quanto l'IA sbaglia
        public int IAOffSetCiclo{ get => iaOffSetCiclo; set => iaOffSetCiclo = value; }

        // Proprietà le legge/imposta vDiffLivello
        public int VDiffLivello{ get => vDiffLivello; set => vDiffLivello = value; }
    }
}
