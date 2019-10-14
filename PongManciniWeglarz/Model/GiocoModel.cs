using System.Windows.Forms;
using PongManciniWeglarz.Model.Forme;



namespace PongManciniWeglarz.Model
{
    class GiocoModel
    {
        // Dichiarazione attributi privati della classe
        private GiocatoreModel giocatore;
        private PunteggioModel highscore;
        private DifficoltaModel difficoltà;

        private int punteggioGiocatore;
        private int punteggioAvversario;
        private int livello = 1;
        private bool statoGioco;

        /* Costruttore */
        public GiocoModel()
        {
            punteggioGiocatore = 0;
            punteggioAvversario = 0;
            livello = 1;

            difficoltà = new DifficoltaModel();
            highscore = new PunteggioModel();
            giocatore = new GiocatoreModel(System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\')[1], 0);
        }

        // Ritorna l'elenco in classifica
        public string[,] ListaClassifica()
        {
            string[,] lista = new string[10, 2];

            for (int i = 0; i < 10; i++)
            {
                lista[i, 0] = highscore.TrovaGiocatore(i).GetNome;
                lista[i, 1] = highscore.TrovaGiocatore(i).Punteggio.ToString().PadLeft(3, '0');
            }

            return lista;
        }


        // Calcola la posizione in classifica del puntaggio fatto
        public int ControlloHighscore()
        {
            int k = 9;
            int j = -1;

            while (k >= 1)
            {
                // Se il punteggio (livello max raggiunto) è maggiore o uguale del punteggio del giocatore alla posizione k
                if (this.livello >= highscore.TrovaGiocatore(k).Punteggio && this.livello > 0)
                {
                    // Se il punteggio (livello max raggiunto) è minore del punteggio del giocatore che lo precede
                    if (this.livello < highscore.TrovaGiocatore(k - 1).Punteggio)
                    {
                        // la nuova posizione sarà proprio k
                        j = k;
                        k = 0;
                    }
                    else
                    {
                        // Se il punteggio (livello max raggiunto) è maggiore o uguale del primo in classifica
                        if (this.livello >= highscore.TrovaGiocatore(0).Punteggio)
                        {
                            // la sua posizione sarà 0 (ovvero in testa alla classifica)
                            k = j = 0;
                        }
                    }
                }

                k--;
            }

            // Torna la posizione in classifica
            return j;
        }


        // Viene inserito nome giocatore, poszione e relativo punteggio
        public void SettaHighscore(int posizione, string nome)
        {
            giocatore = giocatore.CambiaNome(nome);

            // Il punteggio corrisponde al livello massimo raggiunto dal giocatore
            giocatore.Punteggio = this.Livello;
            highscore.InserisciGiocatore(posizione, giocatore);
        }

        // Metodo chiamato quando il giocatore segna un punto
        public bool ContaPuntiGiocatore(Label lblPunteggioGiocatore)
        {
            // Incrementa i punti
            punteggioGiocatore++;

            // Aggiorno il contatore
            lblPunteggioGiocatore.Text = punteggioGiocatore.ToString();
            
            if(punteggioGiocatore >= 3)
                return true;

            return false;
        }

        // Metodo chiamato quando l'avversario segna un punto
        public bool ContaPuntiAvversario(Label lblPunteggioAvversario)
        {
            // Incrementa i punti
            punteggioAvversario++;

            // Aggiorno il contatore
            lblPunteggioAvversario.Text = punteggioAvversario.ToString();
            
            if(punteggioAvversario >= 3)
                return true;

            return false;
        }

        // Avanza di livello
        public void AvanzaLivello(Label lblPunteggioGiocatore, Label lblPunteggioAvversario, Label lblLivello)
        {
            // Resetto i punteggi
            punteggioGiocatore = 0;
            punteggioAvversario = 0;

            // Aumento di livello
            livello++;

            // Aggiorno la schermata
            lblPunteggioGiocatore.Text = punteggioGiocatore.ToString();
            lblPunteggioAvversario.Text = punteggioAvversario.ToString();

            lblLivello.Text = "Livello: " + livello.ToString();
        }

        // Proprietà che legge/imposta lo stato del gioco
        public bool StatoGioco { get => statoGioco;  set => statoGioco = value; }

        // Proprietà che legge/imposta i punti del giocatore
        public int PuntiG { get => punteggioGiocatore; set => punteggioGiocatore = value; }

        // Proprietà che legge/imposta i punti della IA
        public int PuntiIA { get => punteggioAvversario; set => punteggioAvversario = value; }

        // Proprietà che legge/imposta il Livello di gioco
        public int Livello { get => livello; set => livello = value; }

        // Priorietà che ritorna il miglior punteggio in classifica
        public GiocatoreModel Highscore { get => highscore.TrovaGiocatore(0); }
    }
}
