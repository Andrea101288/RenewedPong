using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using PongManciniWeglarz.Model;
using PongManciniWeglarz.Model.Forme;
using PongManciniWeglarz.View;

namespace PongManciniWeglarz.Controller
{
    public class GiocoController : IController
    {
        Form formPunteggio;

        // Dichiarazione attributi privati della classe
        private GiocoModel gioco;
        private PunteggioModel punteggio;
        private DifficoltaModel difficoltà;
        private PallinaModel pallina;
        private GiocoController giocoController;
        private RacchettaModel racchettaGiocatore, racchettaAvversario;
        private Panel terrenoGioco;
        private Timer timer;

        private Bitmap bmpHighscore;
        private bool gameOver, pausa;
        private string[,] highscore;

        /* Costruttore */
        public GiocoController()
        {
            pausa = false;
            gioco = new GiocoModel();
            punteggio = new PunteggioModel();
            difficoltà = new DifficoltaModel();
            bmpHighscore = new Bitmap(320, 500, PixelFormat.Format24bppRgb);
        }


        // Metodo che carica/imposta gli elementi sulla schermata di gioco
        public void Carica(Timer timerGioco, RacchettaModel racchettaMia, RacchettaModel racchettaAvversario, 
                           PallinaModel pallina, Panel terrenoGioco, Label lblPunteggioGiocatore,
                           Label lblPunteggioIA, Label lblNumLivello,
                           Panel ContainerBenvenuto, Panel ContainerFine)
        {
            if(gioco.StatoGioco == false)
            {
                this.racchettaGiocatore = racchettaMia;
                this.racchettaAvversario = racchettaAvversario;
                this.pallina = pallina;
                this.terrenoGioco = terrenoGioco;
                this.timer = timerGioco;

                // Blocco il timer
                timer.Stop();

                // Nascondo il pannello di Fine
                ContainerFine.Visible = false;

                // Mostro il panello di Benvenuto
                ContainerBenvenuto.Visible = true;

                // Disegno le racchette
                racchettaMia.Disegna(Color.GreenYellow);
                racchettaAvversario.Disegna(Color.DarkOrange);

                // Disegno la pallina
                pallina.Disegna();

                // Imposto la label: punteggio del giocatore
                lblPunteggioGiocatore.Text = "0";
                lblPunteggioGiocatore.Location = new Point(520, 10);
                lblPunteggioGiocatore.Visible = false;

                // Imposto la label: punteggio della avversario
                lblPunteggioIA.Text = "0";
                lblPunteggioIA.Location = new Point(620, 10);
                lblPunteggioIA.Visible = false;

                // Imposto Label numero del Livello
                lblNumLivello.Text = "Livello 1";
                lblNumLivello.Location = new Point(1015, 17);
                lblNumLivello.Visible = false;
            }
        }

        // Inizia una nuova partita
        public void NuovaPartita(Timer timerGioco, Label lblPunteggioGiocatore, Label lblPunteggioIA, 
                                 Label lblNumLivello, PallinaModel pallina, Panel ContainerBenvenuto)
        {

            this.timer = timerGioco;

            // Se il gioco non è già in esecuzione
            if (!gioco.StatoGioco)
            {
                // Si inizia una nuova partita
                gioco = new GiocoModel();
                MessageBox.Show("Premi OK o Invio per iniziare");

                gioco.StatoGioco = true;
                pausa = false;
                gameOver = false;

                // Faccio partire il timer
                SettaTimer(this.timer);
                timer.Interval = 1;

                // Imposto la visibilità degli elementi a schermo
                racchettaGiocatore.Visible = true;
                racchettaAvversario.Visible = true;
                pallina.Visible = true;
                lblPunteggioGiocatore.Visible = true;
                lblPunteggioIA.Visible = true;
                lblNumLivello.Visible = true;
                ContainerBenvenuto.Visible = false;

                // Resetto la velocità della pallina
                pallina.VelocitàPallaX = 7;
                pallina.VelocitàPallaY = 7;

                // Resetto i punteggi
                gioco.PuntiG = 0;
                gioco.PuntiIA = 0;

                // Resetto il livello
                gioco.Livello = 1;

                // Nuovo GiocoController
                giocoController = new GiocoController();
                // Nascondo il puntatore del mouse
                Cursor.Hide();
            }
        }


