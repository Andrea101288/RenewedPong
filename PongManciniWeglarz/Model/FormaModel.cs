using System.Windows.Forms;

namespace PongManciniWeglarz.Model
{
    public class FormaModel : PictureBox
    {
        // Costruttore protetto: impedisce la creazione di un oggetto se
        // si prova ad utilizzare new FormaModel
        protected FormaModel() { /* */ }

        // metodo virtuale: permette l'overriding in classi derivate
        public virtual void Disegna() { /* */}

    }
}
