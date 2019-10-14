namespace PongManciniWeglarz.View
{
    partial class TastiView
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
            this.lblTasti = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTasti.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTasti
            // 
            this.lblTasti.Controls.Add(this.label5);
            this.lblTasti.Controls.Add(this.label2);
            this.lblTasti.Controls.Add(this.label1);
            this.lblTasti.Location = new System.Drawing.Point(51, 12);
            this.lblTasti.Name = "lblTasti";
            this.lblTasti.Size = new System.Drawing.Size(400, 488);
            this.lblTasti.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(20, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(369, 124);
            this.label5.TabIndex = 4;
            this.label5.Text = "Movimento racchetta\r\n\r\nSu: muovi il mouse verso l\'alto\r\nGiù: muovi il mouse verso" +
    " il basso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(20, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 217);
            this.label2.TabIndex = 1;
            this.label2.Text = "F1: Nuova partita\r\nP: Pausa\r\nEsc: Esci\r\n\r\nT: Tasti\r\nH: Help\r\nL: Classifica\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tasti";
            // 
            // TastiView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(491, 526);
            this.Controls.Add(this.lblTasti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TastiView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tasti";
            this.lblTasti.ResumeLayout(false);
            this.lblTasti.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lblTasti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}