        // Muove la racchetta del giocatore
        public void MovimentoGiocatore()
        {
           // Se la racchetta è nel terreno di gioco allora la sposta
            if(Cursor.Position.Y >= racchettaGiocatore.Height / 20 && Cursor.Position.Y <= terrenoGioco.Height - racchettaGiocatore.Height + 2)
                racchettaGiocatore.Top = Cursor.Position.Y - (racchettaGiocatore.Width / 2);
        }


        // Muove la racchetta della avversario
        public void MovimentoAvversario()
        {
            // Calcola la posizione nell'asse X della racchetta avversaria
            int iaX = terrenoGioco.Width - ((racchettaAvversario.Width + racchettaAvversario.Width) - 2);

            // Calcola la posizione nell'asse Y della racchetta avversaria + un eventuale scarto di errore
            int iaY = (pallina.Location.Y - racchettaAvversario.Height / 2) + difficoltà.IAOffSet;

            if(iaY < 0)
                iaY = 0;

            if(iaY > terrenoGioco.Height - racchettaAvversario.Height)
                iaY = terrenoGioco.Height - racchettaAvversario.Height;

            // Nuova posizione della racchetta avversaria
            racchettaAvversario.Location = new Point(iaX, iaY);
        }


        // Muove la pallina
        public void MovimentoPallina()
        {
            pallina.Location = new Point(pallina.Location.X + pallina.VelocitàPallaX, pallina.Location.Y + pallina.VelocitàPallaY);
        }


        // Collisioni pallina e terreno di gioco
        public void CollisioniArea(Label lblPunteggioGiocatore, Label lblPunteggioAvversario, Label lblNumLivello, 
                                   Panel ContainerFine, Panel terrenoGioco)
        {

            // Se la pallina collide con il bordo del terreno di gioco
            if (pallina.Location.Y > terrenoGioco.Height - pallina.Height || pallina.Location.Y < 0)
            {
                // Calcola l'errore dell'avversario
                difficoltà.IACambioOffSet();
                // Inverte la direzione pallina appena tocca il bordo del terreno gioco
                pallina.VelocitàPallaY = -(pallina.VelocitàPallaY);
            }
            // Se fa punto il giocatore
            else if (pallina.Location.X > terrenoGioco.Width)
            {
                // Aggiorna il punteggio
                if (gioco.ContaPuntiGiocatore(lblPunteggioGiocatore))
                {
                    difficoltà.AumentoDifficoltà(pallina);
                    gioco.AvanzaLivello(lblPunteggioGiocatore, lblPunteggioAvversario, lblNumLivello);
                }

                // Resetta la palla
                ResettaPalla();
            }
            // Se fa punto l'avversario
            else if (pallina.Location.X < 0)
            {
                // Aggiorna il punteggio e restituisce un eventuale GameOver
                if(gioco.ContaPuntiAvversario(lblPunteggioAvversario))
                    GameOver(ContainerFine, lblNumLivello);

                // Resetta la palla
                ResettaPalla();
            }
        }


        // GameOver: partita persa contro l'avversario
        private void GameOver(Panel ContainerFine, Label lblNumLivello)
        {
            // Ferma il timer
            timer.Stop();

            // Mostra al giocatore la scritta 'GameOver'
            ContainerFine.Visible = true;

            // Mostra il puntatore del mouse
            Cursor.Show();

            // Calcola la posizione nella classifica dei punti
            int posizione = gioco.ControlloHighscore();

            if (posizione < 10)
            {
                // Finestra per inserire il nome del giocatore
                string nome = InserisciNome("Inserisci il tuo nome", "GAME OVER");

                // Aggiorna la classfica con nuovo nome e posizione
                gioco.SettaHighscore(posizione, nome);

                // Visualizza la classifica
                formPunteggio = new PunteggioView(gioco.ListaClassifica(), this);
                formPunteggio.Show();

                // Siccome è GameOver imposto lo stato del gioco a false
                gioco.StatoGioco = false;
            }
        }


