﻿namespace VisaoJogo
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
            this.cboboxGamesLF = new System.Windows.Forms.ComboBox();
            this.cboboxTotalNumbersLF = new System.Windows.Forms.ComboBox();
            this.chkLotofacil = new System.Windows.Forms.CheckBox();
            this.lblDonzens = new System.Windows.Forms.Label();
            this.lblTotalDraws = new System.Windows.Forms.Label();
            this.pnlMegaSena = new System.Windows.Forms.Panel();
            this.cboboxGamesMS = new System.Windows.Forms.ComboBox();
            this.cboboxTotalNumbersMS = new System.Windows.Forms.ComboBox();
            this.chkboxMegaSena = new System.Windows.Forms.CheckBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.getFolderToSave = new System.Windows.Forms.FolderBrowserDialog();
            this.btnChoosePath = new System.Windows.Forms.Button();
            this.pnlDuplaSena = new System.Windows.Forms.Panel();
            this.cboboxGamesDS = new System.Windows.Forms.ComboBox();
            this.cboboxTotalNumbersDS = new System.Windows.Forms.ComboBox();
            this.chkboxDuplaSena = new System.Windows.Forms.CheckBox();
            this.pnlLotofacil.SuspendLayout();
            this.pnlMegaSena.SuspendLayout();
            this.pnlDuplaSena.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Location = new System.Drawing.Point(123, 269);
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
            this.pnlLotofacil.Controls.Add(this.cboboxGamesLF);
            this.pnlLotofacil.Controls.Add(this.cboboxTotalNumbersLF);
            this.pnlLotofacil.Controls.Add(this.chkLotofacil);
            this.pnlLotofacil.Location = new System.Drawing.Point(12, 80);
            this.pnlLotofacil.Name = "pnlLotofacil";
            this.pnlLotofacil.Size = new System.Drawing.Size(311, 36);
            this.pnlLotofacil.TabIndex = 3;
            // 
            // cboboxGamesLF
            // 
            this.cboboxGamesLF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboboxGamesLF.Enabled = false;
            this.cboboxGamesLF.FormattingEnabled = true;
            this.cboboxGamesLF.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cboboxGamesLF.Location = new System.Drawing.Point(230, 6);
            this.cboboxGamesLF.Name = "cboboxGamesLF";
            this.cboboxGamesLF.Size = new System.Drawing.Size(69, 21);
            this.cboboxGamesLF.TabIndex = 7;
            // 
            // cboboxTotalNumbersLF
            // 
            this.cboboxTotalNumbersLF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboboxTotalNumbersLF.Enabled = false;
            this.cboboxTotalNumbersLF.FormattingEnabled = true;
            this.cboboxTotalNumbersLF.Items.AddRange(new object[] {
            "15",
            "16",
            "17",
            "18"});
            this.cboboxTotalNumbersLF.Location = new System.Drawing.Point(103, 6);
            this.cboboxTotalNumbersLF.Name = "cboboxTotalNumbersLF";
            this.cboboxTotalNumbersLF.Size = new System.Drawing.Size(69, 21);
            this.cboboxTotalNumbersLF.TabIndex = 6;
            this.cboboxTotalNumbersLF.SelectedIndexChanged += new System.EventHandler(this.cboboxTotalNumbersLF_SelectedIndexChanged);
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
            // pnlMegaSena
            // 
            this.pnlMegaSena.Controls.Add(this.cboboxGamesMS);
            this.pnlMegaSena.Controls.Add(this.cboboxTotalNumbersMS);
            this.pnlMegaSena.Controls.Add(this.chkboxMegaSena);
            this.pnlMegaSena.Location = new System.Drawing.Point(12, 122);
            this.pnlMegaSena.Name = "pnlMegaSena";
            this.pnlMegaSena.Size = new System.Drawing.Size(311, 36);
            this.pnlMegaSena.TabIndex = 6;
            // 
            // cboboxGamesMS
            // 
            this.cboboxGamesMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboboxGamesMS.Enabled = false;
            this.cboboxGamesMS.FormattingEnabled = true;
            this.cboboxGamesMS.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cboboxGamesMS.Location = new System.Drawing.Point(230, 6);
            this.cboboxGamesMS.Name = "cboboxGamesMS";
            this.cboboxGamesMS.Size = new System.Drawing.Size(69, 21);
            this.cboboxGamesMS.TabIndex = 7;
            // 
            // cboboxTotalNumbersMS
            // 
            this.cboboxTotalNumbersMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboboxTotalNumbersMS.Enabled = false;
            this.cboboxTotalNumbersMS.FormattingEnabled = true;
            this.cboboxTotalNumbersMS.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cboboxTotalNumbersMS.Location = new System.Drawing.Point(103, 6);
            this.cboboxTotalNumbersMS.Name = "cboboxTotalNumbersMS";
            this.cboboxTotalNumbersMS.Size = new System.Drawing.Size(69, 21);
            this.cboboxTotalNumbersMS.TabIndex = 6;
            // 
            // chkboxMegaSena
            // 
            this.chkboxMegaSena.AutoSize = true;
            this.chkboxMegaSena.Location = new System.Drawing.Point(13, 10);
            this.chkboxMegaSena.Name = "chkboxMegaSena";
            this.chkboxMegaSena.Size = new System.Drawing.Size(81, 17);
            this.chkboxMegaSena.TabIndex = 3;
            this.chkboxMegaSena.Text = "Mega-Sena";
            this.chkboxMegaSena.UseVisualStyleBackColor = true;
            this.chkboxMegaSena.CheckedChanged += new System.EventHandler(this.chkboxMegaSena_CheckedChanged);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 232);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(277, 20);
            this.txtPath.TabIndex = 7;
            this.txtPath.Click += new System.EventHandler(this.btnChoosePath_Click);
            // 
            // btnChoosePath
            // 
            this.btnChoosePath.Location = new System.Drawing.Point(289, 231);
            this.btnChoosePath.Name = "btnChoosePath";
            this.btnChoosePath.Size = new System.Drawing.Size(32, 23);
            this.btnChoosePath.TabIndex = 8;
            this.btnChoosePath.Text = "...";
            this.btnChoosePath.UseVisualStyleBackColor = true;
            this.btnChoosePath.Click += new System.EventHandler(this.btnChoosePath_Click);
            // 
            // pnlDuplaSena
            // 
            this.pnlDuplaSena.Controls.Add(this.cboboxGamesDS);
            this.pnlDuplaSena.Controls.Add(this.cboboxTotalNumbersDS);
            this.pnlDuplaSena.Controls.Add(this.chkboxDuplaSena);
            this.pnlDuplaSena.Location = new System.Drawing.Point(12, 38);
            this.pnlDuplaSena.Name = "pnlDuplaSena";
            this.pnlDuplaSena.Size = new System.Drawing.Size(311, 36);
            this.pnlDuplaSena.TabIndex = 9;
            // 
            // cboboxGamesDS
            // 
            this.cboboxGamesDS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboboxGamesDS.Enabled = false;
            this.cboboxGamesDS.FormattingEnabled = true;
            this.cboboxGamesDS.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cboboxGamesDS.Location = new System.Drawing.Point(230, 6);
            this.cboboxGamesDS.Name = "cboboxGamesDS";
            this.cboboxGamesDS.Size = new System.Drawing.Size(69, 21);
            this.cboboxGamesDS.TabIndex = 7;
            // 
            // cboboxTotalNumbersDS
            // 
            this.cboboxTotalNumbersDS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboboxTotalNumbersDS.Enabled = false;
            this.cboboxTotalNumbersDS.FormattingEnabled = true;
            this.cboboxTotalNumbersDS.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cboboxTotalNumbersDS.Location = new System.Drawing.Point(103, 6);
            this.cboboxTotalNumbersDS.Name = "cboboxTotalNumbersDS";
            this.cboboxTotalNumbersDS.Size = new System.Drawing.Size(69, 21);
            this.cboboxTotalNumbersDS.TabIndex = 6;
            // 
            // chkboxDuplaSena
            // 
            this.chkboxDuplaSena.AutoSize = true;
            this.chkboxDuplaSena.Location = new System.Drawing.Point(13, 10);
            this.chkboxDuplaSena.Name = "chkboxDuplaSena";
            this.chkboxDuplaSena.Size = new System.Drawing.Size(81, 17);
            this.chkboxDuplaSena.TabIndex = 3;
            this.chkboxDuplaSena.Text = "Mega-Sena";
            this.chkboxDuplaSena.UseVisualStyleBackColor = true;
            // 
            // frmTelaJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 304);
            this.Controls.Add(this.pnlDuplaSena);
            this.Controls.Add(this.btnChoosePath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.pnlMegaSena);
            this.Controls.Add(this.lblTotalDraws);
            this.Controls.Add(this.lblDonzens);
            this.Controls.Add(this.pnlLotofacil);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.btnPlay);
            this.Name = "frmTelaJogo";
            this.Text = "Gerador de Apostas Lotéricas";
            this.pnlLotofacil.ResumeLayout(false);
            this.pnlLotofacil.PerformLayout();
            this.pnlMegaSena.ResumeLayout(false);
            this.pnlMegaSena.PerformLayout();
            this.pnlDuplaSena.ResumeLayout(false);
            this.pnlDuplaSena.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Panel pnlLotofacil;
        private System.Windows.Forms.CheckBox chkLotofacil;
        private System.Windows.Forms.Label lblDonzens;
        private System.Windows.Forms.Label lblTotalDraws;
        private System.Windows.Forms.ComboBox cboboxTotalNumbersLF;
        private System.Windows.Forms.ComboBox cboboxGamesLF;
        private System.Windows.Forms.Panel pnlMegaSena;
        private System.Windows.Forms.ComboBox cboboxGamesMS;
        private System.Windows.Forms.ComboBox cboboxTotalNumbersMS;
        private System.Windows.Forms.CheckBox chkboxMegaSena;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.FolderBrowserDialog getFolderToSave;
        private System.Windows.Forms.Button btnChoosePath;
        private System.Windows.Forms.Panel pnlDuplaSena;
        private System.Windows.Forms.ComboBox cboboxGamesDS;
        private System.Windows.Forms.ComboBox cboboxTotalNumbersDS;
        private System.Windows.Forms.CheckBox chkboxDuplaSena;
    }
}

