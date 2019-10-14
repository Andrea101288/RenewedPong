using System;
using System.Drawing;
using System.Windows.Forms;
using PongManciniWeglarz.Model.Forme;
using PongManciniWeglarz.Controller;


namespace PongManciniWeglarz.View
{
    public partial class GiocoView
    {
        // dichiarazione attributi privati della classe
        private GiocoController giocoController;
        private const int LARGHEZZA_SCHERMO = 1200;
        private const int ALTEZZA_SCHERMO = 700;


        /* Costruttore */
        public GiocoView()
        {
            InitializeComponent();
            giocoController = new GiocoController();

            timerGioco.Enabled = true;

            this.Width = LARGHEZZA_SCHERMO;
            this.Height = ALTEZZA_SCHERMO;
            this.BackColor = Color.Black;
        }


        // Caricamento della GiocoView 
        private void GiocoView_Load(object sender, EventArgs e)
        {
            // Disegna e imposta gli oggetti a schermo
            giocoController.Carica(timerGioco, racchettaMia, racchettaIA, pallina, terrenoGioco, lblPunteggioGiocatore, lblPunteggioAvversario,
                                   lblNumLivello, ContainerBenvenuto, ContainerFine);
        }

        // Click sul menù Nuovo
        private void menuNuovo_Click(object sender, EventArgs e)
        {
            // Disegna gli oggetti sullo piano di gioco
            giocoController.Carica(timerGioco, racchettaMia, racchettaIA, pallina, terrenoGioco,
                                   lblPunteggioGiocatore, lblPunteggioAvversario,
                                   lblNumLivello, ContainerBenvenuto, ContainerFine);
            // Inizializza una nuova partita
            giocoController.NuovaPartita(timerGioco, lblPunteggioGiocatore, lblPunteggioAvversario, lblNumLivello, pallina, ContainerBenvenuto);
        }

        // Scandisce il timer di gioco
        private void timerGioco_Tick(object sender, EventArgs e)
        {
            // Gestisce la racchetta del giocatore
            giocoController.MovimentoGiocatore();

            // Muove la racchetta dell'avversario
            giocoController.MovimentoAvversario();

            // Muove la pallina
            giocoController.MovimentoPallina();

            // Gestisce le collisioni pallina/terreno di gioco
            giocoController.CollisioniArea(lblPunteggioGiocatore, lblPunteggioAvversario, lblNumLivello, ContainerFine, terrenoGioco);

            // Gestisce collisioni pallina/racchette
            giocoController.CollisioniRacchette();
        }


        // Click menu esci
        private void menuEsci_Click(object sender, EventArgs e)
        {
            // Esce dal gioco
            giocoController.Esci();
        }

        // Click menu Pausa
        private void menuPausa_Click(object sender, EventArgs e)
        {
            // Mette in pausa il gioco
            giocoController.Pausa();
        }

        // Evento pressione tasti su tastiera
        protected override bool ProcessCmdKey(ref Message msg, Keys e)
        {
            // Sceglie e gestisce i tasti premuti 
            giocoController.Comandi(msg, e, timerGioco, racchettaMia, racchettaIA, pallina, terrenoGioco, lblPunteggioGiocatore, lblPunteggioAvversario, lblNumLivello, 
                                    ContainerBenvenuto, ContainerFine);

            return base.ProcessCmdKey(ref msg, e);
        }

        // Click menu Punteggio
        private void menuPunteggio_Click(object sender, EventArgs e)
        {
            // Mostra la classifica dei livelli massimi raggiunti
            giocoController.MostraPunteggio();
        }

        // Click menu Tasti
        private void menuTasti_Click(object sender, EventArgs e)
        {
            // Mostra la form dei tasti
            giocoController.MostraTasti();
        }

        // Click menu Help
        private void menuHelp_Click(object sender, EventArgs e)
        {
            // Mostra la schermata Help
            giocoController.MostraHelp();
        }
    }
}

    

