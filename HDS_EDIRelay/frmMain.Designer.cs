namespace HDS_EDIRelay
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tmrFetch = new System.Windows.Forms.Timer(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.chkAutoStart = new System.Windows.Forms.CheckBox();
            this.tctrlMain = new System.Windows.Forms.TabControl();
            this.tpgA_ToFTP = new System.Windows.Forms.TabPage();
            this.chkA_Enabled = new System.Windows.Forms.CheckBox();
            this.gbxA = new System.Windows.Forms.GroupBox();
            this.txtA_Dest_PO_DepotNames = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.rdoA_Dest_PO_DepotName = new System.Windows.Forms.RadioButton();
            this.rdoA_Dest_PO_All = new System.Windows.Forms.RadioButton();
            this.txtA_Dest_POPath = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chkA_Dest_FetchPO = new System.Windows.Forms.CheckBox();
            this.txtA_Dest_FileExt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtA_Dest_Host = new System.Windows.Forms.TextBox();
            this.txtA_Dest_EDIPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA_Dest_Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtA_Dest_Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tpgB_ToNetPath = new System.Windows.Forms.TabPage();
            this.chkB_Enabled = new System.Windows.Forms.CheckBox();
            this.gbxB = new System.Windows.Forms.GroupBox();
            this.txtB_Dest_ServerName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtB_Dest_PO_DepotNames = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.rdoB_Dest_PO_DepotName = new System.Windows.Forms.RadioButton();
            this.rdoB_Dest_PO_All = new System.Windows.Forms.RadioButton();
            this.txtB_Dest_POPath = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.chkB_Dest_FetchPO = new System.Windows.Forms.CheckBox();
            this.txtB_Dest_FileExt = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtB_Dest_Host = new System.Windows.Forms.TextBox();
            this.txtB_Dest_EDIPath = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtB_Dest_Username = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtB_Dest_Password = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tpgC_ToLocalPath = new System.Windows.Forms.TabPage();
            this.chkC_Enabled = new System.Windows.Forms.CheckBox();
            this.gbxC = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtC_Dest_PO_DepotNames = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.rdoC_Dest_PO_DepotName = new System.Windows.Forms.RadioButton();
            this.rdoC_Dest_PO_All = new System.Windows.Forms.RadioButton();
            this.txtC_Dest_POPath = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.chkC_Dest_FetchPO = new System.Windows.Forms.CheckBox();
            this.txtC_Dest_FileExt = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.txtC_Dest_EDIPath = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.gbxDepot = new System.Windows.Forms.GroupBox();
            this.txtA_Depot_FileExt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtA_Depot_POPath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtA_Depot_Host = new System.Windows.Forms.TextBox();
            this.txtA_Depot_EDIPath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtA_Depot_Username = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtA_Depot_Password = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.nudTimer = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.lblTimeRemaining = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblLastXmit = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.tctrlMain.SuspendLayout();
            this.tpgA_ToFTP.SuspendLayout();
            this.gbxA.SuspendLayout();
            this.tpgB_ToNetPath.SuspendLayout();
            this.gbxB.SuspendLayout();
            this.tpgC_ToLocalPath.SuspendLayout();
            this.gbxC.SuspendLayout();
            this.gbxDepot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "HDS - Exporter EDI Relay";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.Location = new System.Drawing.Point(221, 509);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(302, 509);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tmrFetch
            // 
            this.tmrFetch.Interval = 600000;
            this.tmrFetch.Tick += new System.EventHandler(this.tmrFetch_Tick);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(530, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 13);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Offline";
            // 
            // lblInformation
            // 
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.ForeColor = System.Drawing.Color.Red;
            this.lblInformation.Location = new System.Drawing.Point(12, 461);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(571, 43);
            this.lblInformation.TabIndex = 14;
            this.lblInformation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chkAutoStart
            // 
            this.chkAutoStart.AutoSize = true;
            this.chkAutoStart.Enabled = false;
            this.chkAutoStart.Location = new System.Drawing.Point(506, 441);
            this.chkAutoStart.Name = "chkAutoStart";
            this.chkAutoStart.Size = new System.Drawing.Size(68, 17);
            this.chkAutoStart.TabIndex = 9;
            this.chkAutoStart.Text = "Autostart";
            this.chkAutoStart.UseVisualStyleBackColor = true;
            // 
            // tctrlMain
            // 
            this.tctrlMain.Controls.Add(this.tpgA_ToFTP);
            this.tctrlMain.Controls.Add(this.tpgB_ToNetPath);
            this.tctrlMain.Controls.Add(this.tpgC_ToLocalPath);
            this.tctrlMain.Location = new System.Drawing.Point(302, 71);
            this.tctrlMain.Name = "tctrlMain";
            this.tctrlMain.SelectedIndex = 0;
            this.tctrlMain.Size = new System.Drawing.Size(285, 364);
            this.tctrlMain.TabIndex = 15;
            // 
            // tpgA_ToFTP
            // 
            this.tpgA_ToFTP.Controls.Add(this.chkA_Enabled);
            this.tpgA_ToFTP.Controls.Add(this.gbxA);
            this.tpgA_ToFTP.Location = new System.Drawing.Point(4, 22);
            this.tpgA_ToFTP.Name = "tpgA_ToFTP";
            this.tpgA_ToFTP.Padding = new System.Windows.Forms.Padding(3);
            this.tpgA_ToFTP.Size = new System.Drawing.Size(277, 338);
            this.tpgA_ToFTP.TabIndex = 0;
            this.tpgA_ToFTP.Text = "To FTP";
            this.tpgA_ToFTP.UseVisualStyleBackColor = true;
            // 
            // chkA_Enabled
            // 
            this.chkA_Enabled.AutoSize = true;
            this.chkA_Enabled.Location = new System.Drawing.Point(203, 6);
            this.chkA_Enabled.Name = "chkA_Enabled";
            this.chkA_Enabled.Size = new System.Drawing.Size(65, 17);
            this.chkA_Enabled.TabIndex = 10;
            this.chkA_Enabled.Text = "Enabled";
            this.chkA_Enabled.UseVisualStyleBackColor = true;
            // 
            // gbxA
            // 
            this.gbxA.Controls.Add(this.label27);
            this.gbxA.Controls.Add(this.txtA_Dest_PO_DepotNames);
            this.gbxA.Controls.Add(this.label16);
            this.gbxA.Controls.Add(this.rdoA_Dest_PO_DepotName);
            this.gbxA.Controls.Add(this.rdoA_Dest_PO_All);
            this.gbxA.Controls.Add(this.txtA_Dest_POPath);
            this.gbxA.Controls.Add(this.label13);
            this.gbxA.Controls.Add(this.chkA_Dest_FetchPO);
            this.gbxA.Controls.Add(this.txtA_Dest_FileExt);
            this.gbxA.Controls.Add(this.label12);
            this.gbxA.Controls.Add(this.label6);
            this.gbxA.Controls.Add(this.txtA_Dest_Host);
            this.gbxA.Controls.Add(this.txtA_Dest_EDIPath);
            this.gbxA.Controls.Add(this.label2);
            this.gbxA.Controls.Add(this.txtA_Dest_Username);
            this.gbxA.Controls.Add(this.label3);
            this.gbxA.Controls.Add(this.txtA_Dest_Password);
            this.gbxA.Controls.Add(this.label4);
            this.gbxA.Location = new System.Drawing.Point(6, 26);
            this.gbxA.Name = "gbxA";
            this.gbxA.Size = new System.Drawing.Size(265, 306);
            this.gbxA.TabIndex = 12;
            this.gbxA.TabStop = false;
            this.gbxA.Text = "Destination Details (Exporter -> Destination)";
            // 
            // txtA_Dest_PO_DepotNames
            // 
            this.txtA_Dest_PO_DepotNames.Location = new System.Drawing.Point(86, 251);
            this.txtA_Dest_PO_DepotNames.Name = "txtA_Dest_PO_DepotNames";
            this.txtA_Dest_PO_DepotNames.Size = new System.Drawing.Size(144, 20);
            this.txtA_Dest_PO_DepotNames.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 254);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "Depot Name:";
            // 
            // rdoA_Dest_PO_DepotName
            // 
            this.rdoA_Dest_PO_DepotName.AutoSize = true;
            this.rdoA_Dest_PO_DepotName.Location = new System.Drawing.Point(86, 228);
            this.rdoA_Dest_PO_DepotName.Name = "rdoA_Dest_PO_DepotName";
            this.rdoA_Dest_PO_DepotName.Size = new System.Drawing.Size(115, 17);
            this.rdoA_Dest_PO_DepotName.TabIndex = 18;
            this.rdoA_Dest_PO_DepotName.TabStop = true;
            this.rdoA_Dest_PO_DepotName.Text = "Search Depot (PO)";
            this.rdoA_Dest_PO_DepotName.UseVisualStyleBackColor = true;
            // 
            // rdoA_Dest_PO_All
            // 
            this.rdoA_Dest_PO_All.AutoSize = true;
            this.rdoA_Dest_PO_All.Location = new System.Drawing.Point(86, 205);
            this.rdoA_Dest_PO_All.Name = "rdoA_Dest_PO_All";
            this.rdoA_Dest_PO_All.Size = new System.Drawing.Size(78, 17);
            this.rdoA_Dest_PO_All.TabIndex = 17;
            this.rdoA_Dest_PO_All.TabStop = true;
            this.rdoA_Dest_PO_All.Text = "All PO Files";
            this.rdoA_Dest_PO_All.UseVisualStyleBackColor = true;
            // 
            // txtA_Dest_POPath
            // 
            this.txtA_Dest_POPath.Location = new System.Drawing.Point(86, 179);
            this.txtA_Dest_POPath.Name = "txtA_Dest_POPath";
            this.txtA_Dest_POPath.Size = new System.Drawing.Size(144, 20);
            this.txtA_Dest_POPath.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 182);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "PO Path (out):";
            // 
            // chkA_Dest_FetchPO
            // 
            this.chkA_Dest_FetchPO.AutoSize = true;
            this.chkA_Dest_FetchPO.Location = new System.Drawing.Point(86, 156);
            this.chkA_Dest_FetchPO.Name = "chkA_Dest_FetchPO";
            this.chkA_Dest_FetchPO.Size = new System.Drawing.Size(92, 17);
            this.chkA_Dest_FetchPO.TabIndex = 15;
            this.chkA_Dest_FetchPO.Text = "Fetch PO files";
            this.chkA_Dest_FetchPO.UseVisualStyleBackColor = true;
            this.chkA_Dest_FetchPO.CheckedChanged += new System.EventHandler(this.chkA_Dest_FetchPO_CheckedChanged);
            // 
            // txtA_Dest_FileExt
            // 
            this.txtA_Dest_FileExt.Location = new System.Drawing.Point(86, 277);
            this.txtA_Dest_FileExt.Name = "txtA_Dest_FileExt";
            this.txtA_Dest_FileExt.Size = new System.Drawing.Size(144, 20);
            this.txtA_Dest_FileExt.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "File Extension:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Host:";
            // 
            // txtA_Dest_Host
            // 
            this.txtA_Dest_Host.Location = new System.Drawing.Point(86, 20);
            this.txtA_Dest_Host.Name = "txtA_Dest_Host";
            this.txtA_Dest_Host.Size = new System.Drawing.Size(144, 20);
            this.txtA_Dest_Host.TabIndex = 11;
            // 
            // txtA_Dest_EDIPath
            // 
            this.txtA_Dest_EDIPath.Location = new System.Drawing.Point(86, 130);
            this.txtA_Dest_EDIPath.Name = "txtA_Dest_EDIPath";
            this.txtA_Dest_EDIPath.Size = new System.Drawing.Size(144, 20);
            this.txtA_Dest_EDIPath.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // txtA_Dest_Username
            // 
            this.txtA_Dest_Username.Location = new System.Drawing.Point(86, 46);
            this.txtA_Dest_Username.Name = "txtA_Dest_Username";
            this.txtA_Dest_Username.Size = new System.Drawing.Size(144, 20);
            this.txtA_Dest_Username.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // txtA_Dest_Password
            // 
            this.txtA_Dest_Password.Location = new System.Drawing.Point(86, 72);
            this.txtA_Dest_Password.Name = "txtA_Dest_Password";
            this.txtA_Dest_Password.PasswordChar = '*';
            this.txtA_Dest_Password.Size = new System.Drawing.Size(144, 20);
            this.txtA_Dest_Password.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "EDI Path:";
            // 
            // tpgB_ToNetPath
            // 
            this.tpgB_ToNetPath.Controls.Add(this.chkB_Enabled);
            this.tpgB_ToNetPath.Controls.Add(this.gbxB);
            this.tpgB_ToNetPath.Location = new System.Drawing.Point(4, 22);
            this.tpgB_ToNetPath.Name = "tpgB_ToNetPath";
            this.tpgB_ToNetPath.Padding = new System.Windows.Forms.Padding(3);
            this.tpgB_ToNetPath.Size = new System.Drawing.Size(277, 338);
            this.tpgB_ToNetPath.TabIndex = 1;
            this.tpgB_ToNetPath.Text = "To NetPath";
            this.tpgB_ToNetPath.UseVisualStyleBackColor = true;
            // 
            // chkB_Enabled
            // 
            this.chkB_Enabled.AutoSize = true;
            this.chkB_Enabled.Location = new System.Drawing.Point(203, 6);
            this.chkB_Enabled.Name = "chkB_Enabled";
            this.chkB_Enabled.Size = new System.Drawing.Size(65, 17);
            this.chkB_Enabled.TabIndex = 30;
            this.chkB_Enabled.Text = "Enabled";
            this.chkB_Enabled.UseVisualStyleBackColor = true;
            // 
            // gbxB
            // 
            this.gbxB.Controls.Add(this.label28);
            this.gbxB.Controls.Add(this.txtB_Dest_ServerName);
            this.gbxB.Controls.Add(this.label14);
            this.gbxB.Controls.Add(this.txtB_Dest_PO_DepotNames);
            this.gbxB.Controls.Add(this.label26);
            this.gbxB.Controls.Add(this.rdoB_Dest_PO_DepotName);
            this.gbxB.Controls.Add(this.rdoB_Dest_PO_All);
            this.gbxB.Controls.Add(this.txtB_Dest_POPath);
            this.gbxB.Controls.Add(this.label20);
            this.gbxB.Controls.Add(this.chkB_Dest_FetchPO);
            this.gbxB.Controls.Add(this.txtB_Dest_FileExt);
            this.gbxB.Controls.Add(this.label21);
            this.gbxB.Controls.Add(this.label22);
            this.gbxB.Controls.Add(this.txtB_Dest_Host);
            this.gbxB.Controls.Add(this.txtB_Dest_EDIPath);
            this.gbxB.Controls.Add(this.label23);
            this.gbxB.Controls.Add(this.txtB_Dest_Username);
            this.gbxB.Controls.Add(this.label24);
            this.gbxB.Controls.Add(this.txtB_Dest_Password);
            this.gbxB.Controls.Add(this.label25);
            this.gbxB.Location = new System.Drawing.Point(6, 26);
            this.gbxB.Name = "gbxB";
            this.gbxB.Size = new System.Drawing.Size(265, 306);
            this.gbxB.TabIndex = 14;
            this.gbxB.TabStop = false;
            this.gbxB.Text = "Destination Details (Exporter -> Destination)";
            // 
            // txtB_Dest_ServerName
            // 
            this.txtB_Dest_ServerName.Location = new System.Drawing.Point(86, 98);
            this.txtB_Dest_ServerName.Name = "txtB_Dest_ServerName";
            this.txtB_Dest_ServerName.Size = new System.Drawing.Size(144, 20);
            this.txtB_Dest_ServerName.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Server Name:";
            // 
            // txtB_Dest_PO_DepotNames
            // 
            this.txtB_Dest_PO_DepotNames.Location = new System.Drawing.Point(86, 251);
            this.txtB_Dest_PO_DepotNames.Name = "txtB_Dest_PO_DepotNames";
            this.txtB_Dest_PO_DepotNames.Size = new System.Drawing.Size(144, 20);
            this.txtB_Dest_PO_DepotNames.TabIndex = 40;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(4, 254);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(70, 13);
            this.label26.TabIndex = 20;
            this.label26.Text = "Depot Name:";
            // 
            // rdoB_Dest_PO_DepotName
            // 
            this.rdoB_Dest_PO_DepotName.AutoSize = true;
            this.rdoB_Dest_PO_DepotName.Location = new System.Drawing.Point(86, 228);
            this.rdoB_Dest_PO_DepotName.Name = "rdoB_Dest_PO_DepotName";
            this.rdoB_Dest_PO_DepotName.Size = new System.Drawing.Size(115, 17);
            this.rdoB_Dest_PO_DepotName.TabIndex = 39;
            this.rdoB_Dest_PO_DepotName.TabStop = true;
            this.rdoB_Dest_PO_DepotName.Text = "Search Depot (PO)";
            this.rdoB_Dest_PO_DepotName.UseVisualStyleBackColor = true;
            // 
            // rdoB_Dest_PO_All
            // 
            this.rdoB_Dest_PO_All.AutoSize = true;
            this.rdoB_Dest_PO_All.Location = new System.Drawing.Point(86, 205);
            this.rdoB_Dest_PO_All.Name = "rdoB_Dest_PO_All";
            this.rdoB_Dest_PO_All.Size = new System.Drawing.Size(78, 17);
            this.rdoB_Dest_PO_All.TabIndex = 38;
            this.rdoB_Dest_PO_All.TabStop = true;
            this.rdoB_Dest_PO_All.Text = "All PO Files";
            this.rdoB_Dest_PO_All.UseVisualStyleBackColor = true;
            // 
            // txtB_Dest_POPath
            // 
            this.txtB_Dest_POPath.Location = new System.Drawing.Point(86, 179);
            this.txtB_Dest_POPath.Name = "txtB_Dest_POPath";
            this.txtB_Dest_POPath.Size = new System.Drawing.Size(144, 20);
            this.txtB_Dest_POPath.TabIndex = 37;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(4, 182);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 13);
            this.label20.TabIndex = 16;
            this.label20.Text = "PO Path (out):";
            // 
            // chkB_Dest_FetchPO
            // 
            this.chkB_Dest_FetchPO.AutoSize = true;
            this.chkB_Dest_FetchPO.Location = new System.Drawing.Point(86, 156);
            this.chkB_Dest_FetchPO.Name = "chkB_Dest_FetchPO";
            this.chkB_Dest_FetchPO.Size = new System.Drawing.Size(92, 17);
            this.chkB_Dest_FetchPO.TabIndex = 36;
            this.chkB_Dest_FetchPO.Text = "Fetch PO files";
            this.chkB_Dest_FetchPO.UseVisualStyleBackColor = true;
            this.chkB_Dest_FetchPO.CheckedChanged += new System.EventHandler(this.chkB_Dest_FetchPO_CheckedChanged);
            // 
            // txtB_Dest_FileExt
            // 
            this.txtB_Dest_FileExt.Location = new System.Drawing.Point(86, 277);
            this.txtB_Dest_FileExt.Name = "txtB_Dest_FileExt";
            this.txtB_Dest_FileExt.Size = new System.Drawing.Size(144, 20);
            this.txtB_Dest_FileExt.TabIndex = 41;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(4, 280);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 13);
            this.label21.TabIndex = 13;
            this.label21.Text = "File Extension:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 23);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(32, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "Host:";
            // 
            // txtB_Dest_Host
            // 
            this.txtB_Dest_Host.Location = new System.Drawing.Point(86, 20);
            this.txtB_Dest_Host.Name = "txtB_Dest_Host";
            this.txtB_Dest_Host.Size = new System.Drawing.Size(144, 20);
            this.txtB_Dest_Host.TabIndex = 31;
            // 
            // txtB_Dest_EDIPath
            // 
            this.txtB_Dest_EDIPath.Location = new System.Drawing.Point(86, 130);
            this.txtB_Dest_EDIPath.Name = "txtB_Dest_EDIPath";
            this.txtB_Dest_EDIPath.Size = new System.Drawing.Size(144, 20);
            this.txtB_Dest_EDIPath.TabIndex = 35;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 49);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "Username:";
            // 
            // txtB_Dest_Username
            // 
            this.txtB_Dest_Username.Location = new System.Drawing.Point(86, 46);
            this.txtB_Dest_Username.Name = "txtB_Dest_Username";
            this.txtB_Dest_Username.Size = new System.Drawing.Size(144, 20);
            this.txtB_Dest_Username.TabIndex = 32;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 75);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(56, 13);
            this.label24.TabIndex = 3;
            this.label24.Text = "Password:";
            // 
            // txtB_Dest_Password
            // 
            this.txtB_Dest_Password.Location = new System.Drawing.Point(86, 72);
            this.txtB_Dest_Password.Name = "txtB_Dest_Password";
            this.txtB_Dest_Password.PasswordChar = '*';
            this.txtB_Dest_Password.Size = new System.Drawing.Size(144, 20);
            this.txtB_Dest_Password.TabIndex = 33;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 133);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 13);
            this.label25.TabIndex = 5;
            this.label25.Text = "EDI Path:";
            // 
            // tpgC_ToLocalPath
            // 
            this.tpgC_ToLocalPath.Controls.Add(this.chkC_Enabled);
            this.tpgC_ToLocalPath.Controls.Add(this.gbxC);
            this.tpgC_ToLocalPath.Location = new System.Drawing.Point(4, 22);
            this.tpgC_ToLocalPath.Name = "tpgC_ToLocalPath";
            this.tpgC_ToLocalPath.Padding = new System.Windows.Forms.Padding(3);
            this.tpgC_ToLocalPath.Size = new System.Drawing.Size(277, 338);
            this.tpgC_ToLocalPath.TabIndex = 2;
            this.tpgC_ToLocalPath.Text = "To LocalPath";
            this.tpgC_ToLocalPath.UseVisualStyleBackColor = true;
            // 
            // chkC_Enabled
            // 
            this.chkC_Enabled.AutoSize = true;
            this.chkC_Enabled.Location = new System.Drawing.Point(203, 6);
            this.chkC_Enabled.Name = "chkC_Enabled";
            this.chkC_Enabled.Size = new System.Drawing.Size(65, 17);
            this.chkC_Enabled.TabIndex = 50;
            this.chkC_Enabled.Text = "Enabled";
            this.chkC_Enabled.UseVisualStyleBackColor = true;
            // 
            // gbxC
            // 
            this.gbxC.Controls.Add(this.label29);
            this.gbxC.Controls.Add(this.label15);
            this.gbxC.Controls.Add(this.txtC_Dest_PO_DepotNames);
            this.gbxC.Controls.Add(this.label33);
            this.gbxC.Controls.Add(this.rdoC_Dest_PO_DepotName);
            this.gbxC.Controls.Add(this.rdoC_Dest_PO_All);
            this.gbxC.Controls.Add(this.txtC_Dest_POPath);
            this.gbxC.Controls.Add(this.label34);
            this.gbxC.Controls.Add(this.chkC_Dest_FetchPO);
            this.gbxC.Controls.Add(this.txtC_Dest_FileExt);
            this.gbxC.Controls.Add(this.label35);
            this.gbxC.Controls.Add(this.txtC_Dest_EDIPath);
            this.gbxC.Controls.Add(this.label39);
            this.gbxC.Location = new System.Drawing.Point(6, 26);
            this.gbxC.Name = "gbxC";
            this.gbxC.Size = new System.Drawing.Size(265, 306);
            this.gbxC.TabIndex = 16;
            this.gbxC.TabStop = false;
            this.gbxC.Text = "Destination Details (Exporter -> Destination)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(98, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Local Machine";
            // 
            // txtC_Dest_PO_DepotNames
            // 
            this.txtC_Dest_PO_DepotNames.Location = new System.Drawing.Point(86, 251);
            this.txtC_Dest_PO_DepotNames.Name = "txtC_Dest_PO_DepotNames";
            this.txtC_Dest_PO_DepotNames.Size = new System.Drawing.Size(144, 20);
            this.txtC_Dest_PO_DepotNames.TabIndex = 56;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(4, 254);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(70, 13);
            this.label33.TabIndex = 20;
            this.label33.Text = "Depot Name:";
            // 
            // rdoC_Dest_PO_DepotName
            // 
            this.rdoC_Dest_PO_DepotName.AutoSize = true;
            this.rdoC_Dest_PO_DepotName.Location = new System.Drawing.Point(86, 228);
            this.rdoC_Dest_PO_DepotName.Name = "rdoC_Dest_PO_DepotName";
            this.rdoC_Dest_PO_DepotName.Size = new System.Drawing.Size(115, 17);
            this.rdoC_Dest_PO_DepotName.TabIndex = 55;
            this.rdoC_Dest_PO_DepotName.TabStop = true;
            this.rdoC_Dest_PO_DepotName.Text = "Search Depot (PO)";
            this.rdoC_Dest_PO_DepotName.UseVisualStyleBackColor = true;
            // 
            // rdoC_Dest_PO_All
            // 
            this.rdoC_Dest_PO_All.AutoSize = true;
            this.rdoC_Dest_PO_All.Location = new System.Drawing.Point(86, 205);
            this.rdoC_Dest_PO_All.Name = "rdoC_Dest_PO_All";
            this.rdoC_Dest_PO_All.Size = new System.Drawing.Size(78, 17);
            this.rdoC_Dest_PO_All.TabIndex = 54;
            this.rdoC_Dest_PO_All.TabStop = true;
            this.rdoC_Dest_PO_All.Text = "All PO Files";
            this.rdoC_Dest_PO_All.UseVisualStyleBackColor = true;
            // 
            // txtC_Dest_POPath
            // 
            this.txtC_Dest_POPath.Location = new System.Drawing.Point(86, 179);
            this.txtC_Dest_POPath.Name = "txtC_Dest_POPath";
            this.txtC_Dest_POPath.Size = new System.Drawing.Size(144, 20);
            this.txtC_Dest_POPath.TabIndex = 53;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(4, 182);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(74, 13);
            this.label34.TabIndex = 16;
            this.label34.Text = "PO Path (out):";
            // 
            // chkC_Dest_FetchPO
            // 
            this.chkC_Dest_FetchPO.AutoSize = true;
            this.chkC_Dest_FetchPO.Location = new System.Drawing.Point(86, 156);
            this.chkC_Dest_FetchPO.Name = "chkC_Dest_FetchPO";
            this.chkC_Dest_FetchPO.Size = new System.Drawing.Size(92, 17);
            this.chkC_Dest_FetchPO.TabIndex = 52;
            this.chkC_Dest_FetchPO.Text = "Fetch PO files";
            this.chkC_Dest_FetchPO.UseVisualStyleBackColor = true;
            this.chkC_Dest_FetchPO.CheckedChanged += new System.EventHandler(this.chkC_Dest_FetchPO_CheckedChanged);
            // 
            // txtC_Dest_FileExt
            // 
            this.txtC_Dest_FileExt.Location = new System.Drawing.Point(86, 277);
            this.txtC_Dest_FileExt.Name = "txtC_Dest_FileExt";
            this.txtC_Dest_FileExt.Size = new System.Drawing.Size(144, 20);
            this.txtC_Dest_FileExt.TabIndex = 57;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(4, 280);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(75, 13);
            this.label35.TabIndex = 13;
            this.label35.Text = "File Extension:";
            // 
            // txtC_Dest_EDIPath
            // 
            this.txtC_Dest_EDIPath.Location = new System.Drawing.Point(86, 130);
            this.txtC_Dest_EDIPath.Name = "txtC_Dest_EDIPath";
            this.txtC_Dest_EDIPath.Size = new System.Drawing.Size(144, 20);
            this.txtC_Dest_EDIPath.TabIndex = 51;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(6, 133);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(53, 13);
            this.label39.TabIndex = 5;
            this.label39.Text = "EDI Path:";
            // 
            // gbxDepot
            // 
            this.gbxDepot.Controls.Add(this.txtA_Depot_FileExt);
            this.gbxDepot.Controls.Add(this.label11);
            this.gbxDepot.Controls.Add(this.txtA_Depot_POPath);
            this.gbxDepot.Controls.Add(this.label10);
            this.gbxDepot.Controls.Add(this.label5);
            this.gbxDepot.Controls.Add(this.txtA_Depot_Host);
            this.gbxDepot.Controls.Add(this.txtA_Depot_EDIPath);
            this.gbxDepot.Controls.Add(this.label7);
            this.gbxDepot.Controls.Add(this.txtA_Depot_Username);
            this.gbxDepot.Controls.Add(this.label8);
            this.gbxDepot.Controls.Add(this.txtA_Depot_Password);
            this.gbxDepot.Controls.Add(this.label9);
            this.gbxDepot.Location = new System.Drawing.Point(12, 119);
            this.gbxDepot.Name = "gbxDepot";
            this.gbxDepot.Size = new System.Drawing.Size(271, 316);
            this.gbxDepot.TabIndex = 16;
            this.gbxDepot.TabStop = false;
            this.gbxDepot.Text = "Depot Details (Depot -> Exporter)";
            // 
            // txtA_Depot_FileExt
            // 
            this.txtA_Depot_FileExt.Location = new System.Drawing.Point(88, 156);
            this.txtA_Depot_FileExt.Name = "txtA_Depot_FileExt";
            this.txtA_Depot_FileExt.Size = new System.Drawing.Size(144, 20);
            this.txtA_Depot_FileExt.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "File Extension:";
            // 
            // txtA_Depot_POPath
            // 
            this.txtA_Depot_POPath.Location = new System.Drawing.Point(88, 202);
            this.txtA_Depot_POPath.Name = "txtA_Depot_POPath";
            this.txtA_Depot_POPath.Size = new System.Drawing.Size(144, 20);
            this.txtA_Depot_POPath.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "PO Path (in):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "*Host:";
            // 
            // txtA_Depot_Host
            // 
            this.txtA_Depot_Host.Location = new System.Drawing.Point(88, 20);
            this.txtA_Depot_Host.Name = "txtA_Depot_Host";
            this.txtA_Depot_Host.Size = new System.Drawing.Size(144, 20);
            this.txtA_Depot_Host.TabIndex = 2;
            // 
            // txtA_Depot_EDIPath
            // 
            this.txtA_Depot_EDIPath.Location = new System.Drawing.Point(88, 130);
            this.txtA_Depot_EDIPath.Name = "txtA_Depot_EDIPath";
            this.txtA_Depot_EDIPath.Size = new System.Drawing.Size(144, 20);
            this.txtA_Depot_EDIPath.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "*Username:";
            // 
            // txtA_Depot_Username
            // 
            this.txtA_Depot_Username.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtA_Depot_Username.Location = new System.Drawing.Point(88, 46);
            this.txtA_Depot_Username.Name = "txtA_Depot_Username";
            this.txtA_Depot_Username.Size = new System.Drawing.Size(144, 20);
            this.txtA_Depot_Username.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "*Password:";
            // 
            // txtA_Depot_Password
            // 
            this.txtA_Depot_Password.Location = new System.Drawing.Point(88, 72);
            this.txtA_Depot_Password.Name = "txtA_Depot_Password";
            this.txtA_Depot_Password.PasswordChar = '*';
            this.txtA_Depot_Password.Size = new System.Drawing.Size(144, 20);
            this.txtA_Depot_Password.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "*EDI Path (out):";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(148, 73);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Timer:";
            // 
            // nudTimer
            // 
            this.nudTimer.Location = new System.Drawing.Point(190, 71);
            this.nudTimer.Name = "nudTimer";
            this.nudTimer.Size = new System.Drawing.Size(43, 20);
            this.nudTimer.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(239, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "minutes";
            // 
            // lblTimeRemaining
            // 
            this.lblTimeRemaining.AutoSize = true;
            this.lblTimeRemaining.Location = new System.Drawing.Point(12, 73);
            this.lblTimeRemaining.Name = "lblTimeRemaining";
            this.lblTimeRemaining.Size = new System.Drawing.Size(81, 13);
            this.lblTimeRemaining.TabIndex = 20;
            this.lblTimeRemaining.Text = "0 sec remaining";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 442);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 13);
            this.label19.TabIndex = 21;
            this.label19.Text = "Last +transaction:";
            // 
            // lblLastXmit
            // 
            this.lblLastXmit.AutoSize = true;
            this.lblLastXmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastXmit.Location = new System.Drawing.Point(109, 442);
            this.lblLastXmit.Name = "lblLastXmit";
            this.lblLastXmit.Size = new System.Drawing.Size(93, 13);
            this.lblLastXmit.TabIndex = 22;
            this.lblLastXmit.Text = "0 EDI / 0 PO - DT";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Gray;
            this.label28.Location = new System.Drawing.Point(5, 123);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(253, 2);
            this.label28.TabIndex = 42;
            this.label28.Text = resources.GetString("label28.Text");
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Gray;
            this.label27.Location = new System.Drawing.Point(5, 123);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(253, 2);
            this.label27.TabIndex = 43;
            this.label27.Text = resources.GetString("label27.Text");
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Gray;
            this.label29.Location = new System.Drawing.Point(5, 123);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(253, 2);
            this.label29.TabIndex = 58;
            this.label29.Text = resources.GetString("label29.Text");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 544);
            this.Controls.Add(this.lblLastXmit);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblTimeRemaining);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.nudTimer);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.gbxDepot);
            this.Controls.Add(this.tctrlMain);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.chkAutoStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HDS - EDI Relay v0.1-BETA";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tctrlMain.ResumeLayout(false);
            this.tpgA_ToFTP.ResumeLayout(false);
            this.tpgA_ToFTP.PerformLayout();
            this.gbxA.ResumeLayout(false);
            this.gbxA.PerformLayout();
            this.tpgB_ToNetPath.ResumeLayout(false);
            this.tpgB_ToNetPath.PerformLayout();
            this.gbxB.ResumeLayout(false);
            this.gbxB.PerformLayout();
            this.tpgC_ToLocalPath.ResumeLayout(false);
            this.tpgC_ToLocalPath.PerformLayout();
            this.gbxC.ResumeLayout(false);
            this.gbxC.PerformLayout();
            this.gbxDepot.ResumeLayout(false);
            this.gbxDepot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer tmrFetch;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.CheckBox chkAutoStart;
        private System.Windows.Forms.TabControl tctrlMain;
        private System.Windows.Forms.TabPage tpgA_ToFTP;
        private System.Windows.Forms.GroupBox gbxA;
        private System.Windows.Forms.TextBox txtA_Dest_POPath;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkA_Dest_FetchPO;
        private System.Windows.Forms.TextBox txtA_Dest_FileExt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtA_Dest_Host;
        private System.Windows.Forms.TextBox txtA_Dest_EDIPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA_Dest_Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtA_Dest_Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tpgB_ToNetPath;
        private System.Windows.Forms.GroupBox gbxB;
        private System.Windows.Forms.RadioButton rdoB_Dest_PO_DepotName;
        private System.Windows.Forms.RadioButton rdoB_Dest_PO_All;
        private System.Windows.Forms.TextBox txtB_Dest_POPath;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox chkB_Dest_FetchPO;
        private System.Windows.Forms.TextBox txtB_Dest_FileExt;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtB_Dest_Host;
        private System.Windows.Forms.TextBox txtB_Dest_EDIPath;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtB_Dest_Username;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtB_Dest_Password;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TabPage tpgC_ToLocalPath;
        private System.Windows.Forms.TextBox txtB_Dest_PO_DepotNames;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox gbxC;
        private System.Windows.Forms.TextBox txtC_Dest_PO_DepotNames;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.RadioButton rdoC_Dest_PO_DepotName;
        private System.Windows.Forms.RadioButton rdoC_Dest_PO_All;
        private System.Windows.Forms.TextBox txtC_Dest_POPath;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.CheckBox chkC_Dest_FetchPO;
        private System.Windows.Forms.TextBox txtC_Dest_FileExt;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtC_Dest_EDIPath;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.GroupBox gbxDepot;
        private System.Windows.Forms.TextBox txtA_Depot_FileExt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtA_Depot_POPath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtA_Depot_Host;
        private System.Windows.Forms.TextBox txtA_Depot_EDIPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtA_Depot_Username;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtA_Depot_Password;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtB_Dest_ServerName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chkA_Enabled;
        private System.Windows.Forms.CheckBox chkB_Enabled;
        private System.Windows.Forms.CheckBox chkC_Enabled;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtA_Dest_PO_DepotNames;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rdoA_Dest_PO_DepotName;
        private System.Windows.Forms.RadioButton rdoA_Dest_PO_All;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nudTimer;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblTimeRemaining;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblLastXmit;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
    }
}

