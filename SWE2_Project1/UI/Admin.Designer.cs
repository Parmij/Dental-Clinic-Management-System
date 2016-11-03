namespace SWE2_Project1
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.btnGetReport = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlAddRecp = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRecEmail = new System.Windows.Forms.TextBox();
            this.txtRecMobile = new System.Windows.Forms.TextBox();
            this.txtRecPhone = new System.Windows.Forms.TextBox();
            this.txtRecAdress = new System.Windows.Forms.TextBox();
            this.txtRecName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelAddUser = new System.Windows.Forms.Button();
            this.btnSaveAddUser = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.pnlParentInfo = new System.Windows.Forms.Panel();
            this.rbReceptionist = new System.Windows.Forms.RadioButton();
            this.rbDoctor = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pnlAddDoc = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlAddRecp.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlParentInfo.SuspendLayout();
            this.pnlAddDoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetReport
            // 
            this.btnGetReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetReport.BackgroundImage")));
            this.btnGetReport.Location = new System.Drawing.Point(12, 45);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(75, 43);
            this.btnGetReport.TabIndex = 0;
            this.btnGetReport.Text = "Get Report";
            this.btnGetReport.UseVisualStyleBackColor = true;
            this.btnGetReport.Click += new System.EventHandler(this.btnGetReport_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteUser.BackgroundImage")));
            this.btnDeleteUser.Location = new System.Drawing.Point(174, 45);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(75, 43);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rbReceptionist);
            this.panel1.Controls.Add(this.rbDoctor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rbAdmin);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.txtUserPassword);
            this.panel1.Controls.Add(this.pnlParentInfo);
            this.panel1.Controls.Add(this.btnSaveAddUser);
            this.panel1.Controls.Add(this.btnCancelAddUser);
            this.panel1.Location = new System.Drawing.Point(12, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 591);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlAddRecp
            // 
            this.pnlAddRecp.Controls.Add(this.label9);
            this.pnlAddRecp.Controls.Add(this.label8);
            this.pnlAddRecp.Controls.Add(this.label7);
            this.pnlAddRecp.Controls.Add(this.label6);
            this.pnlAddRecp.Controls.Add(this.label5);
            this.pnlAddRecp.Controls.Add(this.txtRecEmail);
            this.pnlAddRecp.Controls.Add(this.txtRecMobile);
            this.pnlAddRecp.Controls.Add(this.txtRecPhone);
            this.pnlAddRecp.Controls.Add(this.txtRecAdress);
            this.pnlAddRecp.Controls.Add(this.txtRecName);
            this.pnlAddRecp.Controls.Add(this.label4);
            this.pnlAddRecp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddRecp.Location = new System.Drawing.Point(0, 0);
            this.pnlAddRecp.Name = "pnlAddRecp";
            this.pnlAddRecp.Size = new System.Drawing.Size(1169, 376);
            this.pnlAddRecp.TabIndex = 0;
            this.pnlAddRecp.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(126, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "E-mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Mobile Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Name";
            // 
            // txtRecEmail
            // 
            this.txtRecEmail.Location = new System.Drawing.Point(240, 222);
            this.txtRecEmail.Name = "txtRecEmail";
            this.txtRecEmail.Size = new System.Drawing.Size(246, 20);
            this.txtRecEmail.TabIndex = 16;
            // 
            // txtRecMobile
            // 
            this.txtRecMobile.Location = new System.Drawing.Point(240, 170);
            this.txtRecMobile.Name = "txtRecMobile";
            this.txtRecMobile.Size = new System.Drawing.Size(246, 20);
            this.txtRecMobile.TabIndex = 15;
            // 
            // txtRecPhone
            // 
            this.txtRecPhone.Location = new System.Drawing.Point(240, 126);
            this.txtRecPhone.Name = "txtRecPhone";
            this.txtRecPhone.Size = new System.Drawing.Size(246, 20);
            this.txtRecPhone.TabIndex = 14;
            // 
            // txtRecAdress
            // 
            this.txtRecAdress.Location = new System.Drawing.Point(240, 76);
            this.txtRecAdress.Name = "txtRecAdress";
            this.txtRecAdress.Size = new System.Drawing.Size(246, 20);
            this.txtRecAdress.TabIndex = 13;
            // 
            // txtRecName
            // 
            this.txtRecName.Location = new System.Drawing.Point(240, 29);
            this.txtRecName.Name = "txtRecName";
            this.txtRecName.Size = new System.Drawing.Size(246, 20);
            this.txtRecName.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 11;
            // 
            // btnCancelAddUser
            // 
            this.btnCancelAddUser.Location = new System.Drawing.Point(858, 526);
            this.btnCancelAddUser.Name = "btnCancelAddUser";
            this.btnCancelAddUser.Size = new System.Drawing.Size(75, 29);
            this.btnCancelAddUser.TabIndex = 10;
            this.btnCancelAddUser.Text = "Cancel";
            this.btnCancelAddUser.UseVisualStyleBackColor = true;
            this.btnCancelAddUser.Click += new System.EventHandler(this.btnCancelAddUser_Click);
            // 
            // btnSaveAddUser
            // 
            this.btnSaveAddUser.Location = new System.Drawing.Point(777, 526);
            this.btnSaveAddUser.Name = "btnSaveAddUser";
            this.btnSaveAddUser.Size = new System.Drawing.Size(75, 29);
            this.btnSaveAddUser.TabIndex = 9;
            this.btnSaveAddUser.Text = "Save";
            this.btnSaveAddUser.UseVisualStyleBackColor = true;
            this.btnSaveAddUser.Click += new System.EventHandler(this.btnSaveAddUser_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1344, 29);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(104, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddUser.BackgroundImage")));
            this.btnAddUser.Location = new System.Drawing.Point(93, 45);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 43);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // pnlParentInfo
            // 
            this.pnlParentInfo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlParentInfo.Controls.Add(this.pnlAddDoc);
            this.pnlParentInfo.Controls.Add(this.pnlAddRecp);
            this.pnlParentInfo.Location = new System.Drawing.Point(146, 37);
            this.pnlParentInfo.Name = "pnlParentInfo";
            this.pnlParentInfo.Size = new System.Drawing.Size(1169, 376);
            this.pnlParentInfo.TabIndex = 22;
            // 
            // rbReceptionist
            // 
            this.rbReceptionist.AutoSize = true;
            this.rbReceptionist.Location = new System.Drawing.Point(494, 14);
            this.rbReceptionist.Name = "rbReceptionist";
            this.rbReceptionist.Size = new System.Drawing.Size(84, 17);
            this.rbReceptionist.TabIndex = 25;
            this.rbReceptionist.TabStop = true;
            this.rbReceptionist.Text = "Receptionist";
            this.rbReceptionist.UseVisualStyleBackColor = true;
            this.rbReceptionist.CheckedChanged += new System.EventHandler(this.rbReceptionist_CheckedChanged_1);
            // 
            // rbDoctor
            // 
            this.rbDoctor.AutoSize = true;
            this.rbDoctor.Location = new System.Drawing.Point(386, 14);
            this.rbDoctor.Name = "rbDoctor";
            this.rbDoctor.Size = new System.Drawing.Size(57, 17);
            this.rbDoctor.TabIndex = 24;
            this.rbDoctor.TabStop = true;
            this.rbDoctor.Text = "Doctor";
            this.rbDoctor.UseVisualStyleBackColor = true;
            this.rbDoctor.CheckedChanged += new System.EventHandler(this.rbDoctor_CheckedChanged_1);
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(275, 12);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(54, 17);
            this.rbAdmin.TabIndex = 23;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            this.rbAdmin.CheckedChanged += new System.EventHandler(this.rbAdmin_CheckedChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "User Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "User Name";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(457, 484);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(121, 20);
            this.txtUserPassword.TabIndex = 27;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(457, 441);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(121, 20);
            this.txtUserName.TabIndex = 26;
            // 
            // pnlAddDoc
            // 
            this.pnlAddDoc.Controls.Add(this.label1);
            this.pnlAddDoc.Controls.Add(this.label10);
            this.pnlAddDoc.Controls.Add(this.label11);
            this.pnlAddDoc.Controls.Add(this.label12);
            this.pnlAddDoc.Controls.Add(this.label13);
            this.pnlAddDoc.Controls.Add(this.textBox1);
            this.pnlAddDoc.Controls.Add(this.textBox2);
            this.pnlAddDoc.Controls.Add(this.textBox3);
            this.pnlAddDoc.Controls.Add(this.textBox4);
            this.pnlAddDoc.Controls.Add(this.textBox5);
            this.pnlAddDoc.Controls.Add(this.label14);
            this.pnlAddDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddDoc.Location = new System.Drawing.Point(0, 0);
            this.pnlAddDoc.Name = "pnlAddDoc";
            this.pnlAddDoc.Size = new System.Drawing.Size(1169, 376);
            this.pnlAddDoc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "E-mail";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Mobile Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(72, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Phone Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(72, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Address";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(72, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 258);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 20);
            this.textBox1.TabIndex = 27;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(186, 206);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(246, 20);
            this.textBox2.TabIndex = 26;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(186, 162);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(246, 20);
            this.textBox3.TabIndex = 25;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(186, 112);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(246, 20);
            this.textBox4.TabIndex = 24;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(186, 65);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(246, 20);
            this.textBox5.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(72, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 22;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 697);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnGetReport);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DCMS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlAddRecp.ResumeLayout(false);
            this.pnlAddRecp.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlParentInfo.ResumeLayout(false);
            this.pnlAddDoc.ResumeLayout(false);
            this.pnlAddDoc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetReport;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnlAddRecp;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnCancelAddUser;
        private System.Windows.Forms.Button btnSaveAddUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRecEmail;
        private System.Windows.Forms.TextBox txtRecMobile;
        private System.Windows.Forms.TextBox txtRecPhone;
        private System.Windows.Forms.TextBox txtRecAdress;
        private System.Windows.Forms.TextBox txtRecName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbReceptionist;
        private System.Windows.Forms.RadioButton rbDoctor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Panel pnlParentInfo;
        private System.Windows.Forms.Panel pnlAddDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label14;
    }
}