        // Resetta la palla facendola tornare al punto stabilito
        private void ResettaPalla()
        {
            // Inverto la velocità della pallina
            pallina.VelocitàPallaX = -pallina.VelocitàPallaX;
            pallina.VelocitàPallaY = -pallina.VelocitàPallaY;

            // La pallina verrà resettata in questo punto
            pallina.Location = new Point(600, 350);

            // Azzera l'errore dell'avversario
            difficoltà.IAOffSet = 0;
        }


        // Collisioni tra racchette e pallina
        public void CollisioniRacchette()
        {
            // Se la pallina collide con la racchetta dell'avversario
            if(pallina.Bounds.IntersectsWith(racchettaAvversario.Bounds))
            {
                // Nuova posizione della pallina
                pallina.Location = new Point(racchettaAvversario.Location.X - pallina.Width, pallina.Location.Y);
                // Inverte la direzione dell'asse X
                pallina.VelocitàPallaX = -pallina.VelocitàPallaX;
            }

            // Se la pallina collide con la racchetta del giocatore
            if(pallina.Bounds.IntersectsWith(racchettaGiocatore.Bounds))
            {
                // Nuova posizione della pallina
                pallina.Location = new Point(racchettaGiocatore.Location.X + racchettaGiocatore.Width, pallina.Location.Y);
                // Inverte la direzione nell'asse x
                pallina.VelocitàPallaX = -pallina.VelocitàPallaX;
            }
        }

        // Carica la schermata della classifica
        public void CaricaHighscore(string[,] highscore)
        {
            this.highscore = highscore;

            Graphics schermata = Graphics.FromImage(bmpHighscore);
            schermata.Clear(formPunteggio.BackColor);
            Font font = new Font("Stencil", 20, FontStyle.Bold);
            Brush colorNumClassifica = Brushes.Gray;
            Brush nomeEpunti = Brushes.White;
            for (int j = 0; j < 9; j++)
            {
                schermata.DrawString("  " + (j + 1).ToString() + ".", font, colorNumClassifica, new PointF(0, j * 25));
                schermata.DrawString(this.highscore[j, 0], font, nomeEpunti, new PointF(60, j * 25));
                schermata.DrawString(this.highscore[j, 1].PadLeft(3, '0'), font, nomeEpunti, new PointF(130, j * 25));
            }
            schermata.DrawString("10. ", font, colorNumClassifica, new PointF(0, 9 * 25));
            schermata.DrawString(highscore[9, 0], font, nomeEpunti, new PointF(60, 9 * 25));
            schermata.DrawString(highscore[9, 1].PadLeft(3, '0'), font, nomeEpunti, new PointF(130, 9 * 25));
        }


        // * Disegna la grafica della schermata Punteggio
        public void DisegnaHighscore(PaintEventArgs e)
        {
            Graphics graphicsObj = e.Graphics;
            graphicsObj.DrawImage(bmpHighscore, 15, 10);
            graphicsObj.Dispose();
        }

        // Creazione di una finestra per inserire un nome nella classifica
        public static string InserisciNome(string text, string caption)
        {
            Form formIns = new Form();
            formIns.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            formIns.StartPosition = FormStartPosition.CenterScreen;
            formIns.Width = 190;
            formIns.Height = 160;
            formIns.Text = caption;
            Label labelFormIns = new Label() { Left = 5, Top = 10, Text = text, Width = 180 };
            labelFormIns.Font = new Font("Arial", 9, FontStyle.Bold);
            TextBox txtBox = new TextBox() { Left = 50, Top = 40, Width = 70, MaxLength = 3 };
            txtBox.TextAlign = HorizontalAlignment.Center;
            txtBox.Font = new Font("Arial", 16, FontStyle.Bold);
            Button btnInserisci = new Button() { Text = "Inserisci", Left = 50, Width = 70, Top = 80 };
            btnInserisci.Font = new Font("Arial", 7);
            btnInserisci.Click += (sender, e) => { formIns.Close(); };
            formIns.Controls.Add(btnInserisci);
            formIns.Controls.Add(labelFormIns);
            formIns.Controls.Add(txtBox);
            txtBox.Select();
            formIns.ShowDialog();

            // converte il testo in maiuscolo
            txtBox.Text = txtBox.Text.ToUpper();

            return txtBox.Text;
        }

      
        // * Mostra la schermata Punteggio
        public void MostraPunteggio()
        {
            if (!gioco.StatoGioco || pausa)
            {
                formPunteggio = new PunteggioView(gioco.ListaClassifica(), this);
                formPunteggio.Show();
            }
        }

