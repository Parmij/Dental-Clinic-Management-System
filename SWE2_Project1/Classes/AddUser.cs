using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE2_Project1.Classes
{
    class AddUser
    {
        public string addRecep(string name, string mobile_No, string address, string email, string Phone_No)
        {
            DataClassesDataContext db = new DataClassesDataContext();

            var item = from s in db.Receptionists
                       select s;
            int x = 0;
            foreach (var i in item)
            {
                if (i.ID > x)
                    x = i.ID;
                if (name.Equals(i.Name))
                    return "This user is defined before!!!";
            }
            db.Receptionists.InsertOnSubmit(new Receptionist() { ID = ++x, Name = name, Mobile_No = mobile_No, Address = address, Email = email, Phone_No = Phone_No });
            try
            {
                db.SubmitChanges();
                return "Done";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        //public string addDoctor(string name, string mobile_No, string address, string email, string Phone_No)
        //{
        //    DataClassesDataContext db = new DataClassesDataContext();

        //    var item = from s in db.Doctors
        //               select s;
        //    int x = 0;
        //    foreach (var i in item)
        //    {
        //        if (i.ID > x)
        //            x = i.ID;
        //        if (name.Equals(i.Name))
        //            return "This user is defined before!!!";
        //    }
        //    db.Doctors.InsertOnSubmit(new Doctor() { ID = ++x, Name = name, Mobile_No = mobile_No, Address = address, Email = email, Phone_No = Phone_No });
        //    try
        //    {
        //        db.SubmitChanges();
        //        return "Done";
        //    }
        //    catch (Exception e)
        //    {
        //        return e.ToString();
        //    }
        //}


        /**
         * Add Patient
         */
        public string addPatient(string fName, string lName, string phone, string mobilePhone, string city, string streetAddress, DateTime dob, string email, bool gender, bool pregnant)
        {
            DataClassesDataContext db = new DataClassesDataContext();

            var item = from s in db.Patients
                       select s;
            int x = 0;
            foreach (var i in item)
            {
                if (i.ID > x)
                    x = i.ID;
                if (fName.Equals(i.FName) && lName.Equals(i.LName))
                    return "This patient is defined before!!!";
            }
            db.Patients.InsertOnSubmit(new Patient {ID = ++x, FName = fName, LName = lName, City = city, Phone_No = phone, Mobile_No = mobilePhone, Street = streetAddress, Birth_Date = dob, Email = email, Gender = gender, Pregnant = pregnant});
            try
            {
                db.SubmitChanges();
                return "Done";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public List<List<string>[]> getAppointment()
        {
            DataClassesDataContext db = new DataClassesDataContext();

            //db.Appointments[] a = new db.Appointments();
            //DataClassesDataContext[] ff= db.Appointments;
            //IEnumerable<IGrouping<int, string >> outerSequence =
            var outerSequence = 
                db.Appointments.GroupBy(o => o.Date);

            
            List<List<string>[]> tmp = new List<List<string>[]>();
            //tmp[0] = new List<string>();
            //tmp[1] = new List<string>();

            foreach (var i in outerSequence)
            {
                List<string>[] tmp1 = new List<string>[5];
                tmp1[0] = new List<string>();
                tmp1[1] = new List<string>();
                tmp1[2] = new List<string>();
                tmp1[3] = new List<string>();
                tmp1[4] = new List<string>();
                
                foreach (var j in i)
                {
                    tmp1[0].Add(j.Day);
                    tmp1[1].Add(j.Date.ToString());
                    tmp1[2].Add(j.TimeFrom.ToString());
                    tmp1[3].Add(j.TimeTo.ToString());

                    var item = from s in db.Patients
                                where s.ID == j.Patient_ID
                                select s;
                    foreach (var ss in item)
                    {
                        tmp1[4].Add(ss.FName + " " + ss.LName);  
                    }
                    
                }
                tmp.Add(tmp1);
                //tmp.Add
                //tmp[0].Add(i.TimeFrom);
                //tmp[1].Add(i.TimeTo);
            }
            return tmp;
        }

        public string addAppointment(int patientID, int receptionist, TimeSpan timeFrom, TimeSpan timeTo, DateTime date, DayOfWeek day)
        {
            DataClassesDataContext db = new DataClassesDataContext();

            

            var item = from s in db.Appointments
                       select s;
            int x = 0;
            
            foreach (var i in item)
            {
                if (i.ID > x)
                    x = i.ID;
                //if (fName.Equals(i.Name))
                //    return "This patient is defined before!!!";
            }
            db.Appointments.InsertOnSubmit(new Appointment { ID = ++x, Patient_ID = patientID, Receptionist_ID = receptionist, TimeFrom = timeFrom, TimeTo = timeTo, Date = date, Day = day.ToString() });
            try
            {
                db.SubmitChanges();
                return "Done";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public BindingSource editPatient(string fName)
        {
            DataClassesDataContext db = new DataClassesDataContext();

            List<Patient> item1 = (from s in db.Patients 
                                  where s.FName == fName
                                   select s).AsEnumerable().Cast<Patient>().ToList();
                                  

            Patient item = db.Patients.Single(c => c.ID == 1);



            //BindingSource bindingSource1 = new BindingSource();
            BindingSource b = new BindingSource();
            //d = new DataGridView();
            b.DataSource = (from r in db.Patients
                                         where (r.FName == fName)
                            select r).ToList();

            //d.DataSource = b;


            //DBDataSetTableAdapters.PatientTableAdapter s =  db.Patients(item);
            //int x = 0;

            //foreach (var i in item)
            //{
            //    if (i.ID > x)
            //        x = i.ID;
            //    if (fName.Equals(i.Name))
            //        return "This patient is defined before!!!";
            //}
            //db.Patients.InsertOnSubmit(new Parallel { ID = ++x, Patient_ID = patientID, Receptionist_ID = receptionist, TimeFrom = timeFrom, TimeTo = timeTo, Date = date, Day = day.ToString() });
            try
            {
                db.SubmitChanges();
                return b;//(DBDataSetTableAdapters.PatientTableAdapter)item;
            }
            catch (Exception e)
            {
                ;// return e.Message;
            }
            return b;
        }

    }
}
