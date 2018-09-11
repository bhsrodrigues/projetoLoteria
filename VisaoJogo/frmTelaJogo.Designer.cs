namespace VisaoJogo
{
    partial class frmTelaJogo
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblGameName = new System.Windows.Forms.Label();
            this.pnlLotofacil = new System.Windows.Forms.Panel();
            this.txtGames = new System.Windows.Forms.TextBox();
            this.txtTotalNumbers = new System.Windows.Forms.TextBox();
            this.chkLotofacil = new System.Windows.Forms.CheckBox();
            this.lblDonzens = new System.Windows.Forms.Label();
            this.lblTotalDraws = new System.Windows.Forms.Label();
            this.pnlLotofacil.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Location = new System.Drawing.Point(123, 256);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Jogar";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Location = new System.Drawing.Point(28, 14);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(30, 13);
            this.lblGameName.TabIndex = 2;
            this.lblGameName.Text = "Jogo";
            // 
            // pnlLotofacil
            // 
            this.pnlLotofacil.Controls.Add(this.txtGames);
            this.pnlLotofacil.Controls.Add(this.txtTotalNumbers);
            this.pnlLotofacil.Controls.Add(this.chkLotofacil);
            this.pnlLotofacil.Location = new System.Drawing.Point(12, 33);
            this.pnlLotofacil.Name = "pnlLotofacil";
            this.pnlLotofacil.Size = new System.Drawing.Size(308, 36);
            this.pnlLotofacil.TabIndex = 3;
            // 
            // txtGames
            // 
            this.txtGames.Enabled = false;
            this.txtGames.Location = new System.Drawing.Point(230, 7);
            this.txtGames.Name = "txtGames";
            this.txtGames.Size = new System.Drawing.Size(60, 20);
            this.txtGames.TabIndex = 5;
            // 
            // txtTotalNumbers
            // 
            this.txtTotalNumbers.Enabled = false;
            this.txtTotalNumbers.Location = new System.Drawing.Point(111, 7);
            this.txtTotalNumbers.Name = "txtTotalNumbers";
            this.txtTotalNumbers.Size = new System.Drawing.Size(56, 20);
            this.txtTotalNumbers.TabIndex = 4;
            // 
            // chkLotofacil
            // 
            this.chkLotofacil.AutoSize = true;
            this.chkLotofacil.Location = new System.Drawing.Point(13, 10);
            this.chkLotofacil.Name = "chkLotofacil";
            this.chkLotofacil.Size = new System.Drawing.Size(66, 17);
            this.chkLotofacil.TabIndex = 3;
            this.chkLotofacil.Text = "Lotofácil";
            this.chkLotofacil.UseVisualStyleBackColor = true;
            this.chkLotofacil.CheckedChanged += new System.EventHandler(this.chkLotofacil_CheckedChanged);
            // 
            // lblDonzens
            // 
            this.lblDonzens.AutoSize = true;
            this.lblDonzens.Location = new System.Drawing.Point(120, 14);
            this.lblDonzens.Name = "lblDonzens";
            this.lblDonzens.Size = new System.Drawing.Size(64, 13);
            this.lblDonzens.TabIndex = 4;
            this.lblDonzens.Text = "Nº Dezenas";
            // 
            // lblTotalDraws
            // 
            this.lblTotalDraws.AutoSize = true;
            this.lblTotalDraws.Location = new System.Drawing.Point(239, 14);
            this.lblTotalDraws.Name = "lblTotalDraws";
            this.lblTotalDraws.Size = new System.Drawing.Size(60, 13);
            this.lblTotalDraws.TabIndex = 5;
            this.lblTotalDraws.Text = "Nº Apostas";
            // 
            // frmTelaJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 304);
            this.Controls.Add(this.lblTotalDraws);
            this.Controls.Add(this.lblDonzens);
            this.Controls.Add(this.pnlLotofacil);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.btnPlay);
            this.Name = "frmTelaJogo";
            this.Text = "Gerador de Apostas Lotéricas";
            this.pnlLotofacil.ResumeLayout(false);
            this.pnlLotofacil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Panel pnlLotofacil;
        private System.Windows.Forms.TextBox txtGames;
        private System.Windows.Forms.TextBox txtTotalNumbers;
        private System.Windows.Forms.CheckBox chkLotofacil;
        private System.Windows.Forms.Label lblDonzens;
        private System.Windows.Forms.Label lblTotalDraws;
    }
}

