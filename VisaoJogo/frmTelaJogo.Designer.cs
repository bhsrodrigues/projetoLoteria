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
            this.pnlQuina = new System.Windows.Forms.Panel();
            this.cboboxGamesQ = new System.Windows.Forms.ComboBox();
            this.cboboxTotalNumbersQ = new System.Windows.Forms.ComboBox();
            this.chkboxQuina = new System.Windows.Forms.CheckBox();
            this.lblOthers = new System.Windows.Forms.Label();
            this.pnlLotomania = new System.Windows.Forms.Panel();
            this.chkboxUseUnsortedNumber = new System.Windows.Forms.CheckBox();
            this.cboboxGamesLM = new System.Windows.Forms.ComboBox();
            this.cboboxTotalNumbersLM = new System.Windows.Forms.ComboBox();
            this.pnlTimemania = new System.Windows.Forms.Panel();
            this.cboboxGamesTM = new System.Windows.Forms.ComboBox();
            this.cboboxTotalNumbersTM = new System.Windows.Forms.ComboBox();
            this.chkboxTimemania = new System.Windows.Forms.CheckBox();
            this.pnlDiaSorte = new System.Windows.Forms.Panel();
            this.cboboxGamesDia = new System.Windows.Forms.ComboBox();
            this.cboboxTotalNumbersDia = new System.Windows.Forms.ComboBox();
            this.chkboxDiaDeSorte = new System.Windows.Forms.CheckBox();
            this.chkboxLotomania = new System.Windows.Forms.CheckBox();
            this.pnlLotofacil.SuspendLayout();
            this.pnlMegaSena.SuspendLayout();
            this.pnlDuplaSena.SuspendLayout();
            this.pnlQuina.SuspendLayout();
            this.pnlLotomania.SuspendLayout();
            this.pnlTimemania.SuspendLayout();
            this.pnlDiaSorte.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Location = new System.Drawing.Point(355, 342);
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
            this.pnlLotofacil.Location = new System.Drawing.Point(109, 127);
            this.pnlLotofacil.Name = "pnlLotofacil";
            this.pnlLotofacil.Size = new System.Drawing.Size(321, 36);
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
            this.cboboxGamesLF.Location = new System.Drawing.Point(116, 8);
            this.cboboxGamesLF.Name = "cboboxGamesLF";
            this.cboboxGamesLF.Size = new System.Drawing.Size(69, 21);
            this.cboboxGamesLF.TabIndex = 7;
            // 
            // cboboxTotalNumbersLF
            // 
            this.cboboxTotalNumbersLF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboboxTotalNumbersLF.Enabled = false;
            this.cboboxTotalNumbersLF.FormattingEnabled = true;
            this.cboboxTotalNumbersLF.Location = new System.Drawing.Point(13, 8);
            this.cboboxTotalNumbersLF.Name = "cboboxTotalNumbersLF";
            this.cboboxTotalNumbersLF.Size = new System.Drawing.Size(69, 21);
            this.cboboxTotalNumbersLF.TabIndex = 6;
            this.cboboxTotalNumbersLF.SelectedIndexChanged += new System.EventHandler(this.cboboxTotalNumbersLF_SelectedIndexChanged);
            // 
            // chkLotofacil
            // 
            this.chkLotofacil.AutoSize = true;
            this.chkLotofacil.Location = new System.Drawing.Point(25, 137);
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
            this.lblTotalDraws.Location = new System.Drawing.Point(221, 14);
            this.lblTotalDraws.Name = "lblTotalDraws";
            this.lblTotalDraws.Size = new System.Drawing.Size(60, 13);
            this.lblTotalDraws.TabIndex = 5;
            this.lblTotalDraws.Text = "Nº Apostas";
            // 
            // pnlMegaSena
            // 
            this.pnlMegaSena.Controls.Add(this.cboboxGamesMS);
            this.pnlMegaSena.Controls.Add(this.cboboxTotalNumbersMS);
            this.pnlMegaSena.Location = new System.Drawing.Point(109, 212);
            this.pnlMegaSena.Name = "pnlMegaSena";
            this.pnlMegaSena.Size = new System.Drawing.Size(321, 36);
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
            this.cboboxGamesMS.Location = new System.Drawing.Point(116, 8);
            this.cboboxGamesMS.Name = "cboboxGamesMS";
            this.cboboxGamesMS.Size = new System.Drawing.Size(69, 21);
            this.cboboxGamesMS.TabIndex = 7;
            // 
            // cboboxTotalNumbersMS
            // 
            this.cboboxTotalNumbersMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboboxTotalNumbersMS.Enabled = false;
            this.cboboxTotalNumbersMS.FormattingEnabled = true;
            this.cboboxTotalNumbersMS.Location = new System.Drawing.Point(13, 8);
            this.cboboxTotalNumbersMS.Name = "cboboxTotalNumbersMS";
            this.cboboxTotalNumbersMS.Size = new System.Drawing.Size(69, 21);
            this.cboboxTotalNumbersMS.TabIndex = 6;
            // 
            // chkboxMegaSena
            // 
            this.chkboxMegaSena.AutoSize = true;
            this.chkboxMegaSena.Location = new System.Drawing.Point(25, 222);
            this.chkboxMegaSena.Name = "chkboxMegaSena";
            this.chkboxMegaSena.Size = new System.Drawing.Size(81, 17);
            this.chkboxMegaSena.TabIndex = 3;
            this.chkboxMegaSena.Text = "Mega-Sena";
            this.chkboxMegaSena.UseVisualStyleBackColor = true;
            this.chkboxMegaSena.CheckedChanged += new System.EventHandler(this.chkboxMegaSena_CheckedChanged);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 342);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(301, 20);
            this.txtPath.TabIndex = 7;
            this.txtPath.Click += new System.EventHandler(this.btnChoosePath_Click);
            // 
            // btnChoosePath
            // 
            this.btnChoosePath.Location = new System.Drawing.Point(311, 341);
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
            this.pnlDuplaSena.Location = new System.Drawing.Point(109, 85);
            this.pnlDuplaSena.Name = "pnlDuplaSena";
            this.pnlDuplaSena.Size = new System.Drawing.Size(321, 36);
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
            this.cboboxGamesDS.Location = new System.Drawing.Point(115, 8);
            this.cboboxGamesDS.Name = "cboboxGamesDS";
            this.cboboxGamesDS.Size = new System.Drawing.Size(69, 21);
            this.cboboxGamesDS.TabIndex = 7;
            // 
            // cboboxTotalNumbersDS
            // 
            this.cboboxTotalNumbersDS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboboxTotalNumbersDS.Enabled = false;
            this.cboboxTotalNumbersDS.FormattingEnabled = true;
            this.cboboxTotalNumbersDS.Location = new System.Drawing.Point(14, 8);
            this.cboboxTotalNumbersDS.Name = "cboboxTotalNumbersDS";
            this.cboboxTotalNumbersDS.Size = new System.Drawing.Size(69, 21);
            this.cboboxTotalNumbersDS.TabIndex = 6;
            // 
            // chkboxDuplaSena
            // 
            this.chkboxDuplaSena.AutoSize = true;
            this.chkboxDuplaSena.Location = new System.Drawing.Point(25, 95);
            this.chkboxDuplaSena.Name = "chkboxDuplaSena";
            this.chkboxDuplaSena.Size = new System.Drawing.Size(82, 17);
            this.chkboxDuplaSena.TabIndex = 3;
            this.chkboxDuplaSena.Text = "Dupla-Sena";
            this.chkboxDuplaSena.UseVisualStyleBackColor = true;
            this.chkboxDuplaSena.CheckedChanged += new System.EventHandler(this.chkboxDuplaSena_CheckedChanged);
            // 
            // pnlQuina
            // 
            this.pnlQuina.Controls.Add(this.cboboxGamesQ);
            this.pnlQuina.Controls.Add(this.cboboxTotalNumbersQ);
            this.pnlQuina.Location = new System.Drawing.Point(109, 254);
            this.pnlQuina.Name = "pnlQuina";
            this.pnlQuina.Size = new System.Drawing.Size(321, 36);
            this.pnlQuina.TabIndex = 10;
            // 
            // cboboxGamesQ
            // 
            this.cboboxGamesQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboboxGamesQ.Enabled = false;
            this.cboboxGamesQ.FormattingEnabled = true;
            this.cboboxGamesQ.Items.AddRange(new object[] {
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
            this.cboboxGamesQ.Location = new System.Drawing.Point(116, 8);
            this.cboboxGamesQ.Name = "cboboxGamesQ";
            this.cboboxGamesQ.Size = new System.Drawing.Size(69, 21);
            this.cboboxGamesQ.TabIndex = 7;
            // 
            // cboboxTotalNumbersQ
            // 
            this.cboboxTotalNumbersQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboboxTotalNumbersQ.Enabled = false;
            this.cboboxTotalNumbersQ.FormattingEnabled = true;
            this.cboboxTotalNumbersQ.Location = new System.Drawing.Point(14, 8);
            this.cboboxTotalNumbersQ.Name = "cboboxTotalNumbersQ";
            this.cboboxTotalNumbersQ.Size = new System.Drawing.Size(69, 21);
            this.cboboxTotalNumbersQ.TabIndex = 6;
            // 
            // chkboxQuina
            // 
            this.chkboxQuina.AutoSize = true;
            this.chkboxQuina.Location = new System.Drawing.Point(25, 264);
            this.chkboxQuina.Name = "chkboxQuina";
            this.chkboxQuina.Size = new System.Drawing.Size(54, 17);
            this.chkboxQuina.TabIndex = 3;
            this.chkboxQuina.Text = "Quina";
            this.chkboxQuina.UseVisualStyleBackColor = true;
            this.chkboxQuina.CheckedChanged += new System.EventHandler(this.chkboxQuina_CheckedChanged);
            // 
            // lblOthers
            // 
            this.lblOthers.AutoSize = true;
            this.lblOthers.Location = new System.Drawing.Point(324, 14);
            this.lblOthers.Name = "lblOthers";
            this.lblOthers.Size = new System.Drawing.Size(38, 13);
            this.lblOthers.TabIndex = 11;
            this.lblOthers.Text = "Outros";
            // 
            // pnlLotomania
            // 
            this.pnlLotomania.Controls.Add(this.chkboxUseUnsortedNumber);
            this.pnlLotomania.Controls.Add(this.cboboxGamesLM);
            this.pnlLotomania.Controls.Add(this.cboboxTotalNumbersLM);
            this.pnlLotomania.Location = new System.Drawing.Point(109, 169);
            this.pnlLotomania.Name = "pnlLotomania";
            this.pnlLotomania.Size = new System.Drawing.Size(321, 36);
            this.pnlLotomania.TabIndex = 12;
            // 
            // chkboxUseUnsortedNumber
            // 
            this.chkboxUseUnsortedNumber.AutoSize = true;
            this.chkboxUseUnsortedNumber.Enabled = false;
            this.chkboxUseUnsortedNumber.Location = new System.Drawing.Point(208, 11);
            this.chkboxUseUnsortedNumber.Name = "chkboxUseUnsortedNumber";
            this.chkboxUseUnsortedNumber.Size = new System.Drawing.Size(100, 17);
            this.chkboxUseUnsortedNumber.TabIndex = 8;
            this.chkboxUseUnsortedNumber.Text = "Aposta Espelho";
            this.chkboxUseUnsortedNumber.UseVisualStyleBackColor = true;
            // 
            // cboboxGamesLM
            // 
            this.cboboxGamesLM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboboxGamesLM.Enabled = false;
            this.cboboxGamesLM.FormattingEnabled = true;
            this.cboboxGamesLM.Items.AddRange(new object[] {
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
            this.cboboxGamesLM.Location = new System.Drawing.Point(116, 11);
            this.cboboxGamesLM.Name = "cboboxGamesLM";
            this.cboboxGamesLM.Size = new System.Drawing.Size(69, 21);
            this.cboboxGamesLM.TabIndex = 7;
            // 
            // cboboxTotalNumbersLM
            // 
            this.cboboxTotalNumbersLM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboboxTotalNumbersLM.Enabled = false;
            this.cboboxTotalNumbersLM.FormattingEnabled = true;
            this.cboboxTotalNumbersLM.Location = new System.Drawing.Point(13, 10);
            this.cboboxTotalNumbersLM.Name = "cboboxTotalNumbersLM";
            this.cboboxTotalNumbersLM.Size = new System.Drawing.Size(69, 21);
            this.cboboxTotalNumbersLM.TabIndex = 6;
            // 
            // pnlTimemania
            // 
            this.pnlTimemania.Controls.Add(this.cboboxGamesTM);
            this.pnlTimemania.Controls.Add(this.cboboxTotalNumbersTM);
            this.pnlTimemania.Location = new System.Drawing.Point(109, 296);
            this.pnlTimemania.Name = "pnlTimemania";
            this.pnlTimemania.Size = new System.Drawing.Size(321, 36);
            this.pnlTimemania.TabIndex = 13;
            // 
            // cboboxGamesTM
            // 
            this.cboboxGamesTM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboboxGamesTM.Enabled = false;
            this.cboboxGamesTM.FormattingEnabled = true;
            this.cboboxGamesTM.Items.AddRange(new object[] {
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
            this.cboboxGamesTM.Location = new System.Drawing.Point(116, 6);
            this.cboboxGamesTM.Name = "cboboxGamesTM";
            this.cboboxGamesTM.Size = new System.Drawing.Size(69, 21);
            this.cboboxGamesTM.TabIndex = 7;
            // 
            // cboboxTotalNumbersTM
            // 
            this.cboboxTotalNumbersTM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboboxTotalNumbersTM.Enabled = false;
            this.cboboxTotalNumbersTM.FormattingEnabled = true;
            this.cboboxTotalNumbersTM.Location = new System.Drawing.Point(14, 8);
            this.cboboxTotalNumbersTM.Name = "cboboxTotalNumbersTM";
            this.cboboxTotalNumbersTM.Size = new System.Drawing.Size(69, 21);
            this.cboboxTotalNumbersTM.TabIndex = 6;
            // 
            // chkboxTimemania
            // 
            this.chkboxTimemania.AutoSize = true;
            this.chkboxTimemania.Location = new System.Drawing.Point(25, 306);
            this.chkboxTimemania.Name = "chkboxTimemania";
            this.chkboxTimemania.Size = new System.Drawing.Size(77, 17);
            this.chkboxTimemania.TabIndex = 3;
            this.chkboxTimemania.Text = "Timemania";
            this.chkboxTimemania.UseVisualStyleBackColor = true;
            this.chkboxTimemania.CheckedChanged += new System.EventHandler(this.chkboxTimemania_CheckedChanged);
            // 
            // pnlDiaSorte
            // 
            this.pnlDiaSorte.Controls.Add(this.cboboxGamesDia);
            this.pnlDiaSorte.Controls.Add(this.cboboxTotalNumbersDia);
            this.pnlDiaSorte.Location = new System.Drawing.Point(109, 43);
            this.pnlDiaSorte.Name = "pnlDiaSorte";
            this.pnlDiaSorte.Size = new System.Drawing.Size(321, 36);
            this.pnlDiaSorte.TabIndex = 14;
            // 
            // cboboxGamesDia
            // 
            this.cboboxGamesDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboboxGamesDia.Enabled = false;
            this.cboboxGamesDia.FormattingEnabled = true;
            this.cboboxGamesDia.Items.AddRange(new object[] {
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
            this.cboboxGamesDia.Location = new System.Drawing.Point(116, 8);
            this.cboboxGamesDia.Name = "cboboxGamesDia";
            this.cboboxGamesDia.Size = new System.Drawing.Size(69, 21);
            this.cboboxGamesDia.TabIndex = 7;
            // 
            // cboboxTotalNumbersDia
            // 
            this.cboboxTotalNumbersDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboboxTotalNumbersDia.Enabled = false;
            this.cboboxTotalNumbersDia.FormattingEnabled = true;
            this.cboboxTotalNumbersDia.Location = new System.Drawing.Point(13, 8);
            this.cboboxTotalNumbersDia.Name = "cboboxTotalNumbersDia";
            this.cboboxTotalNumbersDia.Size = new System.Drawing.Size(69, 21);
            this.cboboxTotalNumbersDia.TabIndex = 6;
            // 
            // chkboxDiaDeSorte
            // 
            this.chkboxDiaDeSorte.AutoSize = true;
            this.chkboxDiaDeSorte.Location = new System.Drawing.Point(25, 53);
            this.chkboxDiaDeSorte.Name = "chkboxDiaDeSorte";
            this.chkboxDiaDeSorte.Size = new System.Drawing.Size(85, 17);
            this.chkboxDiaDeSorte.TabIndex = 3;
            this.chkboxDiaDeSorte.Text = "Dia de Sorte";
            this.chkboxDiaDeSorte.UseVisualStyleBackColor = true;
            this.chkboxDiaDeSorte.CheckedChanged += new System.EventHandler(this.chkboxDiaDeSorte_CheckedChanged);
            // 
            // chkboxLotomania
            // 
            this.chkboxLotomania.AutoSize = true;
            this.chkboxLotomania.Location = new System.Drawing.Point(25, 180);
            this.chkboxLotomania.Name = "chkboxLotomania";
            this.chkboxLotomania.Size = new System.Drawing.Size(75, 17);
            this.chkboxLotomania.TabIndex = 16;
            this.chkboxLotomania.Text = "Lotomania";
            this.chkboxLotomania.UseVisualStyleBackColor = true;
            this.chkboxLotomania.CheckedChanged += new System.EventHandler(this.chkboxLotomania_CheckedChanged);
            // 
            // frmTelaJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 374);
            this.Controls.Add(this.chkboxLotomania);
            this.Controls.Add(this.pnlDiaSorte);
            this.Controls.Add(this.chkboxDiaDeSorte);
            this.Controls.Add(this.chkboxDuplaSena);
            this.Controls.Add(this.chkLotofacil);
            this.Controls.Add(this.chkboxMegaSena);
            this.Controls.Add(this.chkboxQuina);
            this.Controls.Add(this.chkboxTimemania);
            this.Controls.Add(this.pnlTimemania);
            this.Controls.Add(this.pnlLotomania);
            this.Controls.Add(this.lblOthers);
            this.Controls.Add(this.pnlQuina);
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
            this.pnlMegaSena.ResumeLayout(false);
            this.pnlDuplaSena.ResumeLayout(false);
            this.pnlQuina.ResumeLayout(false);
            this.pnlLotomania.ResumeLayout(false);
            this.pnlLotomania.PerformLayout();
            this.pnlTimemania.ResumeLayout(false);
            this.pnlDiaSorte.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlQuina;
        private System.Windows.Forms.ComboBox cboboxGamesQ;
        private System.Windows.Forms.ComboBox cboboxTotalNumbersQ;
        private System.Windows.Forms.CheckBox chkboxQuina;
        private System.Windows.Forms.Label lblOthers;
        private System.Windows.Forms.Panel pnlLotomania;
        private System.Windows.Forms.CheckBox chkboxUseUnsortedNumber;
        private System.Windows.Forms.ComboBox cboboxGamesLM;
        private System.Windows.Forms.ComboBox cboboxTotalNumbersLM;
        private System.Windows.Forms.Panel pnlTimemania;
        private System.Windows.Forms.ComboBox cboboxGamesTM;
        private System.Windows.Forms.ComboBox cboboxTotalNumbersTM;
        private System.Windows.Forms.CheckBox chkboxTimemania;
        private System.Windows.Forms.Panel pnlDiaSorte;
        private System.Windows.Forms.ComboBox cboboxGamesDia;
        private System.Windows.Forms.ComboBox cboboxTotalNumbersDia;
        private System.Windows.Forms.CheckBox chkboxDiaDeSorte;
        private System.Windows.Forms.CheckBox chkboxLotomania;
    }
}

