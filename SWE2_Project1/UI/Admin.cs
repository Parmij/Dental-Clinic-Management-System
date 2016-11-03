using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWE2_Project1.Classes;
using System.Media;
//using SWE2_Project1.UI;
using System.Reflection;

namespace SWE2_Project1
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            pnlAddRecp.Visible = true;
            btnAddUser.BackgroundImage = Image.FromFile(@"..\..\Resources\checked.jpg");
            btnDeleteUser.BackgroundImage = Image.FromFile(@"..\..\Resources\unChecked.jpg");
            btnGetReport.BackgroundImage = Image.FromFile(@"..\..\Resources\unChecked.jpg");
            //(System.Environment.GetFolderPath
            //(System.Environment.SpecialFolder.Personal)
   
            //btnAddUser.BackColor = Color.Azure;
        }

    

        private void btnCancelAddUser_Click(object sender, EventArgs e)
        {
            clear();
            
        }

        private void clear()
        {
            rbAdmin.Checked = false;
            rbDoctor.Checked = false;
            rbReceptionist.Checked = false;
            txtUserName.Text = string.Empty;
            txtUserPassword.Text = string.Empty;
        }

        private void btnSaveAddUser_Click(object sender, EventArgs e)
        {
            AddUser addNewUser = new AddUser();
            string userType = string.Empty;
            if (rbReceptionist.Checked == true)
            {
                userType = "Receptionist";
                string tmp = addNewUser.addRecep(txtRecName.Text, txtRecMobile.Text, txtRecAdress.Text, txtRecEmail.Text, txtRecPhone.Text);
                if (!tmp.Equals("Done"))
                    label4.Text = tmp;
            }
            else if (rbDoctor.Checked == true)
                userType = "Doctor";
            else if (rbAdmin.Checked == true)
                userType = "Admin";
            else
            {
                label4.Text = "You should to select User Type";
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtUserName.Text) && !string.IsNullOrWhiteSpace(txtUserPassword.Text))
            {
                if (ConnectionXML.addUser(userType, txtUserName.Text, txtUserPassword.Text))
                {
                    clear();
                    SystemSounds.Asterisk.Play();
                }
                else
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Big Error", "Error");
                }
            }
            else
            {
                label4.Text = "You should to fill user name and password fields";
                return;
            }

        }

        private void rbDoctor_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = string.Empty;
        }

        private void rbReceptionist_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = string.Empty;
        }

        private void rbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = string.Empty;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            label4.Text = string.Empty;
        }

        private void txtUserPassword_TextChanged(object sender, EventArgs e)
        {
            label4.Text = string.Empty;
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            pnlAddRecp.Visible = false;
            //btnGetReport.BackColor = Color.Azure;
            btnAddUser.BackgroundImage = Image.FromFile(@"..\..\Resources\unChecked.jpg");
            btnDeleteUser.BackgroundImage = Image.FromFile(@"..\..\Resources\unChecked.jpg");
            btnGetReport.BackgroundImage = Image.FromFile(@"..\..\Resources\checked.jpg");
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            pnlAddRecp.Visible = false;
            //btnDeleteUser.BackColor = Color.Azure;
            btnAddUser.BackgroundImage = Image.FromFile(@"..\..\Resources\unChecked.jpg");
            btnGetReport.BackgroundImage = Image.FromFile(@"..\..\Resources\unChecked.jpg");
            btnDeleteUser.BackgroundImage = Image.FromFile(@"..\..\Resources\checked.jpg");

        }

        private void rbDoctor_CheckedChanged_1(object sender, EventArgs e)
        {
            pnlAddDoc.Visible = true;
            pnlAddRecp.Visible = false;
            pnlParentInfo.Visible = true;
        }

        private void rbReceptionist_CheckedChanged_1(object sender, EventArgs e)
        {
            pnlAddDoc.Visible = false;
            pnlAddRecp.Visible = true;
            pnlParentInfo.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            pnlParentInfo.Visible = false;
            rbAdmin.Checked = true;
        }

        private void rbAdmin_CheckedChanged_1(object sender, EventArgs e)
        {
            pnlParentInfo.Visible = false;
        }

    }
}
