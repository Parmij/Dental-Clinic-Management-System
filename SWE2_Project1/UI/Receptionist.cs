using SWE2_Project1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE2_Project1
{
    public partial class Receptionist : Form
    {
        public Receptionist()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAddAppoint_Click(object sender, EventArgs e)
        {
            pnlRecpAddAppoinbtn.Visible = true;
            pnlRecpAddAppon.Visible = true;
            pnlRecpAddPatient.Visible = false;
            pnlRecpDeletAppoin.Visible = false;
            pnlRecpUpdateAppoin.Visible = false;
            pnlRecpUpdatePatieInfo.Visible = false;

            dateTimePicker.Visible = true;
            cmbTimeFrom.Visible = true;
            cmbTimeTo.Visible = true;

            AddUser addNewUser = new AddUser();
            //fillSchedule(addNewUser.getAppointment());
        }

        private void fillSchedule(List<List<string>[]> tmp)
        {
            pnlParent.Controls.Clear();
            for (int i = 0; i < tmp.Count; i++)
            {
                Panel pnlAuto;
                pnlAuto = new System.Windows.Forms.Panel();
                pnlParent.Controls.Add(pnlAuto);
                pnlAuto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                pnlAuto.Dock = System.Windows.Forms.DockStyle.Top;
                pnlAuto.Name = "pnlAuto" + i;
                pnlAuto.Height = 50;

                Panel[] pnlAutoChild = new Panel[128];
                pnlAutoChild[0] = new System.Windows.Forms.Panel();
                pnlAuto.Controls.Add(pnlAutoChild[0]);
                pnlAutoChild[0].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                pnlAutoChild[0].Dock = System.Windows.Forms.DockStyle.Right;
                pnlAutoChild[0].Width = 80;

                Label lblDay;
                lblDay = new Label();
                pnlAutoChild[0].Controls.Add(lblDay);
                lblDay.Text = tmp[i][0].Last();
                lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                
                pnlAutoChild[1] = new System.Windows.Forms.Panel();
                pnlAuto.Controls.Add(pnlAutoChild[1]);
                pnlAutoChild[1].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                pnlAutoChild[1].Dock = System.Windows.Forms.DockStyle.Right;
                pnlAutoChild[1].Width = 65;

                Label lblDate;
                lblDate = new Label();
                pnlAutoChild[1].Controls.Add(lblDate);
                lblDate.Text = tmp[i][1].Last();


                TimeSpan firstTime = new TimeSpan(10, 00, 00);
                TimeSpan lastTime = new TimeSpan(21, 30, 00);
                TimeSpan timeTo = new TimeSpan(21, 30, 00);
                int j;
                for (j = 0; j < tmp[i][2].Count; j++)
                {
                    TimeSpan timeFrom = TimeSpan.Parse(tmp[i][2][j]);
                    timeTo = TimeSpan.Parse(tmp[i][3][j]);

                    int period = (int)((timeTo - timeFrom).TotalMinutes / 30) ;
                    int begin = (int)((timeFrom - firstTime).TotalMinutes / 30);

                    firstTime = timeTo;
                    while (begin-- > 0)
                    {
                        pnlAutoChild[j + 2] = new Panel();
                        pnlAuto.Controls.Add(pnlAutoChild[j + 2]);
                        pnlAutoChild[j + 2].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        pnlAutoChild[j + 2].Dock = System.Windows.Forms.DockStyle.Right;
                        pnlAutoChild[j + 2].BackColor = Color.Blue;
                        pnlAutoChild[j + 2].Size = new System.Drawing.Size(50, 48);
                    }
                    pnlAutoChild[j + 3] = new Panel();
                    pnlAuto.Controls.Add(pnlAutoChild[j + 3]);
                    pnlAutoChild[j + 3].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    pnlAutoChild[j + 3].Dock = System.Windows.Forms.DockStyle.Right;
                    pnlAutoChild[j + 3].Size = new System.Drawing.Size(50 * period, 48);
                    pnlAutoChild[j + 3].BackColor = Color.Red;

                    lblDate = new Label();
                    pnlAutoChild[j + 3].Controls.Add(lblDate);
                    lblDate.Text = tmp[i][4].Last();
                }
                int bb = (int)((lastTime - timeTo).TotalMinutes / 30);
                while (bb-- > 0)
                {
                    pnlAutoChild[++j+4] = new Panel();
                    pnlAuto.Controls.Add(pnlAutoChild[j + 4]);
                    pnlAutoChild[j+4].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    pnlAutoChild[j+4].Dock = System.Windows.Forms.DockStyle.Right;
                    pnlAutoChild[j+4].Size = new System.Drawing.Size(50, 48);
                    pnlAutoChild[j+4].BackColor = Color.Blue;
                }
            }
        }

        private void btnDeletAppoint_Click(object sender, EventArgs e)
        {
            pnlRecpAddAppoinbtn.Visible = false;
            pnlRecpAddAppon.Visible = true;
            pnlRecpAddPatient.Visible = false;
            pnlRecpDeletAppoin.Visible = true;
            pnlRecpDeletAppoin.Location = new System.Drawing.Point(750, 525);
            pnlRecpUpdateAppoin.Visible = false;
            pnlRecpUpdatePatieInfo.Visible = false;

            dateTimePicker.Visible = false;
            cmbTimeFrom.Visible = false;
            cmbTimeTo.Visible = false;
        }

        private void btnUpdateAppoint_Click(object sender, EventArgs e)
        {
            pnlRecpAddAppoinbtn.Visible = false;
            pnlRecpAddAppon.Visible = true;
            pnlRecpAddPatient.Visible = false;
            pnlRecpDeletAppoin.Visible = false;
            pnlRecpUpdateAppoin.Visible = true;
            pnlRecpUpdateAppoin.Location = new System.Drawing.Point(750, 525);
            pnlRecpUpdatePatieInfo.Visible = false;

            dateTimePicker.Visible = true;
            cmbTimeFrom.Visible = true;
            cmbTimeTo.Visible = true;
        }

        private void btnUpdatePatientInfo_Click(object sender, EventArgs e)
        {
            pnlRecpAddAppon.Visible = false;
            pnlRecpAddPatient.Visible = false;
            pnlRecpDeletAppoin.Visible = false;
            pnlRecpUpdateAppoin.Visible = false;
            pnlRecpUpdatePatieInfo.Visible = true;
            

            AddUser addNewUser = new AddUser();
            //dataGridView1.DataSource = (from r in dc.Patients select r).ToList(); 
            
            //dataGridView1.Columns["ID"].ReadOnly = true;
            //dataGridView1.Columns["Gender"].ReadOnly = true;
            //dataGridView1.Columns["Birth_Date"].ReadOnly = true;
            //dataGridView1.Columns["Pregnant"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            pnlRecpAddAppon.Visible = false;
            pnlRecpAddPatient.Visible = true;
            pnlRecpDeletAppoin.Visible = false;
            pnlRecpUpdateAppoin.Visible = false;
            pnlRecpUpdatePatieInfo.Visible = false;
        }

        private void Receptionist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.Patient' table. You can move, or remove it, as needed.
            //this.patientTableAdapter.Fill(this.dBDataSet.Patient);

            dc = new DataClassesDataContext();
            //dataGridView1.AutoGenerateColumns = true;
            //patientBindingSource.DataSource = dc;
            //patientBindingSource.DataMember = "";


            pnlRecpAddAppon.Visible = false;
            pnlRecpAddPatient.Visible = false;
            pnlRecpDeletAppoin.Visible = false;
            pnlRecpUpdateAppoin.Visible = false;
            pnlRecpUpdatePatieInfo.Visible = false;

            pnlRecpAddAppon.Size = new System.Drawing.Size(1320, 590);
            pnlRecpAddPatient.Size = new System.Drawing.Size(1320, 590);
            pnlRecpUpdatePatieInfo.Size = new System.Drawing.Size(1320, 590);

            pnlRecpAddAppon.Location = new System.Drawing.Point(10, 100);
            pnlRecpAddPatient.Location = new System.Drawing.Point(10, 100);
            pnlRecpUpdatePatieInfo.Location = new System.Drawing.Point(10, 100);



        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            rbPregnant.Enabled = false;
            rbNotPregnant.Enabled = false;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            rbPregnant.Enabled = true;
            rbNotPregnant.Enabled = true;
        }

        private void pnlRecpAddPatient_Paint(object sender, PaintEventArgs e)
        {
            rbPregnant.Enabled = false;
            rbNotPregnant.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddUser addNewUser = new AddUser();
            if (true)
            {
                string tmp = addNewUser.addPatient(txtFName.Text, txtLName.Text, txtPhone.Text, txtMobilePhone.Text, txtCity.Text, txtStreetAddress.Text, dateTimePicker1.Value.Date, txtEmail.Text, rbMale.Checked, rbPregnant.Checked);
                txtFName.Text = ""; txtLName.Text = ""; txtPhone.Text = "";
                txtMobilePhone.Text = ""; txtCity.Text = ""; txtStreetAddress.Text = "";
                txtEmail.Text = "";
            }

        }

        private void btnDeleteNewAppointment_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddNewAppointment_Click(object sender, EventArgs e)
        {
            AddUser addNewUser = new AddUser();
            addNewUser.addAppointment(int.Parse(txtPatientID.Text), 1, TimeSpan.Parse(cmbTimeFrom.Text), TimeSpan.Parse(cmbTimeTo.Text), dateTimePicker.Value.Date, dateTimePicker.Value.DayOfWeek);
        }


        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
          

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            AddUser addNewUser = new AddUser();
            if (true)
            {
                //DBDataSet.PatientDataTable
                //dataGridView1.DataSource = (addNewUser.editPatient(txtFName1.Text));
                dataGridView1.DataSource = /*patientBindingSource.DataSource =*/ (from r in dc.Patients
                                                                                  where (r.FName == txtFName1.Text)
                                                                                  select r).ToList(); //(addNewUser.editPatient(txtFName1.Text));

                //dataGridView1.Columns["ID"].ReadOnly = true;
                //dataGridView1.Columns["Gender"].ReadOnly = true;
                //dataGridView1.Columns["Birth_Date"].ReadOnly = true;
                //dataGridView1.Columns["Pregnant"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                // = new DataGridViewCheckBoxCell();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            dc.SubmitChanges();
        }

        DataClassesDataContext dc;

        private void patientBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

    }
}
