using PongManciniWeglarz.Model.Forme;

namespace PongManciniWeglarz.View
{
    partial class GiocoView : Principale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStripGioco = new System.Windows.Forms.MenuStrip();
            this.giocoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNuovo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPausa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEsci = new System.Windows.Forms.ToolStripMenuItem();
            this.difficoltàToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPunteggio = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTasti = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.facileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerGioco = new System.Windows.Forms.Timer(this.components);
            this.terrenoGioco = new System.Windows.Forms.Panel();
            this.ContainerFine = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pallina = new PongManciniWeglarz.Model.Forme.PallinaModel();
            this.ContainerBenvenuto = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumLivello = new System.Windows.Forms.Label();
            this.lblPunteggioAvversario = new System.Windows.Forms.Label();
            this.lblPunteggioGiocatore = new System.Windows.Forms.Label();
            this.racchettaIA = new PongManciniWeglarz.Model.Forme.RacchettaModel();
            this.racchettaMia = new PongManciniWeglarz.Model.Forme.RacchettaModel();
            this.menuStripGioco.SuspendLayout();
            this.terrenoGioco.SuspendLayout();
            this.ContainerFine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pallina)).BeginInit();
            this.ContainerBenvenuto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racchettaIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racchettaMia)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripGioco
            // 
            this.menuStripGioco.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giocoToolStripMenuItem,
            this.difficoltàToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStripGioco.Location = new System.Drawing.Point(0, 0);
            this.menuStripGioco.Name = "menuStripGioco";
            this.menuStripGioco.Size = new System.Drawing.Size(1184, 24);
            this.menuStripGioco.TabIndex = 0;
            this.menuStripGioco.Text = "menuStrip1";
            // 
            // giocoToolStripMenuItem
            // 
            this.giocoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNuovo,
            this.menuPausa,
            this.menuEsci});
            this.giocoToolStripMenuItem.Name = "giocoToolStripMenuItem";
            this.giocoToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.giocoToolStripMenuItem.Text = "Gioca";
            // 
            // menuNuovo
            // 
            this.menuNuovo.Name = "menuNuovo";
            this.menuNuovo.Size = new System.Drawing.Size(194, 22);
            this.menuNuovo.Text = "Nuova  Partita           F1";
            this.menuNuovo.Click += new System.EventHandler(this.menuNuovo_Click);
            // 
            // menuPausa
            // 
            this.menuPausa.Name = "menuPausa";
            this.menuPausa.Size = new System.Drawing.Size(194, 22);
            this.menuPausa.Text = "Pausa              P";
            this.menuPausa.Click += new System.EventHandler(this.menuPausa_Click);
            // 
            // menuEsci
            // 
            this.menuEsci.Name = "menuEsci";
            this.menuEsci.Size = new System.Drawing.Size(194, 22);
            this.menuEsci.Text = "Esci                Esc";
            this.menuEsci.Click += new System.EventHandler(this.menuEsci_Click);
            // 
            // difficoltàToolStripMenuItem
            // 
            this.difficoltàToolStripMenuItem.Name = "difficoltàToolStripMenuItem";
            this.difficoltàToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPunteggio,
            this.menuTasti,
            this.menuHelp});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // menuPunteggio
            // 
            this.menuPunteggio.Name = "menuPunteggio";
            this.menuPunteggio.Size = new System.Drawing.Size(178, 22);
            this.menuPunteggio.Text = "Classifica       L";
            this.menuPunteggio.Click += new System.EventHandler(this.menuPunteggio_Click);
            // 
            // menuTasti
            // 
            this.menuTasti.Name = "menuTasti";
            this.menuTasti.Size = new System.Drawing.Size(178, 22);
            this.menuTasti.Text = "Comandi                T";
            this.menuTasti.Click += new System.EventHandler(this.menuTasti_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(178, 22);
            this.menuHelp.Text = "Help                H";
            this.menuHelp.Click += new System.EventHandler(this.menuHelp_Click);
            // 
            // facileToolStripMenuItem
            // 
            this.facileToolStripMenuItem.Name = "facileToolStripMenuItem";
            this.facileToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // medioToolStripMenuItem
            // 
            this.medioToolStripMenuItem.Name = "medioToolStripMenuItem";
            this.medioToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // difficileToolStripMenuItem
            // 
            this.difficileToolStripMenuItem.Name = "difficileToolStripMenuItem";
            this.difficileToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // timerGioco
            // 
            this.timerGioco.Enabled = true;
            this.timerGioco.Tick += new System.EventHandler(this.timerGioco_Tick);
            // 
            // terrenoGioco
            // 
            this.terrenoGioco.BackColor = System.Drawing.Color.Black;
            this.terrenoGioco.BackgroundImage = global::PongManciniWeglarz.Properties.Resources.background;
            this.terrenoGioco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.terrenoGioco.Controls.Add(this.ContainerFine);
            this.terrenoGioco.Controls.Add(this.pallina);
            this.terrenoGioco.Controls.Add(this.ContainerBenvenuto);
            this.terrenoGioco.Controls.Add(this.lblNumLivello);
            this.terrenoGioco.Controls.Add(this.lblPunteggioAvversario);
            this.terrenoGioco.Controls.Add(this.lblPunteggioGiocatore);
            this.terrenoGioco.Controls.Add(this.racchettaIA);
            this.terrenoGioco.Controls.Add(this.racchettaMia);
            this.terrenoGioco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.terrenoGioco.Location = new System.Drawing.Point(0, 24);
            this.terrenoGioco.Name = "terrenoGioco";
            this.terrenoGioco.Size = new System.Drawing.Size(1184, 637);
            this.terrenoGioco.TabIndex = 1;
            // 
            // ContainerFine
            // 
            this.ContainerFine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContainerFine.BackColor = System.Drawing.Color.Black;
            this.ContainerFine.Controls.Add(this.label5);
            this.ContainerFine.Controls.Add(this.label6);
            this.ContainerFine.Controls.Add(this.label7);
            this.ContainerFine.Location = new System.Drawing.Point(400, 224);
            this.ContainerFine.Name = "ContainerFine";
            this.ContainerFine.Size = new System.Drawing.Size(396, 175);
            this.ContainerFine.TabIndex = 10;
            this.ContainerFine.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(83, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 68);
            this.label5.TabIndex = 4;
            this.label5.Text = "F1 - Nuova partita\r\nESC - Esci";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(92, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 53);
            this.label6.TabIndex = 3;
            this.label6.Text = "Game over";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "label7";
            // 
            // pallina
            // 
            this.pallina.BackColor = System.Drawing.Color.Transparent;
            this.pallina.BackgroundImage = global::PongManciniWeglarz.Properties.Resources.pallina;
            this.pallina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pallina.InitialImage = null;
            this.pallina.Location = new System.Drawing.Point(319, 415);
            this.pallina.Name = "pallina";
            this.pallina.Size = new System.Drawing.Size(25, 25);
            this.pallina.TabIndex = 2;
            this.pallina.TabStop = false;
            this.pallina.VelocitàPallaX = 10;
            this.pallina.VelocitàPallaY = 10;
            // 
            // ContainerBenvenuto
            // 
            this.ContainerBenvenuto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContainerBenvenuto.Controls.Add(this.label3);
            this.ContainerBenvenuto.Controls.Add(this.label4);
            this.ContainerBenvenuto.Controls.Add(this.label1);
            this.ContainerBenvenuto.Location = new System.Drawing.Point(400, 224);
            this.ContainerBenvenuto.Name = "ContainerBenvenuto";
            this.ContainerBenvenuto.Size = new System.Drawing.Size(396, 175);
            this.ContainerBenvenuto.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(71, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 68);
            this.label3.TabIndex = 4;
            this.label3.Text = "Per iniziare la partita\r\npremi su \'Gioca\'";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(137, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 53);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pong";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lblNumLivello
            // 
            this.lblNumLivello.AutoSize = true;
            this.lblNumLivello.BackColor = System.Drawing.Color.Transparent;
            this.lblNumLivello.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumLivello.Location = new System.Drawing.Point(1015, 17);
            this.lblNumLivello.Name = "lblNumLivello";
            this.lblNumLivello.Size = new System.Drawing.Size(101, 25);
            this.lblNumLivello.TabIndex = 7;
            this.lblNumLivello.Text = "Livello 1";
            // 
            // lblPunteggioAvversario
            // 
            this.lblPunteggioAvversario.AutoSize = true;
            this.lblPunteggioAvversario.BackColor = System.Drawing.Color.Transparent;
            this.lblPunteggioAvversario.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunteggioAvversario.ForeColor = System.Drawing.Color.Black;
            this.lblPunteggioAvversario.Location = new System.Drawing.Point(619, 17);
            this.lblPunteggioAvversario.Name = "lblPunteggioAvversario";
            this.lblPunteggioAvversario.Size = new System.Drawing.Size(58, 63);
            this.lblPunteggioAvversario.TabIndex = 5;
            this.lblPunteggioAvversario.Text = "0";
            // 
            // lblPunteggioGiocatore
            // 
            this.lblPunteggioGiocatore.AutoSize = true;
            this.lblPunteggioGiocatore.BackColor = System.Drawing.Color.Transparent;
            this.lblPunteggioGiocatore.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunteggioGiocatore.ForeColor = System.Drawing.Color.Black;
            this.lblPunteggioGiocatore.Location = new System.Drawing.Point(526, 17);
            this.lblPunteggioGiocatore.Name = "lblPunteggioGiocatore";
            this.lblPunteggioGiocatore.Size = new System.Drawing.Size(58, 63);
            this.lblPunteggioGiocatore.TabIndex = 4;
            this.lblPunteggioGiocatore.Text = "0";
            // 
            // racchettaIA
            // 
            this.racchettaIA.Location = new System.Drawing.Point(1133, 387);
            this.racchettaIA.Name = "racchettaIA";
            this.racchettaIA.Size = new System.Drawing.Size(39, 145);
            this.racchettaIA.TabIndex = 1;
            this.racchettaIA.TabStop = false;
            // 
            // racchettaMia
            // 
            this.racchettaMia.Location = new System.Drawing.Point(12, 112);
            this.racchettaMia.Name = "racchettaMia";
            this.racchettaMia.Size = new System.Drawing.Size(36, 150);
            this.racchettaMia.TabIndex = 0;
            this.racchettaMia.TabStop = false;
            // 
            // GiocoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.terrenoGioco);
            this.Controls.Add(this.menuStripGioco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStripGioco;
            this.MaximizeBox = false;
            this.Name = "GiocoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong Mancini Weglarz";
            this.Load += new System.EventHandler(this.GiocoView_Load);
            this.menuStripGioco.ResumeLayout(false);
            this.menuStripGioco.PerformLayout();
            this.terrenoGioco.ResumeLayout(false);
            this.terrenoGioco.PerformLayout();
            this.ContainerFine.ResumeLayout(false);
            this.ContainerFine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pallina)).EndInit();
            this.ContainerBenvenuto.ResumeLayout(false);
            this.ContainerBenvenuto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racchettaIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racchettaMia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripGioco;
        private System.Windows.Forms.ToolStripMenuItem giocoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuNuovo;
        private System.Windows.Forms.ToolStripMenuItem menuPausa;
        private System.Windows.Forms.ToolStripMenuItem menuEsci;
        private System.Windows.Forms.ToolStripMenuItem difficoltàToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difficileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuTasti;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuPunteggio;
        private System.Windows.Forms.Timer timerGioco;
        private System.Windows.Forms.Panel terrenoGioco;
        private PallinaModel pallina;
        private RacchettaModel racchettaIA;
        private RacchettaModel racchettaMia;
        private System.Windows.Forms.Label lblPunteggioAvversario;
        private System.Windows.Forms.Label lblPunteggioGiocatore;
        private System.Windows.Forms.Label lblNumLivello;
        private System.Windows.Forms.Panel ContainerBenvenuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel ContainerFine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}