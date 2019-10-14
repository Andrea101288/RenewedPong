using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PongManciniWeglarz.Model.Forme
{
    public class RacchettaModel : FormaModel
    {
        public RacchettaModel() { }

        // metodo sovrascritto della superclasse FormaModel
        public void Disegna(Color? color)
        {
            Size size = new Size(12, 90);
            this.Size = size;
            this.Location = new Point(7, 200);
            this.Visible = false;

            // Setta il colore scelto o Nero se non è stato passato nulla
            if (color != null)
                this.BackColor = (Color) color;
            else
                this.BackColor = Color.Black;
        }
    }
}
