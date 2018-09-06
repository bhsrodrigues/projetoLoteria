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
            this.gboboxLotoFacil = new System.Windows.Forms.GroupBox();
            this.txtGames = new System.Windows.Forms.TextBox();
            this.txtTotalNumbers = new System.Windows.Forms.TextBox();
            this.chkLotofacil = new System.Windows.Forms.CheckBox();
            this.gboboxLotoFacil.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(175, 256);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Jogar";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // gboboxLotoFacil
            // 
            this.gboboxLotoFacil.Controls.Add(this.txtGames);
            this.gboboxLotoFacil.Controls.Add(this.txtTotalNumbers);
            this.gboboxLotoFacil.Controls.Add(this.chkLotofacil);
            this.gboboxLotoFacil.Location = new System.Drawing.Point(11, 20);
            this.gboboxLotoFacil.Name = "gboboxLotoFacil";
            this.gboboxLotoFacil.Size = new System.Drawing.Size(319, 65);
            this.gboboxLotoFacil.TabIndex = 1;
            this.gboboxLotoFacil.TabStop = false;
            // 
            // txtGames
            // 
            this.txtGames.Enabled = false;
            this.txtGames.Location = new System.Drawing.Point(229, 25);
            this.txtGames.Name = "txtGames";
            this.txtGames.Size = new System.Drawing.Size(54, 20);
            this.txtGames.TabIndex = 2;
            // 
            // txtTotalNumbers
            // 
            this.txtTotalNumbers.Enabled = false;
            this.txtTotalNumbers.Location = new System.Drawing.Point(117, 25);
            this.txtTotalNumbers.Name = "txtTotalNumbers";
            this.txtTotalNumbers.Size = new System.Drawing.Size(56, 20);
            this.txtTotalNumbers.TabIndex = 1;
            // 
            // chkLotofacil
            // 
            this.chkLotofacil.AutoSize = true;
            this.chkLotofacil.Location = new System.Drawing.Point(17, 28);
            this.chkLotofacil.Name = "chkLotofacil";
            this.chkLotofacil.Size = new System.Drawing.Size(66, 17);
            this.chkLotofacil.TabIndex = 0;
            this.chkLotofacil.Text = "Lotofácil";
            this.chkLotofacil.UseVisualStyleBackColor = true;
            this.chkLotofacil.CheckedChanged += new System.EventHandler(this.chkLotofacil_CheckedChanged);
            // 
            // frmTelaJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 304);
            this.Controls.Add(this.gboboxLotoFacil);
            this.Controls.Add(this.btnPlay);
            this.Name = "frmTelaJogo";
            this.Text = "Form1";
            this.gboboxLotoFacil.ResumeLayout(false);
            this.gboboxLotoFacil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.GroupBox gboboxLotoFacil;
        private System.Windows.Forms.CheckBox chkLotofacil;
        private System.Windows.Forms.TextBox txtGames;
        private System.Windows.Forms.TextBox txtTotalNumbers;
    }
}

