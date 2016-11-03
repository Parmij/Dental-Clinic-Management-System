namespace SWE2_Project1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.CUserType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TUserName = new System.Windows.Forms.TextBox();
            this.TUserPassword = new System.Windows.Forms.TextBox();
            this.BtLogin = new System.Windows.Forms.Button();
            this.BtCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CUserType
            // 
            this.CUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CUserType.FormattingEnabled = true;
            this.CUserType.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Receptionist"});
            this.CUserType.Location = new System.Drawing.Point(150, 100);
            this.CUserType.Name = "CUserType";
            this.CUserType.Size = new System.Drawing.Size(207, 21);
            this.CUserType.TabIndex = 0;
            this.CUserType.SelectedIndexChanged += new System.EventHandler(this.CUserType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(40, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(40, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(40, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "User Password";
            // 
            // TUserName
            // 
            this.TUserName.Location = new System.Drawing.Point(150, 150);
            this.TUserName.Name = "TUserName";
            this.TUserName.Size = new System.Drawing.Size(207, 20);
            this.TUserName.TabIndex = 4;
            // 
            // TUserPassword
            // 
            this.TUserPassword.Location = new System.Drawing.Point(150, 200);
            this.TUserPassword.Name = "TUserPassword";
            this.TUserPassword.Size = new System.Drawing.Size(207, 20);
            this.TUserPassword.TabIndex = 5;
            // 
            // BtLogin
            // 
            this.BtLogin.Location = new System.Drawing.Point(150, 295);
            this.BtLogin.Name = "btnLogin";
            this.BtLogin.Size = new System.Drawing.Size(84, 23);
            this.BtLogin.TabIndex = 6;
            this.BtLogin.Text = "Login";
            this.BtLogin.UseVisualStyleBackColor = true;
            this.BtLogin.Click += new System.EventHandler(this.btnLogin);
            // 
            // BtCancel
            // 
            this.BtCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtCancel.Location = new System.Drawing.Point(260, 295);
            this.BtCancel.Name = "BtCancel";
            this.BtCancel.Size = new System.Drawing.Size(90, 23);
            this.BtCancel.TabIndex = 7;
            this.BtCancel.Text = "Cancel";
            this.BtCancel.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AcceptButton = this.BtLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.BtCancel;
            this.ClientSize = new System.Drawing.Size(394, 331);
            this.Controls.Add(this.BtCancel);
            this.Controls.Add(this.BtLogin);
            this.Controls.Add(this.TUserPassword);
            this.Controls.Add(this.TUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CUserType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CUserType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TUserName;
        private System.Windows.Forms.TextBox TUserPassword;
        private System.Windows.Forms.Button BtLogin;
        private System.Windows.Forms.Button BtCancel;
    }
}