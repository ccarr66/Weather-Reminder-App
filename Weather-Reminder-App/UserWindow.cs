﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Reminder_App
{
    public partial class UserWindow : Form
    {
        //Select Controls
        private System.Windows.Forms.Button btn_SwitchtoCreateUser;
        private System.Windows.Forms.Button btn_SelectUser;
        private System.Windows.Forms.Label lbl_Users;
        private System.Windows.Forms.ListBox lstBx_Users;
        //Create Controls
        private System.Windows.Forms.Button btn_SwitchtoSwitchUser;
        private System.Windows.Forms.Button btn_CreateUser;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox txtbx_Username;
        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.TextBox txtbx_Location;

        private static Program.WindowMode nextMode;

        public UserWindow(Program.WindowMode mode)
        {
            nextMode = Program.WindowMode.Terminate;
            if (mode == Program.WindowMode.Create)
                initializeCreateMode();
            else
                initializeSelectMode();
        }

        public Program.WindowMode NextMode
        {
            get { return nextMode; }
        }

        private void initializeCreateMode()
        {
            foreach (Control c in this.Controls)
                c.Hide();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserWindow));
            this.btn_SwitchtoSwitchUser = new System.Windows.Forms.Button();
            this.btn_CreateUser = new System.Windows.Forms.Button();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.txtbx_Username = new System.Windows.Forms.TextBox();
            this.lbl_Location = new System.Windows.Forms.Label();
            this.txtbx_Location = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_SwitchtoSwitchUser
            // 
            this.btn_SwitchtoSwitchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SwitchtoSwitchUser.Location = new System.Drawing.Point(235, 12);
            this.btn_SwitchtoSwitchUser.Name = "btn_SwitchtoSwitchUser";
            this.btn_SwitchtoSwitchUser.Size = new System.Drawing.Size(88, 76);
            this.btn_SwitchtoSwitchUser.TabIndex = 3;
            this.btn_SwitchtoSwitchUser.Text = "Choose Existing User";
            this.btn_SwitchtoSwitchUser.UseVisualStyleBackColor = true;
            this.btn_SwitchtoSwitchUser.Click += new System.EventHandler(this.btn_SwitchtoSwitchUser_Click);
            // 
            // btn_CreateUser
            // 
            this.btn_CreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateUser.Location = new System.Drawing.Point(235, 96);
            this.btn_CreateUser.Name = "btn_CreateUser";
            this.btn_CreateUser.Size = new System.Drawing.Size(88, 76);
            this.btn_CreateUser.TabIndex = 2;
            this.btn_CreateUser.Text = "Create User";
            this.btn_CreateUser.UseVisualStyleBackColor = true;
            this.btn_CreateUser.Click += new System.EventHandler(this.btn_CreateUser_Click);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(8, 34);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(63, 24);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "Username:";
            //
            // txtbx_Username
            //
            this.txtbx_Username.Location = new System.Drawing.Point(50, 65);
            this.txtbx_Username.Name = "txtbx_Username";
            this.txtbx_Username.Size = new System.Drawing.Size(170, 20);
            this.txtbx_Username.TabIndex = 1;
            // 
            // lbl_Location
            // 
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Location.Location = new System.Drawing.Point(8, 100);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(63, 24);
            this.lbl_Location.TabIndex = 0;
            this.lbl_Location.Text = "Location(City):";
            //
            // txtbx_Username
            //
            this.txtbx_Location.Location = new System.Drawing.Point(50, 131);
            this.txtbx_Location.Name = "txtbx_Location";
            this.txtbx_Location.Size = new System.Drawing.Size(170, 20);
            this.txtbx_Location.TabIndex = 1;
            // 
            // UserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 184);
            this.Controls.Add(this.btn_SwitchtoSwitchUser);
            this.Controls.Add(this.btn_CreateUser);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.txtbx_Username);
            this.Controls.Add(this.lbl_Location);
            this.Controls.Add(this.txtbx_Location);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "User";
            this.Text = "User";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void initializeSelectMode()
        {
            foreach (Control c in this.Controls)
                c.Hide();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserWindow));
            this.btn_SwitchtoCreateUser = new System.Windows.Forms.Button();
            this.btn_SelectUser = new System.Windows.Forms.Button();
            this.lbl_Users = new System.Windows.Forms.Label();
            this.lstBx_Users = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_CreateNewUser
            // 
            this.btn_SwitchtoCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SwitchtoCreateUser.Location = new System.Drawing.Point(235, 12);
            this.btn_SwitchtoCreateUser.Name = "btn_SwitchtoCreateUser";
            this.btn_SwitchtoCreateUser.Size = new System.Drawing.Size(88, 76);
            this.btn_SwitchtoCreateUser.TabIndex = 3;
            this.btn_SwitchtoCreateUser.Text = "Create New User";
            this.btn_SwitchtoCreateUser.UseVisualStyleBackColor = true;
            this.btn_SwitchtoCreateUser.Click += new System.EventHandler(this.btn_SwitchtoCreateUser_Click);
            // 
            // btn_SelectUser
            // 
            this.btn_SelectUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectUser.Location = new System.Drawing.Point(235, 96);
            this.btn_SelectUser.Name = "btn_SelectUser";
            this.btn_SelectUser.Size = new System.Drawing.Size(88, 76);
            this.btn_SelectUser.TabIndex = 2;
            this.btn_SelectUser.Text = "Select User";
            this.btn_SelectUser.UseVisualStyleBackColor = true;
            this.btn_SelectUser.Click += new System.EventHandler(this.btn_SelectUser_Click);
            // 
            // lbl_Users
            // 
            this.lbl_Users.AutoSize = true;
            this.lbl_Users.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Users.Location = new System.Drawing.Point(8, 34);
            this.lbl_Users.Name = "lbl_Users";
            this.lbl_Users.Size = new System.Drawing.Size(63, 24);
            this.lbl_Users.TabIndex = 4;
            this.lbl_Users.Text = "Users:";
            // 
            // lstBx_Users
            // 
            this.lstBx_Users.BackColor = System.Drawing.SystemColors.Control;
            this.lstBx_Users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstBx_Users.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBx_Users.FormattingEnabled = true;
            this.lstBx_Users.ItemHeight = 24;
            this.lstBx_Users.Location = new System.Drawing.Point(71, 61);
            this.lstBx_Users.Name = "lstBx_Users";
            this.lstBx_Users.Size = new System.Drawing.Size(158, 96);
            this.lstBx_Users.TabIndex = 1;
            // 
            // UserSelectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 184);
            this.Controls.Add(this.lstBx_Users);
            this.Controls.Add(this.lbl_Users);
            this.Controls.Add(this.btn_SelectUser);
            this.Controls.Add(this.btn_SwitchtoCreateUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "User";
            this.Text = "User";
            this.ResumeLayout(false);
            this.PerformLayout();


            foreach (string s in User.UserList)
                lstBx_Users.Items.Add(s);
            lstBx_Users.SelectedIndex = 0;
        }

        private void btn_SwitchtoSwitchUser_Click(object sender, EventArgs e)
        {
            User.determineAvailableUsers();
            if (User.NumOfUsers > 0)
                initializeSelectMode();
        }

        private void btn_SwitchtoCreateUser_Click(object sender, EventArgs e)
        {
            initializeCreateMode();
        }

        private void btn_SelectUser_Click(object sender, EventArgs e)
        {
            if (lstBx_Users.SelectedIndex >= 0 && lstBx_Users.SelectedIndex < User.NumOfUsers)
            {
                User.CurrentUser = User.UserList[lstBx_Users.SelectedIndex];
                User.readUserFile();
                nextMode = Program.WindowMode.Main;
                this.Close();
            }
        }

        private void btn_CreateUser_Click(object sender, EventArgs e)
        {
            bool usrValid = validateUsername();
            bool locValid = validateLocation();
            txtbx_Username.BackColor = (usrValid) ? Color.White : Color.LightGoldenrodYellow;
            txtbx_Location.BackColor = (locValid) ? Color.White : Color.LightGoldenrodYellow;
            if (usrValid && locValid)
            {
                if (!User.saveNewUser(txtbx_Username.Text, txtbx_Location.Text))
                    return;
                User.CurrentUser = txtbx_Username.Text;
                User.UserLocation = txtbx_Location.Text;
                nextMode = Program.WindowMode.Main;
                this.Close();
            }
        }

        private bool validateUsername()
        {
            string username = txtbx_Username.Text;
            if (username.Contains("/") || username.Contains("\\") || username.Contains(":") || username.Contains("*") || username.Contains("?") || username.Contains("\\")
                || username.Contains("|") || username.Contains("<") || username.Contains(">") || username.Contains("\""))
                return false;

            foreach (string usr in User.UserList)
                if (username == usr)
                    return false;
            return true;
        }

        private bool validateLocation()
        {
            return WeatherLookup.validCity(txtbx_Location.Text);
        }
    }
}