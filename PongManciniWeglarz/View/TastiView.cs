using System.Drawing;
using System.Windows.Forms;

namespace PongManciniWeglarz.View
{
    public partial class TastiView : Form
    {
        // Dichiarazione degli attributi privati della classe
        private const int LARGHEZZA_SCHERMO = 670;
        private const int ALTEZZA_SCHERMO = 580;

        /* costruttore */
        public TastiView()
        {
            InitializeComponent();
            this.Width = LARGHEZZA_SCHERMO;
            this.Height = ALTEZZA_SCHERMO;
            lblTasti.Location = new Point(50, 30);
            lblTasti.ForeColor = Color.White;
        }
    }
}

