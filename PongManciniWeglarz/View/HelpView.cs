using System.Drawing;
using System.Windows.Forms;

namespace PongManciniWeglarz.View
{
    public partial class HelpView : Form
    {
        // dichiarazione attributi privati della classe
        private const int LARGHEZZA_SCHERMO = 820;
        private const int ALTEZZA_SCHERMO = 650;

        /* costruttore */
        public HelpView()
        {
            InitializeComponent();
            this.Width = LARGHEZZA_SCHERMO;
            this.Height = ALTEZZA_SCHERMO;
            lblHelp.Location = new Point(50, 20);
            lblHelp.ForeColor = Color.White;
        }
    }
}
