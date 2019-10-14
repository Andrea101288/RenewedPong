using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PongManciniWeglarz.Model.Forme
{
    public class PallinaModel : FormaModel
    {
        // Dichiarazione attributi privati classe
        private int velocitàPallaX;
        private int velocitàPallaY;

        // costruttore
        public PallinaModel()
        {
           this.Size = new Size(25, 25);
        }

        // metodo sovrascritto della superclasse FormaModel
        public override void Disegna()
        {
            this.Location = new Point(7, 200);
            this.Visible = false;            
        }

        // proprietà che legge e imposta la velocità X
        public int VelocitàPallaX { get => velocitàPallaX; set => velocitàPallaX = value; }

        // proprietà che legge e imposta la velocità Y
        public int VelocitàPallaY { get => velocitàPallaY; set => velocitàPallaY = value; }
    }
}