        // * Mostra la schermata Tasti
        public void MostraTasti()
        {
            if(!gioco.StatoGioco || pausa)
            {
                TastiView tasti = new TastiView();
                tasti.Show();
            }
        }

        // * Mostra la schermata Help
        public void MostraHelp()
        {
            if(!gioco.StatoGioco || pausa)
            {
                HelpView help = new HelpView();
                help.Show();
            }
        }

        // * Comandi da tastiera
        public void Comandi(Message msg, Keys e, Timer timerGioco, RacchettaModel racchettaMia, RacchettaModel racchettaIA, 
                            PallinaModel pallina, Panel terrenoGioco, Label lblPunteggioGiocatore, Label lblPunteggioIA, 
                            Label lblNumLivello, Panel ContainerBenvenuto, Panel ContainerFine)
        {

            // se il gioco NON è in esecuzione o in pausa
            if (!gioco.StatoGioco || pausa)
            {
                // Premo F1: nuova partita
                if (e == Keys.F1)
                {
                    Carica(timerGioco, racchettaMia, racchettaIA, pallina, terrenoGioco, lblPunteggioGiocatore,
                           lblPunteggioIA, lblNumLivello, ContainerBenvenuto, ContainerFine);
                    NuovaPartita(timerGioco, lblPunteggioGiocatore, lblPunteggioIA, lblNumLivello, pallina, ContainerBenvenuto);
                }
                // Premo Esc: esco dal gioco
                if (e == Keys.Escape)
                {
                    Application.Exit();
                }
                // Premo T: mostra i tasti
                if (e == Keys.T)
                {
                    MostraTasti();
                }
                // Premo L: mostra il punteggio
                if (e == Keys.L)
                {
                    MostraPunteggio();
                }
                // Premo H: mostra la schermata Help
                if (e== Keys.H)
                {
                    MostraHelp();
                }
            }

            // Se il gioco è in esecuzione o in pausa
            if (gioco.StatoGioco || pausa)
            {
                // Premo P: gioco in pausa
                if (e == Keys.P)
                {
                    // Non sono in GameOver
                    if (gameOver == false)
                    {
                        // Se il gioco era in pausa..
                        if (pausa)
                        {
                            // ..lo riprendo
                            gioco.StatoGioco = true;
                            timer.Start();
                            pausa = false;
                            Cursor.Hide();
                        }
                        // Se il gioco era in esecuzione..
                        else
                        {
                            // ..viene fermato
                            gioco.StatoGioco = false;
                            timer.Stop();
                            pausa = true;
                            Cursor.Show();
                        }
                    }
                }
            }
        }


        // * Mette in pausa il gioco dal menù
        public void Pausa()
        {
            // Se il gioco è in esecuzione o in pausa
            if (gioco.StatoGioco || pausa)
            {
                // Non sono in GameOver
                if (gameOver == false)
                {
                    // Se il gioco era in pausa..
                    if (pausa)
                    {
                        // ..lo riprendo
                        gioco.StatoGioco = true;
                        timer.Start();
                        pausa = false;
                        Cursor.Hide();
                    }
                    // Se il gioco era in esecuzione.. 
                    else
                    {
                        // ..viene fermato
                        gioco.StatoGioco = false;
                        timer.Stop();
                        pausa = true;
                        Cursor.Show();
                    }
                }
            }
        }


        // * Premuto Esci dal menù
        public void Esci()
        {
            if (!gioco.StatoGioco || pausa)
            {
                Application.Exit();
            }
        }


        // * Fa partire il Timer
        private void SettaTimer(Timer timer)
        {
            if (gioco.StatoGioco)
            {
                timer.Start();
            }
        }
    }
}

