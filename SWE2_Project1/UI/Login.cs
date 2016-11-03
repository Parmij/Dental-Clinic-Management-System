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

namespace SWE2_Project1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin(object sender, EventArgs e)
        {
            if (ConnectionXML.Load_xml(CUserType.Text,TUserName.Text ,TUserPassword.Text) == false)
            {
                MessageBox.Show("Error");
                TUserName.Text = "";
                TUserPassword.Text = "";
                //this.ActiveControl = TUserName;
                TUserName.Select();
            }
            else if(CUserType.Text=="Receptionist")
            { 
                this.Hide();
                Receptionist f2 = new Receptionist();
                f2.ShowDialog();
            }
            else if (CUserType.Text == "Doctor")
            {
                this.Hide();
                Doctor f2 = new Doctor();
                f2.ShowDialog();
            }
            else 
            {
                this.Hide();
                Admin f2 = new Admin();
                f2.ShowDialog();
            }
        }

        private void LoginLoad(object sender, EventArgs e)
        {
            CUserType.SelectedIndex = 0;
        }

        private void CUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
