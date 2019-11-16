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
            this.label1 = new System.Windows.Forms.Label();
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
            this.btn_SwitchUsers = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_EditAlerts = new System.Windows.Forms.Button();
            this.pctbx_WeatherIcon = new System.Windows.Forms.PictureBox();
            this.pnl_Settings.SuspendLayout();
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
            this.lbl_LHumidity.Location = new System.Drawing.Point(90, 258);
            this.lbl_LHumidity.Name = "lbl_LHumidity";
            this.lbl_LHumidity.Size = new System.Drawing.Size(50, 13);
            this.lbl_LHumidity.TabIndex = 0;
            this.lbl_LHumidity.Text = "Humidity:";
            // 
            // lbl_LCoords
            // 
            this.lbl_LCoords.AutoSize = true;
            this.lbl_LCoords.Location = new System.Drawing.Point(90, 228);
            this.lbl_LCoords.Name = "lbl_LCoords";
            this.lbl_LCoords.Size = new System.Drawing.Size(66, 13);
            this.lbl_LCoords.TabIndex = 0;
            this.lbl_LCoords.Text = "Coordinates:";
            // 
            // lbl_LMaxTemp
            // 
            this.lbl_LMaxTemp.AutoSize = true;
            this.lbl_LMaxTemp.Location = new System.Drawing.Point(140, 170);
            this.lbl_LMaxTemp.Name = "lbl_LMaxTemp";
            this.lbl_LMaxTemp.Size = new System.Drawing.Size(30, 13);
            this.lbl_LMaxTemp.TabIndex = 0;
            this.lbl_LMaxTemp.Text = "Max:";
            // 
            // lbl_LMinTemp
            // 
            this.lbl_LMinTemp.AutoSize = true;
            this.lbl_LMinTemp.Location = new System.Drawing.Point(249, 170);
            this.lbl_LMinTemp.Name = "lbl_LMinTemp";
            this.lbl_LMinTemp.Size = new System.Drawing.Size(27, 13);
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
            this.lbl_LWindSp.Location = new System.Drawing.Point(90, 288);
            this.lbl_LWindSp.Name = "lbl_LWindSp";
            this.lbl_LWindSp.Size = new System.Drawing.Size(69, 13);
            this.lbl_LWindSp.TabIndex = 0;
            this.lbl_LWindSp.Text = "Wind Speed:";
            // 
            // lbl_LWindDir
            // 
            this.lbl_LWindDir.AutoSize = true;
            this.lbl_LWindDir.Location = new System.Drawing.Point(235, 288);
            this.lbl_LWindDir.Name = "lbl_LWindDir";
            this.lbl_LWindDir.Size = new System.Drawing.Size(52, 13);
            this.lbl_LWindDir.TabIndex = 0;
            this.lbl_LWindDir.Text = "Direction:";
            // 
            // lbl_DispCoords
            // 
            this.lbl_DispCoords.AutoSize = true;
            this.lbl_DispCoords.Location = new System.Drawing.Point(165, 228);
            this.lbl_DispCoords.Name = "lbl_DispCoords";
            this.lbl_DispCoords.Size = new System.Drawing.Size(52, 13);
            this.lbl_DispCoords.TabIndex = 0;
            this.lbl_DispCoords.Text = "(ERROR)";
            // 
            // lbl_DispHumidity
            // 
            this.lbl_DispHumidity.AutoSize = true;
            this.lbl_DispHumidity.Location = new System.Drawing.Point(165, 258);
            this.lbl_DispHumidity.Name = "lbl_DispHumidity";
            this.lbl_DispHumidity.Size = new System.Drawing.Size(52, 13);
            this.lbl_DispHumidity.TabIndex = 0;
            this.lbl_DispHumidity.Text = "(ERROR)";
            // 
            // lbl_DispWindSp
            // 
            this.lbl_DispWindSp.AutoSize = true;
            this.lbl_DispWindSp.Location = new System.Drawing.Point(165, 288);
            this.lbl_DispWindSp.Name = "lbl_DispWindSp";
            this.lbl_DispWindSp.Size = new System.Drawing.Size(52, 13);
            this.lbl_DispWindSp.TabIndex = 0;
            this.lbl_DispWindSp.Text = "(ERROR)";
            // 
            // lbl_DispWindDir
            // 
            this.lbl_DispWindDir.AutoSize = true;
            this.lbl_DispWindDir.Location = new System.Drawing.Point(293, 288);
            this.lbl_DispWindDir.Name = "lbl_DispWindDir";
            this.lbl_DispWindDir.Size = new System.Drawing.Size(52, 13);
            this.lbl_DispWindDir.TabIndex = 0;
            this.lbl_DispWindDir.Text = "(ERROR)";
            // 
            // lbl_LCloud
            // 
            this.lbl_LCloud.AutoSize = true;
            this.lbl_LCloud.Location = new System.Drawing.Point(90, 318);
            this.lbl_LCloud.Name = "lbl_LCloud";
            this.lbl_LCloud.Size = new System.Drawing.Size(42, 13);
            this.lbl_LCloud.TabIndex = 0;
            this.lbl_LCloud.Text = "Clouds:";
            // 
            // lbl_DispClouds
            // 
            this.lbl_DispClouds.AutoSize = true;
            this.lbl_DispClouds.Location = new System.Drawing.Point(165, 318);
            this.lbl_DispClouds.Name = "lbl_DispClouds";
            this.lbl_DispClouds.Size = new System.Drawing.Size(52, 13);
            this.lbl_DispClouds.TabIndex = 0;
            this.lbl_DispClouds.Text = "(ERROR)";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alerts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pnl_Settings.Size = new System.Drawing.Size(180, 586);
            this.pnl_Settings.TabIndex = 0;
            // 
            // btn_SaveSett
            // 
            this.btn_SaveSett.Location = new System.Drawing.Point(3, 516);
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
            // btn_SwitchUsers
            // 
            this.btn_SwitchUsers.BackColor = System.Drawing.Color.Transparent;
            this.btn_SwitchUsers.BackgroundImage = global::Weather_Reminder_App.Properties.Resources.group_profile_users_icon_icons_com_73540;
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
            this.btn_Settings.Image = global::Weather_Reminder_App.Properties.Resources.Settings_Icon;
            this.btn_Settings.Location = new System.Drawing.Point(436, 12);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(36, 36);
            this.btn_Settings.TabIndex = 0;
            this.btn_Settings.TabStop = false;
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // btn_EditAlerts
            // 
            this.btn_EditAlerts.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_EditAlerts.FlatAppearance.BorderSize = 0;
            this.btn_EditAlerts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_EditAlerts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_EditAlerts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditAlerts.Image = global::Weather_Reminder_App.Properties.Resources.edit_dots_symbol_small;
            this.btn_EditAlerts.Location = new System.Drawing.Point(449, 377);
            this.btn_EditAlerts.Name = "btn_EditAlerts";
            this.btn_EditAlerts.Size = new System.Drawing.Size(23, 39);
            this.btn_EditAlerts.TabIndex = 0;
            this.btn_EditAlerts.TabStop = false;
            this.btn_EditAlerts.UseVisualStyleBackColor = true;
            // 
            // pctbx_WeatherIcon
            // 
            this.pctbx_WeatherIcon.Image = global::Weather_Reminder_App.Properties.Resources.small_icon;
            this.pctbx_WeatherIcon.InitialImage = global::Weather_Reminder_App.Properties.Resources.Large_W11;
            this.pctbx_WeatherIcon.Location = new System.Drawing.Point(71, 50);
            this.pctbx_WeatherIcon.Name = "pctbx_WeatherIcon";
            this.pctbx_WeatherIcon.Size = new System.Drawing.Size(99, 92);
            this.pctbx_WeatherIcon.TabIndex = 1;
            this.pctbx_WeatherIcon.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 611);
            this.Controls.Add(this.pnl_Settings);
            this.Controls.Add(this.btn_SwitchUsers);
            this.Controls.Add(this.btn_Settings);
            this.Controls.Add(this.btn_EditAlerts);
            this.Controls.Add(this.label1);
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
            this.Text = "MainWindow";
            this.pnl_Settings.ResumeLayout(false);
            this.pnl_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_WeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_EditAlerts;
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
    }
}

