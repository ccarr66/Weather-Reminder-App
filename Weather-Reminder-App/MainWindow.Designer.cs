namespace Weather_Reminder_App
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.lbl_DispLoc = new System.Windows.Forms.Label();
            this.lbl_DispTemp = new System.Windows.Forms.Label();
            this.lbl_DispGenWeather = new System.Windows.Forms.Label();
            this.lbl_LHumidity = new System.Windows.Forms.Label();
            this.lbl_LCoords = new System.Windows.Forms.Label();
            this.lbl_LMaxTemp = new System.Windows.Forms.Label();
            this.lbl_LMinTemp = new System.Windows.Forms.Label();
            this.lbl_DispMaxTemp = new System.Windows.Forms.Label();
            this.lbl_DispMinTemp = new System.Windows.Forms.Label();
            this.lbl_LWindSp = new System.Windows.Forms.Label();
            this.lbl_LWindDir = new System.Windows.Forms.Label();
            this.lbl_DispCoords = new System.Windows.Forms.Label();
            this.lbl_DispHumidity = new System.Windows.Forms.Label();
            this.lbl_DispWindSp = new System.Windows.Forms.Label();
            this.lbl_DispWindDir = new System.Windows.Forms.Label();
            this.lbl_LCloud = new System.Windows.Forms.Label();
            this.lbl_DispClouds = new System.Windows.Forms.Label();
            this.lbl_Alerts = new System.Windows.Forms.Label();
            this.pnl_Settings = new System.Windows.Forms.Panel();
            this.btn_SaveSett = new System.Windows.Forms.Button();
            this.chbx_Both = new System.Windows.Forms.CheckBox();
            this.chbx_Desktop = new System.Windows.Forms.CheckBox();
            this.chbx_Email = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_SettEmail = new System.Windows.Forms.TextBox();
            this.lbl_LSettEmail = new System.Windows.Forms.Label();
            this.txtbx_SettLoc = new System.Windows.Forms.TextBox();
            this.lbl_LSettLoc = new System.Windows.Forms.Label();
            this.txtbx_SettUser = new System.Windows.Forms.TextBox();
            this.lbl_SettUser = new System.Windows.Forms.Label();
            this.lbl_Settings = new System.Windows.Forms.Label();
            this.lbl_AlertName = new System.Windows.Forms.Label();
            this.lbl_AlertTime = new System.Windows.Forms.Label();
            this.lbl_AlertConditions = new System.Windows.Forms.Label();
            this.txtbx_NAL_Name = new System.Windows.Forms.TextBox();
            this.txtbx_NAL_Time = new System.Windows.Forms.TextBox();
            this.cmbx_NAL_Time = new System.Windows.Forms.ComboBox();
            this.chbx_NAL_All = new System.Windows.Forms.CheckBox();
            this.chbx_NAL_Rain = new System.Windows.Forms.CheckBox();
            this.chbx_NAL_Snow = new System.Windows.Forms.CheckBox();
            this.chbx_NAL_Thunder = new System.Windows.Forms.CheckBox();
            this.chbx_NAL_Atmosphere = new System.Windows.Forms.CheckBox();
            this.chbx_NAL_Hot = new System.Windows.Forms.CheckBox();
            this.txtbx_NAL_Hot = new System.Windows.Forms.TextBox();
            this.txtbx_NAL_Cold = new System.Windows.Forms.TextBox();
            this.chbx_NAL_Cold = new System.Windows.Forms.CheckBox();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.pctbx_Line = new System.Windows.Forms.PictureBox();
            this.saveAlerts = new System.Windows.Forms.Button();
            this.btn_RemoveAlerts = new System.Windows.Forms.Button();
            this.btn_SwitchUsers = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_AddAlerts = new System.Windows.Forms.Button();
            this.pctbx_WeatherIcon = new System.Windows.Forms.PictureBox();
            this.pnl_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_Line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_WeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_DispLoc
            // 
            this.lbl_DispLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DispLoc.Location = new System.Drawing.Point(0, 21);
            this.lbl_DispLoc.Name = "lbl_DispLoc";
            this.lbl_DispLoc.Size = new System.Drawing.Size(485, 39);
            this.lbl_DispLoc.TabIndex = 0;
            this.lbl_DispLoc.Text = "(ERROR)";
            this.lbl_DispLoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_DispTemp
            // 
            this.lbl_DispTemp.AutoSize = true;
            this.lbl_DispTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DispTemp.Location = new System.Drawing.Point(199, 63);
            this.lbl_DispTemp.Name = "lbl_DispTemp";
            this.lbl_DispTemp.Size = new System.Drawing.Size(166, 39);
            this.lbl_DispTemp.TabIndex = 0;
            this.lbl_DispTemp.Text = "(ERROR)";
            // 
            // lbl_DispGenWeather
            // 
            this.lbl_DispGenWeather.AutoSize = true;
            this.lbl_DispGenWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DispGenWeather.Location = new System.Drawing.Point(199, 111);
            this.lbl_DispGenWeather.Name = "lbl_DispGenWeather";
            this.lbl_DispGenWeather.Size = new System.Drawing.Size(131, 31);
            this.lbl_DispGenWeather.TabIndex = 0;
            this.lbl_DispGenWeather.Text = "(ERROR)";
            // 
            // lbl_LHumidity
            // 
            this.lbl_LHumidity.AutoSize = true;
            this.lbl_LHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LHumidity.Location = new System.Drawing.Point(90, 258);
            this.lbl_LHumidity.Name = "lbl_LHumidity";
            this.lbl_LHumidity.Size = new System.Drawing.Size(72, 16);
            this.lbl_LHumidity.TabIndex = 0;
            this.lbl_LHumidity.Text = "Humidity:";
            // 
            // lbl_LCoords
            // 
            this.lbl_LCoords.AutoSize = true;
            this.lbl_LCoords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LCoords.Location = new System.Drawing.Point(90, 228);
            this.lbl_LCoords.Name = "lbl_LCoords";
            this.lbl_LCoords.Size = new System.Drawing.Size(96, 16);
            this.lbl_LCoords.TabIndex = 0;
            this.lbl_LCoords.Text = "Coordinates:";
            // 
            // lbl_LMaxTemp
            // 
            this.lbl_LMaxTemp.AutoSize = true;
            this.lbl_LMaxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LMaxTemp.Location = new System.Drawing.Point(140, 170);
            this.lbl_LMaxTemp.Name = "lbl_LMaxTemp";
            this.lbl_LMaxTemp.Size = new System.Drawing.Size(40, 16);
            this.lbl_LMaxTemp.TabIndex = 0;
            this.lbl_LMaxTemp.Text = "Max:";
            // 
            // lbl_LMinTemp
            // 
            this.lbl_LMinTemp.AutoSize = true;
            this.lbl_LMinTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LMinTemp.Location = new System.Drawing.Point(249, 170);
            this.lbl_LMinTemp.Name = "lbl_LMinTemp";
            this.lbl_LMinTemp.Size = new System.Drawing.Size(31, 13);
            this.lbl_LMinTemp.TabIndex = 0;
            this.lbl_LMinTemp.Text = "Min:";
            // 
            // lbl_DispMaxTemp
            // 
            this.lbl_DispMaxTemp.AutoSize = true;
            this.lbl_DispMaxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DispMaxTemp.Location = new System.Drawing.Point(176, 170);
            this.lbl_DispMaxTemp.Name = "lbl_DispMaxTemp";
            this.lbl_DispMaxTemp.Size = new System.Drawing.Size(70, 25);
            this.lbl_DispMaxTemp.TabIndex = 0;
            this.lbl_DispMaxTemp.Text = "(ERR)";
            // 
            // lbl_DispMinTemp
            // 
            this.lbl_DispMinTemp.AutoSize = true;
            this.lbl_DispMinTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DispMinTemp.Location = new System.Drawing.Point(282, 170);
            this.lbl_DispMinTemp.Name = "lbl_DispMinTemp";
            this.lbl_DispMinTemp.Size = new System.Drawing.Size(54, 20);
            this.lbl_DispMinTemp.TabIndex = 0;
            this.lbl_DispMinTemp.Text = "(ERR)";
            // 
            // lbl_LWindSp
            // 
            this.lbl_LWindSp.AutoSize = true;
            this.lbl_LWindSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LWindSp.Location = new System.Drawing.Point(90, 288);
            this.lbl_LWindSp.Name = "lbl_LWindSp";
            this.lbl_LWindSp.Size = new System.Drawing.Size(97, 16);
            this.lbl_LWindSp.TabIndex = 0;
            this.lbl_LWindSp.Text = "Wind Speed:";
            // 
            // lbl_LWindDir
            // 
            this.lbl_LWindDir.AutoSize = true;
            this.lbl_LWindDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LWindDir.Location = new System.Drawing.Point(280, 291);
            this.lbl_LWindDir.Name = "lbl_LWindDir";
            this.lbl_LWindDir.Size = new System.Drawing.Size(74, 16);
            this.lbl_LWindDir.TabIndex = 0;
            this.lbl_LWindDir.Text = "Direction:";
            // 
            // lbl_DispCoords
            // 
            this.lbl_DispCoords.AutoSize = true;
            this.lbl_DispCoords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DispCoords.Location = new System.Drawing.Point(192, 228);
            this.lbl_DispCoords.Name = "lbl_DispCoords";
            this.lbl_DispCoords.Size = new System.Drawing.Size(65, 16);
            this.lbl_DispCoords.TabIndex = 0;
            this.lbl_DispCoords.Text = "(ERROR)";
            // 
            // lbl_DispHumidity
            // 
            this.lbl_DispHumidity.AutoSize = true;
            this.lbl_DispHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DispHumidity.Location = new System.Drawing.Point(192, 258);
            this.lbl_DispHumidity.Name = "lbl_DispHumidity";
            this.lbl_DispHumidity.Size = new System.Drawing.Size(65, 16);
            this.lbl_DispHumidity.TabIndex = 0;
            this.lbl_DispHumidity.Text = "(ERROR)";
            // 
            // lbl_DispWindSp
            // 
            this.lbl_DispWindSp.AutoSize = true;
            this.lbl_DispWindSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DispWindSp.Location = new System.Drawing.Point(192, 288);
            this.lbl_DispWindSp.Name = "lbl_DispWindSp";
            this.lbl_DispWindSp.Size = new System.Drawing.Size(65, 16);
            this.lbl_DispWindSp.TabIndex = 0;
            this.lbl_DispWindSp.Text = "(ERROR)";
            // 
            // lbl_DispWindDir
            // 
            this.lbl_DispWindDir.AutoSize = true;
            this.lbl_DispWindDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DispWindDir.Location = new System.Drawing.Point(360, 291);
            this.lbl_DispWindDir.Name = "lbl_DispWindDir";
            this.lbl_DispWindDir.Size = new System.Drawing.Size(65, 16);
            this.lbl_DispWindDir.TabIndex = 0;
            this.lbl_DispWindDir.Text = "(ERROR)";
            // 
            // lbl_LCloud
            // 
            this.lbl_LCloud.AutoSize = true;
            this.lbl_LCloud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LCloud.Location = new System.Drawing.Point(90, 318);
            this.lbl_LCloud.Name = "lbl_LCloud";
            this.lbl_LCloud.Size = new System.Drawing.Size(60, 16);
            this.lbl_LCloud.TabIndex = 0;
            this.lbl_LCloud.Text = "Clouds:";
            // 
            // lbl_DispClouds
            // 
            this.lbl_DispClouds.AutoSize = true;
            this.lbl_DispClouds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DispClouds.Location = new System.Drawing.Point(192, 318);
            this.lbl_DispClouds.Name = "lbl_DispClouds";
            this.lbl_DispClouds.Size = new System.Drawing.Size(65, 16);
            this.lbl_DispClouds.TabIndex = 0;
            this.lbl_DispClouds.Text = "(ERROR)";
            // 
            // lbl_Alerts
            // 
            this.lbl_Alerts.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Alerts.Location = new System.Drawing.Point(0, 364);
            this.lbl_Alerts.Name = "lbl_Alerts";
            this.lbl_Alerts.Size = new System.Drawing.Size(485, 39);
            this.lbl_Alerts.TabIndex = 0;
            this.lbl_Alerts.Text = "Alerts";
            this.lbl_Alerts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Settings
            // 
            this.pnl_Settings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Settings.Controls.Add(this.btn_SaveSett);
            this.pnl_Settings.Controls.Add(this.chbx_Both);
            this.pnl_Settings.Controls.Add(this.chbx_Desktop);
            this.pnl_Settings.Controls.Add(this.chbx_Email);
            this.pnl_Settings.Controls.Add(this.label2);
            this.pnl_Settings.Controls.Add(this.txtbx_SettEmail);
            this.pnl_Settings.Controls.Add(this.lbl_LSettEmail);
            this.pnl_Settings.Controls.Add(this.txtbx_SettLoc);
            this.pnl_Settings.Controls.Add(this.lbl_LSettLoc);
            this.pnl_Settings.Controls.Add(this.txtbx_SettUser);
            this.pnl_Settings.Controls.Add(this.lbl_SettUser);
            this.pnl_Settings.Controls.Add(this.lbl_Settings);
            this.pnl_Settings.Location = new System.Drawing.Point(492, 13);
            this.pnl_Settings.Name = "pnl_Settings";
            this.pnl_Settings.Size = new System.Drawing.Size(180, 550);
            this.pnl_Settings.TabIndex = 0;
            // 
            // btn_SaveSett
            // 
            this.btn_SaveSett.Location = new System.Drawing.Point(3, 480);
            this.btn_SaveSett.Name = "btn_SaveSett";
            this.btn_SaveSett.Size = new System.Drawing.Size(172, 65);
            this.btn_SaveSett.TabIndex = 0;
            this.btn_SaveSett.TabStop = false;
            this.btn_SaveSett.Text = "Save Changes";
            this.btn_SaveSett.UseVisualStyleBackColor = true;
            this.btn_SaveSett.Click += new System.EventHandler(this.btn_SaveSett_Click);
            // 
            // chbx_Both
            // 
            this.chbx_Both.AutoSize = true;
            this.chbx_Both.Location = new System.Drawing.Point(10, 281);
            this.chbx_Both.Name = "chbx_Both";
            this.chbx_Both.Size = new System.Drawing.Size(48, 17);
            this.chbx_Both.TabIndex = 0;
            this.chbx_Both.TabStop = false;
            this.chbx_Both.Text = "Both";
            this.chbx_Both.UseVisualStyleBackColor = true;
            this.chbx_Both.Click += new System.EventHandler(this.chbx_Both_Click);
            // 
            // chbx_Desktop
            // 
            this.chbx_Desktop.AutoSize = true;
            this.chbx_Desktop.Location = new System.Drawing.Point(10, 258);
            this.chbx_Desktop.Name = "chbx_Desktop";
            this.chbx_Desktop.Size = new System.Drawing.Size(66, 17);
            this.chbx_Desktop.TabIndex = 0;
            this.chbx_Desktop.TabStop = false;
            this.chbx_Desktop.Text = "Desktop";
            this.chbx_Desktop.UseVisualStyleBackColor = true;
            this.chbx_Desktop.Click += new System.EventHandler(this.chbx_Desktop_Click);
            // 
            // chbx_Email
            // 
            this.chbx_Email.AutoSize = true;
            this.chbx_Email.Location = new System.Drawing.Point(10, 235);
            this.chbx_Email.Name = "chbx_Email";
            this.chbx_Email.Size = new System.Drawing.Size(51, 17);
            this.chbx_Email.TabIndex = 0;
            this.chbx_Email.TabStop = false;
            this.chbx_Email.Text = "Email";
            this.chbx_Email.UseVisualStyleBackColor = true;
            this.chbx_Email.Click += new System.EventHandler(this.chbx_Email_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Notification Preference:";
            // 
            // txtbx_SettEmail
            // 
            this.txtbx_SettEmail.Location = new System.Drawing.Point(10, 175);
            this.txtbx_SettEmail.Name = "txtbx_SettEmail";
            this.txtbx_SettEmail.Size = new System.Drawing.Size(160, 20);
            this.txtbx_SettEmail.TabIndex = 0;
            this.txtbx_SettEmail.TabStop = false;
            // 
            // lbl_LSettEmail
            // 
            this.lbl_LSettEmail.AutoSize = true;
            this.lbl_LSettEmail.Location = new System.Drawing.Point(7, 158);
            this.lbl_LSettEmail.Name = "lbl_LSettEmail";
            this.lbl_LSettEmail.Size = new System.Drawing.Size(80, 13);
            this.lbl_LSettEmail.TabIndex = 0;
            this.lbl_LSettEmail.Text = "Email(Optional):";
            // 
            // txtbx_SettLoc
            // 
            this.txtbx_SettLoc.Location = new System.Drawing.Point(10, 115);
            this.txtbx_SettLoc.Name = "txtbx_SettLoc";
            this.txtbx_SettLoc.Size = new System.Drawing.Size(160, 20);
            this.txtbx_SettLoc.TabIndex = 0;
            this.txtbx_SettLoc.TabStop = false;
            // 
            // lbl_LSettLoc
            // 
            this.lbl_LSettLoc.AutoSize = true;
            this.lbl_LSettLoc.Location = new System.Drawing.Point(7, 98);
            this.lbl_LSettLoc.Name = "lbl_LSettLoc";
            this.lbl_LSettLoc.Size = new System.Drawing.Size(51, 13);
            this.lbl_LSettLoc.TabIndex = 0;
            this.lbl_LSettLoc.Text = "Location:";
            // 
            // txtbx_SettUser
            // 
            this.txtbx_SettUser.Location = new System.Drawing.Point(10, 55);
            this.txtbx_SettUser.Name = "txtbx_SettUser";
            this.txtbx_SettUser.Size = new System.Drawing.Size(160, 20);
            this.txtbx_SettUser.TabIndex = 0;
            this.txtbx_SettUser.TabStop = false;
            // 
            // lbl_SettUser
            // 
            this.lbl_SettUser.AutoSize = true;
            this.lbl_SettUser.Location = new System.Drawing.Point(7, 38);
            this.lbl_SettUser.Name = "lbl_SettUser";
            this.lbl_SettUser.Size = new System.Drawing.Size(58, 13);
            this.lbl_SettUser.TabIndex = 0;
            this.lbl_SettUser.Text = "Username:";
            // 
            // lbl_Settings
            // 
            this.lbl_Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Settings.Location = new System.Drawing.Point(3, 10);
            this.lbl_Settings.Name = "lbl_Settings";
            this.lbl_Settings.Size = new System.Drawing.Size(172, 24);
            this.lbl_Settings.TabIndex = 0;
            this.lbl_Settings.Text = "Settings";
            this.lbl_Settings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_AlertName
            // 
            this.lbl_AlertName.AutoSize = true;
            this.lbl_AlertName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AlertName.Location = new System.Drawing.Point(12, 416);
            this.lbl_AlertName.Name = "lbl_AlertName";
            this.lbl_AlertName.Size = new System.Drawing.Size(55, 20);
            this.lbl_AlertName.TabIndex = 0;
            this.lbl_AlertName.Text = "Name";
            // 
            // lbl_AlertTime
            // 
            this.lbl_AlertTime.AutoSize = true;
            this.lbl_AlertTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AlertTime.Location = new System.Drawing.Point(139, 416);
            this.lbl_AlertTime.Name = "lbl_AlertTime";
            this.lbl_AlertTime.Size = new System.Drawing.Size(47, 20);
            this.lbl_AlertTime.TabIndex = 0;
            this.lbl_AlertTime.Text = "Time";
            // 
            // lbl_AlertConditions
            // 
            this.lbl_AlertConditions.AutoSize = true;
            this.lbl_AlertConditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AlertConditions.Location = new System.Drawing.Point(203, 416);
            this.lbl_AlertConditions.Name = "lbl_AlertConditions";
            this.lbl_AlertConditions.Size = new System.Drawing.Size(94, 20);
            this.lbl_AlertConditions.TabIndex = 0;
            this.lbl_AlertConditions.Text = "Conditions";
            // 
            // txtbx_NAL_Name
            // 
            this.txtbx_NAL_Name.Location = new System.Drawing.Point(16, 439);
            this.txtbx_NAL_Name.MaxLength = 10;
            this.txtbx_NAL_Name.Name = "txtbx_NAL_Name";
            this.txtbx_NAL_Name.Size = new System.Drawing.Size(87, 20);
            this.txtbx_NAL_Name.TabIndex = 0;
            this.txtbx_NAL_Name.TabStop = false;
            // 
            // txtbx_NAL_Time
            // 
            this.txtbx_NAL_Time.Location = new System.Drawing.Point(143, 439);
            this.txtbx_NAL_Time.Name = "txtbx_NAL_Time";
            this.txtbx_NAL_Time.Size = new System.Drawing.Size(51, 20);
            this.txtbx_NAL_Time.TabIndex = 0;
            this.txtbx_NAL_Time.TabStop = false;
            // 
            // cmbx_NAL_Time
            // 
            this.cmbx_NAL_Time.FormattingEnabled = true;
            this.cmbx_NAL_Time.Items.AddRange(new object[] {
            "am",
            "pm"});
            this.cmbx_NAL_Time.Location = new System.Drawing.Point(143, 465);
            this.cmbx_NAL_Time.Name = "cmbx_NAL_Time";
            this.cmbx_NAL_Time.Size = new System.Drawing.Size(39, 21);
            this.cmbx_NAL_Time.TabIndex = 0;
            this.cmbx_NAL_Time.TabStop = false;
            // 
            // chbx_NAL_All
            // 
            this.chbx_NAL_All.AutoSize = true;
            this.chbx_NAL_All.Location = new System.Drawing.Point(207, 439);
            this.chbx_NAL_All.Name = "chbx_NAL_All";
            this.chbx_NAL_All.Size = new System.Drawing.Size(37, 17);
            this.chbx_NAL_All.TabIndex = 0;
            this.chbx_NAL_All.TabStop = false;
            this.chbx_NAL_All.Text = "All";
            this.chbx_NAL_All.UseVisualStyleBackColor = true;
            this.chbx_NAL_All.CheckedChanged += new System.EventHandler(this.chbx_NAL_All_CheckedChanged);
            // 
            // chbx_NAL_Rain
            // 
            this.chbx_NAL_Rain.AutoSize = true;
            this.chbx_NAL_Rain.Location = new System.Drawing.Point(207, 463);
            this.chbx_NAL_Rain.Name = "chbx_NAL_Rain";
            this.chbx_NAL_Rain.Size = new System.Drawing.Size(48, 17);
            this.chbx_NAL_Rain.TabIndex = 0;
            this.chbx_NAL_Rain.TabStop = false;
            this.chbx_NAL_Rain.Text = "Rain";
            this.chbx_NAL_Rain.UseVisualStyleBackColor = true;
            // 
            // chbx_NAL_Snow
            // 
            this.chbx_NAL_Snow.AutoSize = true;
            this.chbx_NAL_Snow.Location = new System.Drawing.Point(207, 486);
            this.chbx_NAL_Snow.Name = "chbx_NAL_Snow";
            this.chbx_NAL_Snow.Size = new System.Drawing.Size(53, 17);
            this.chbx_NAL_Snow.TabIndex = 0;
            this.chbx_NAL_Snow.TabStop = false;
            this.chbx_NAL_Snow.Text = "Snow";
            this.chbx_NAL_Snow.UseVisualStyleBackColor = true;
            // 
            // chbx_NAL_Thunder
            // 
            this.chbx_NAL_Thunder.AutoSize = true;
            this.chbx_NAL_Thunder.Location = new System.Drawing.Point(207, 509);
            this.chbx_NAL_Thunder.Name = "chbx_NAL_Thunder";
            this.chbx_NAL_Thunder.Size = new System.Drawing.Size(66, 17);
            this.chbx_NAL_Thunder.TabIndex = 0;
            this.chbx_NAL_Thunder.TabStop = false;
            this.chbx_NAL_Thunder.Text = "Thunder";
            this.chbx_NAL_Thunder.UseVisualStyleBackColor = true;
            // 
            // chbx_NAL_Atmosphere
            // 
            this.chbx_NAL_Atmosphere.AutoSize = true;
            this.chbx_NAL_Atmosphere.Location = new System.Drawing.Point(207, 533);
            this.chbx_NAL_Atmosphere.Name = "chbx_NAL_Atmosphere";
            this.chbx_NAL_Atmosphere.Size = new System.Drawing.Size(82, 17);
            this.chbx_NAL_Atmosphere.TabIndex = 0;
            this.chbx_NAL_Atmosphere.TabStop = false;
            this.chbx_NAL_Atmosphere.Text = "Atmosphere";
            this.chbx_NAL_Atmosphere.UseVisualStyleBackColor = true;
            // 
            // chbx_NAL_Hot
            // 
            this.chbx_NAL_Hot.AutoSize = true;
            this.chbx_NAL_Hot.Location = new System.Drawing.Point(296, 439);
            this.chbx_NAL_Hot.Name = "chbx_NAL_Hot";
            this.chbx_NAL_Hot.Size = new System.Drawing.Size(43, 17);
            this.chbx_NAL_Hot.TabIndex = 0;
            this.chbx_NAL_Hot.TabStop = false;
            this.chbx_NAL_Hot.Text = "Hot";
            this.chbx_NAL_Hot.UseVisualStyleBackColor = true;
            // 
            // txtbx_NAL_Hot
            // 
            this.txtbx_NAL_Hot.Location = new System.Drawing.Point(345, 436);
            this.txtbx_NAL_Hot.MaxLength = 4;
            this.txtbx_NAL_Hot.Name = "txtbx_NAL_Hot";
            this.txtbx_NAL_Hot.Size = new System.Drawing.Size(100, 20);
            this.txtbx_NAL_Hot.TabIndex = 0;
            this.txtbx_NAL_Hot.TabStop = false;
            // 
            // txtbx_NAL_Cold
            // 
            this.txtbx_NAL_Cold.Location = new System.Drawing.Point(345, 459);
            this.txtbx_NAL_Cold.MaxLength = 4;
            this.txtbx_NAL_Cold.Name = "txtbx_NAL_Cold";
            this.txtbx_NAL_Cold.Size = new System.Drawing.Size(100, 20);
            this.txtbx_NAL_Cold.TabIndex = 0;
            this.txtbx_NAL_Cold.TabStop = false;
            // 
            // chbx_NAL_Cold
            // 
            this.chbx_NAL_Cold.AutoSize = true;
            this.chbx_NAL_Cold.Location = new System.Drawing.Point(296, 462);
            this.chbx_NAL_Cold.Name = "chbx_NAL_Cold";
            this.chbx_NAL_Cold.Size = new System.Drawing.Size(47, 17);
            this.chbx_NAL_Cold.TabIndex = 0;
            this.chbx_NAL_Cold.TabStop = false;
            this.chbx_NAL_Cold.Text = "Cold";
            this.chbx_NAL_Cold.UseVisualStyleBackColor = true;
            // 
            // trayIcon
            // 
            this.trayIcon.BalloonTipTitle = "Weather Alerts";
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Weather Alerts";
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // pctbx_Line
            // 
            this.pctbx_Line.Image = global::Weather_Reminder_App.Properties.Resources.line;
            this.pctbx_Line.InitialImage = global::Weather_Reminder_App.Properties.Resources.line;
            this.pctbx_Line.Location = new System.Drawing.Point(0, 406);
            this.pctbx_Line.Name = "pctbx_Line";
            this.pctbx_Line.Size = new System.Drawing.Size(485, 3);
            this.pctbx_Line.TabIndex = 1;
            this.pctbx_Line.TabStop = false;
            // 
            // saveAlerts
            // 
            this.saveAlerts.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saveAlerts.FlatAppearance.BorderSize = 0;
            this.saveAlerts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.saveAlerts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.saveAlerts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveAlerts.Image = global::Weather_Reminder_App.Properties.Resources.EditConfirm;
            this.saveAlerts.Location = new System.Drawing.Point(387, 369);
            this.saveAlerts.Name = "saveAlerts";
            this.saveAlerts.Size = new System.Drawing.Size(25, 25);
            this.saveAlerts.TabIndex = 0;
            this.saveAlerts.TabStop = false;
            this.saveAlerts.UseVisualStyleBackColor = true;
            this.saveAlerts.Click += new System.EventHandler(this.saveAlerts_Click);
            // 
            // btn_RemoveAlerts
            // 
            this.btn_RemoveAlerts.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_RemoveAlerts.FlatAppearance.BorderSize = 0;
            this.btn_RemoveAlerts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_RemoveAlerts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_RemoveAlerts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveAlerts.Image = global::Weather_Reminder_App.Properties.Resources.DeleteAlert;
            this.btn_RemoveAlerts.Location = new System.Drawing.Point(418, 369);
            this.btn_RemoveAlerts.Name = "btn_RemoveAlerts";
            this.btn_RemoveAlerts.Size = new System.Drawing.Size(25, 25);
            this.btn_RemoveAlerts.TabIndex = 0;
            this.btn_RemoveAlerts.TabStop = false;
            this.btn_RemoveAlerts.UseVisualStyleBackColor = true;
            this.btn_RemoveAlerts.Click += new System.EventHandler(this.btn_RemoveAlerts_Click);
            // 
            // btn_SwitchUsers
            // 
            this.btn_SwitchUsers.BackColor = System.Drawing.Color.Transparent;
            this.btn_SwitchUsers.BackgroundImage = global::Weather_Reminder_App.Properties.Resources.SwitchUsers;
            this.btn_SwitchUsers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_SwitchUsers.FlatAppearance.BorderSize = 0;
            this.btn_SwitchUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_SwitchUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_SwitchUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SwitchUsers.Location = new System.Drawing.Point(12, 13);
            this.btn_SwitchUsers.Name = "btn_SwitchUsers";
            this.btn_SwitchUsers.Size = new System.Drawing.Size(36, 34);
            this.btn_SwitchUsers.TabIndex = 0;
            this.btn_SwitchUsers.TabStop = false;
            this.btn_SwitchUsers.UseVisualStyleBackColor = false;
            this.btn_SwitchUsers.Click += new System.EventHandler(this.btn_SwitchUsers_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Image = global::Weather_Reminder_App.Properties.Resources.Settings;
            this.btn_Settings.Location = new System.Drawing.Point(436, 12);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(36, 36);
            this.btn_Settings.TabIndex = 0;
            this.btn_Settings.TabStop = false;
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // btn_AddAlerts
            // 
            this.btn_AddAlerts.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_AddAlerts.FlatAppearance.BorderSize = 0;
            this.btn_AddAlerts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_AddAlerts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_AddAlerts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddAlerts.Image = global::Weather_Reminder_App.Properties.Resources.AddAlert;
            this.btn_AddAlerts.Location = new System.Drawing.Point(449, 369);
            this.btn_AddAlerts.Name = "btn_AddAlerts";
            this.btn_AddAlerts.Size = new System.Drawing.Size(25, 25);
            this.btn_AddAlerts.TabIndex = 0;
            this.btn_AddAlerts.TabStop = false;
            this.btn_AddAlerts.UseVisualStyleBackColor = true;
            this.btn_AddAlerts.Click += new System.EventHandler(this.btn_AddAlerts_Click);
            // 
            // pctbx_WeatherIcon
            // 
            this.pctbx_WeatherIcon.Image = global::Weather_Reminder_App.Properties.Resources.Error;
            this.pctbx_WeatherIcon.InitialImage = global::Weather_Reminder_App.Properties.Resources.Error;
            this.pctbx_WeatherIcon.Location = new System.Drawing.Point(71, 50);
            this.pctbx_WeatherIcon.Name = "pctbx_WeatherIcon";
            this.pctbx_WeatherIcon.Size = new System.Drawing.Size(111, 99);
            this.pctbx_WeatherIcon.TabIndex = 0;
            this.pctbx_WeatherIcon.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 575);
            this.Controls.Add(this.pctbx_Line);
            this.Controls.Add(this.txtbx_NAL_Cold);
            this.Controls.Add(this.chbx_NAL_Cold);
            this.Controls.Add(this.txtbx_NAL_Hot);
            this.Controls.Add(this.chbx_NAL_Hot);
            this.Controls.Add(this.chbx_NAL_Atmosphere);
            this.Controls.Add(this.chbx_NAL_Thunder);
            this.Controls.Add(this.chbx_NAL_Snow);
            this.Controls.Add(this.chbx_NAL_Rain);
            this.Controls.Add(this.chbx_NAL_All);
            this.Controls.Add(this.cmbx_NAL_Time);
            this.Controls.Add(this.txtbx_NAL_Time);
            this.Controls.Add(this.txtbx_NAL_Name);
            this.Controls.Add(this.saveAlerts);
            this.Controls.Add(this.btn_RemoveAlerts);
            this.Controls.Add(this.lbl_AlertConditions);
            this.Controls.Add(this.lbl_AlertTime);
            this.Controls.Add(this.lbl_AlertName);
            this.Controls.Add(this.pnl_Settings);
            this.Controls.Add(this.btn_SwitchUsers);
            this.Controls.Add(this.btn_Settings);
            this.Controls.Add(this.btn_AddAlerts);
            this.Controls.Add(this.lbl_Alerts);
            this.Controls.Add(this.lbl_DispClouds);
            this.Controls.Add(this.lbl_LCloud);
            this.Controls.Add(this.lbl_DispWindDir);
            this.Controls.Add(this.lbl_DispWindSp);
            this.Controls.Add(this.lbl_DispHumidity);
            this.Controls.Add(this.lbl_DispCoords);
            this.Controls.Add(this.lbl_LWindDir);
            this.Controls.Add(this.lbl_LWindSp);
            this.Controls.Add(this.lbl_DispMinTemp);
            this.Controls.Add(this.lbl_DispMaxTemp);
            this.Controls.Add(this.lbl_LMinTemp);
            this.Controls.Add(this.lbl_LMaxTemp);
            this.Controls.Add(this.lbl_LCoords);
            this.Controls.Add(this.lbl_LHumidity);
            this.Controls.Add(this.lbl_DispGenWeather);
            this.Controls.Add(this.lbl_DispTemp);
            this.Controls.Add(this.pctbx_WeatherIcon);
            this.Controls.Add(this.lbl_DispLoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Weather Alerts";
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.pnl_Settings.ResumeLayout(false);
            this.pnl_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_Line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_WeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DispLoc;
        private System.Windows.Forms.PictureBox pctbx_WeatherIcon;
        private System.Windows.Forms.Label lbl_DispTemp;
        private System.Windows.Forms.Label lbl_DispGenWeather;
        private System.Windows.Forms.Label lbl_LHumidity;
        private System.Windows.Forms.Label lbl_LCoords;
        private System.Windows.Forms.Label lbl_LMaxTemp;
        private System.Windows.Forms.Label lbl_LMinTemp;
        private System.Windows.Forms.Label lbl_DispMaxTemp;
        private System.Windows.Forms.Label lbl_DispMinTemp;
        private System.Windows.Forms.Label lbl_LWindSp;
        private System.Windows.Forms.Label lbl_LWindDir;
        private System.Windows.Forms.Label lbl_DispCoords;
        private System.Windows.Forms.Label lbl_DispHumidity;
        private System.Windows.Forms.Label lbl_DispWindSp;
        private System.Windows.Forms.Label lbl_DispWindDir;
        private System.Windows.Forms.Label lbl_LCloud;
        private System.Windows.Forms.Label lbl_DispClouds;
        private System.Windows.Forms.Label lbl_Alerts;
        private System.Windows.Forms.Button btn_AddAlerts;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Panel pnl_Settings;
        private System.Windows.Forms.Label lbl_Settings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_SettEmail;
        private System.Windows.Forms.Label lbl_LSettEmail;
        private System.Windows.Forms.TextBox txtbx_SettLoc;
        private System.Windows.Forms.Label lbl_LSettLoc;
        private System.Windows.Forms.TextBox txtbx_SettUser;
        private System.Windows.Forms.Label lbl_SettUser;
        private System.Windows.Forms.CheckBox chbx_Desktop;
        private System.Windows.Forms.CheckBox chbx_Email;
        private System.Windows.Forms.CheckBox chbx_Both;
        private System.Windows.Forms.Button btn_SaveSett;
        private System.Windows.Forms.Button btn_SwitchUsers;
        private System.Windows.Forms.Label lbl_AlertName;
        private System.Windows.Forms.Label lbl_AlertTime;
        private System.Windows.Forms.Label lbl_AlertConditions;
        private System.Windows.Forms.Button btn_RemoveAlerts;
        private System.Windows.Forms.Button saveAlerts;
        private System.Windows.Forms.TextBox txtbx_NAL_Name;
        private System.Windows.Forms.TextBox txtbx_NAL_Time;
        private System.Windows.Forms.ComboBox cmbx_NAL_Time;
        private System.Windows.Forms.CheckBox chbx_NAL_All;
        private System.Windows.Forms.CheckBox chbx_NAL_Rain;
        private System.Windows.Forms.CheckBox chbx_NAL_Snow;
        private System.Windows.Forms.CheckBox chbx_NAL_Thunder;
        private System.Windows.Forms.CheckBox chbx_NAL_Atmosphere;
        private System.Windows.Forms.CheckBox chbx_NAL_Hot;
        private System.Windows.Forms.TextBox txtbx_NAL_Hot;
        private System.Windows.Forms.TextBox txtbx_NAL_Cold;
        private System.Windows.Forms.CheckBox chbx_NAL_Cold;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.PictureBox pctbx_Line;
    }
}

