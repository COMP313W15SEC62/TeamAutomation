using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AsmaraClinic
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("data source=.; database = AsmaraClinic; integrated security = SSPI");
       
        public Form1()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
           // btnAdd.Enabled = false;

            sqlCommand1.CommandText = @" insert into Patient(PatientID, FName, LName, Street, City, Province, PostalCode, PhoneNumber, Email, OhipCard, StaffID) 
            values('" +int.Parse(txtID.Text.Trim())+ "', '" +txtFName.Text.Trim()+ "', '" +txtLName.Text.Trim()+ "', '" +txtStreet.Text.Trim()+ "', '" +txtCity.Text.Trim()+ "', '" +txtProvince.Text.Trim()+ "', '" +txtPostalCode.Text.Trim()+ "', '" +txtPhone.Text.Trim()+ "', '" +txtEmail.Text.Trim()+ "', '" +txtOhip.Text.Trim()+ "', '" +int.Parse(txtStaffID.Text.Trim())+ "')";

            sqlConnection1.Open();
            sqlCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
            MessageBox.Show("Patient Added Successfully");
        }
        private void btnViewPatient_Click(object sender, EventArgs e)
        {
            con.Open();
            String st = "Select * from Patient where PatientID='" + int.Parse(txtID.Text.Trim()) + "' ";
            SqlCommand com = new SqlCommand(st, con);

            SqlDataReader rd = com.ExecuteReader();

            while (rd.Read())
            {
                String id = rd.GetInt32(0).ToString();
                String fname = rd.GetString(1);
                String lname = rd.GetString(2);
                String street = rd.GetString(3);
                String city = rd.GetString(4);
                String province = rd.GetString(5);
                String pCode = rd.GetString(6);
                String phone = rd.GetString(7);
                String email = rd.GetString(8);
                String ohip = rd.GetString(9);
                String staffId = rd.GetInt32(10).ToString();

                txtID.Text = id; txtFName.Text = fname; txtLName.Text = lname; txtStreet.Text = street;
                txtCity.Text = city; txtProvince.Text = province; txtPostalCode.Text = pCode;
                txtPhone.Text = phone; txtEmail.Text = email; txtOhip.Text = ohip; txtStaffID.Text = staffId;
            }
            con.Close();
            MessageBox.Show("Patient Info Viewed Successfully");
        }
        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            con.Open();
            String st = "update Patient set PatientID='" + int.Parse(txtID.Text.Trim()) + "', FName= '" + txtFName.Text.Trim() + "', LName= '" + txtLName.Text.Trim() + "', Street= '" + txtStreet.Text.Trim() + "', City= '" + txtCity.Text.Trim() + "', Province= '" + txtProvince.Text.Trim() + "', PostalCode= '" + txtPostalCode.Text.Trim() + "', PhoneNumber= '" + txtPhone.Text.Trim() + "', Email= '" + txtEmail.Text.Trim() + "', OhipCard= '" + txtOhip.Text.Trim() + "', StaffID= '" + int.Parse(txtStaffID.Text.Trim()) + "' Where PatientID= '" + int.Parse(txtID.Text.Trim()) + "' ";
            SqlCommand com = new SqlCommand(st, con);
           
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Patient Info Updated Successfully");
        }
        private void cmbPatientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();

            String st = "select * from Patient where PatientID='" + int.Parse(cmbPatientID.Text.Trim()) + "' ";
            SqlCommand com = new SqlCommand(st, con);
            SqlDataReader rd = com.ExecuteReader();

            while (rd.Read())
            {
                String id = rd.GetInt32(0).ToString();
                String fname = rd.GetString(1);
                String lname = rd.GetString(2);
                String street = rd.GetString(3);
                String city = rd.GetString(4);
                String province = rd.GetString(5);
                String pCode = rd.GetString(6);
                String phone = rd.GetString(7);
                String email = rd.GetString(8);
                String ohip = rd.GetString(9);
                String staffId = rd.GetInt32(10).ToString();

                txtID.Text = id; txtFName.Text = fname; txtLName.Text = lname; txtStreet.Text = street;
                txtCity.Text = city; txtProvince.Text = province; txtPostalCode.Text = pCode;
                txtPhone.Text = phone; txtEmail.Text = email; txtOhip.Text = ohip; txtStaffID.Text = staffId;
            }
            con.Close();
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            con.Open();
            String st = "delete from Patient where PatientID='" + int.Parse(txtID.Text.Trim()) + "' ";
            SqlCommand com = new SqlCommand(st, con);

            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Patient Info Deleted Successfully");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtID.Clear(); txtFName.Clear(); txtLName.Clear(); txtStreet.Clear();
            txtCity.Clear(); txtProvince.Clear(); txtPostalCode.Clear();
            txtOhip.Clear(); txtEmail.Clear(); txtPhone.Clear(); txtStaffID.Clear();


        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            sqlCommand2.CommandText = @" insert into Staff(StaffID, FName, LName, JobTitle, HireDate, Address, PhoneNumber, Email) 
            values('" + int.Parse(txtStaffID1.Text.Trim()) + "', '" + txtSFName.Text.Trim() + "', '" + txtSLName.Text.Trim() + "', '" + txtJobTitle.Text.Trim() + "', '" + txtHireDate.Text.Trim() + "', '" + txtAddress.Text.Trim() + "', '" + txtSPhone.Text.Trim() + "', '" + txtSEmail.Text.Trim() +  "')";

            sqlConnection1.Open();
            sqlCommand2.ExecuteNonQuery();
            sqlConnection1.Close();
            MessageBox.Show("New Staff Added Successfully");
        }

        private void btnRefsresh_Click(object sender, EventArgs e)
        {
            txtStaffID1.Clear(); txtSFName.Clear(); txtSLName.Clear(); txtJobTitle.Clear();
            txtHireDate.Clear(); txtAddress.Clear();
            txtSEmail.Clear(); txtSPhone.Clear();
        }

        private void btnViewPatients_Click_1(object sender, EventArgs e)
        {
            sqlDataAdapter1.Fill(dataSet21);
        }

        private void btnAllStaff_Click(object sender, EventArgs e)
        {
            sqlDataAdapter2.Fill(dataSet61);
        }

        private void btnViewStaff_Click(object sender, EventArgs e)
        {
            con.Open();
            String st = "Select * from Staff where StaffID='" + int.Parse(txtStaffID1.Text.Trim()) + "' ";
            SqlCommand com = new SqlCommand(st, con);

            SqlDataReader rd = com.ExecuteReader();

            while (rd.Read())
            {
                String id = rd.GetInt32(0).ToString();
                String fname = rd.GetString(1);
                String lname = rd.GetString(2);
                String jobTitle = rd.GetString(3);
                String hireDate = rd.GetDateTime(4).ToString();
                String address = rd.GetString(5);
                String phone = rd.GetString(6);
                String email = rd.GetString(7);


                txtStaffID1.Text = id; txtSFName.Text = fname; txtSLName.Text = lname; txtJobTitle.Text = jobTitle;
                txtHireDate.Text = hireDate; txtAddress.Text = address;
                txtSPhone.Text = phone; txtSEmail.Text = email; 
            }
            con.Close();
        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            con.Open();
            String st = "update Staff set StaffID='" + int.Parse(txtStaffID1.Text.Trim()) + "', FName= '" + txtSFName.Text.Trim() + "', LName= '" + txtSLName.Text.Trim() + "', JobTitle= '" + txtJobTitle.Text.Trim() + "', HireDate= '" + txtHireDate.Text.Trim() + "', Address= '" + txtAddress.Text.Trim() + "', PhoneNumber= '" + txtSPhone.Text.Trim() + "', Email= '" + txtSEmail.Text.Trim() + "' Where StaffID= '" + int.Parse(txtStaffID1.Text.Trim()) + "' ";
            SqlCommand com = new SqlCommand(st, con);

            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Staff Info Updated Successfully");
        }
        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            con.Open();
            String st = "delete from Staff where StaffID='" + int.Parse(txtStaffID1.Text.Trim()) + "' ";
            SqlCommand com = new SqlCommand(st, con);

            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Staff Info Deleted Successfully");
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            sqlCommand3.CommandText = @" insert into Appointment(AppointmentID, PatientID, StaffID, TimeSlotID, Status) 
            values('" + int.Parse(txtAppointmentID.Text.Trim()) + "', '" + int.Parse(txtPatientID.Text.Trim()) + "', '" + int.Parse(txtStaffID3.Text.Trim()) + "', '" + int.Parse(txtTimeSlotID.Text.Trim()) + "', 'Active')";

            sqlConnection1.Open();
            sqlCommand3.ExecuteNonQuery();
            sqlConnection1.Close();
            MessageBox.Show("New Appointment Added Successfully");
        }

        private void btnViewAppointment_Click(object sender, EventArgs e)
        {
            con.Open();
            String st = "Select * from Appointment where AppointmentID='" + int.Parse(txtAppointmentID.Text.Trim()) + "' ";
            SqlCommand com = new SqlCommand(st, con);

            SqlDataReader rd = com.ExecuteReader();

            while (rd.Read())
            {
                String appoId = rd.GetInt32(0).ToString();
                String paId = rd.GetInt32(1).ToString();
                String staId = rd.GetInt32(2).ToString();
                String tiId = rd.GetInt32(3).ToString();
                String stat = rd.GetString(4);


                txtAppointmentID.Text = appoId; txtPatientID.Text = paId; txtStaffID3.Text = staId; txtTimeSlotID.Text = tiId; txtStatus.Text = stat;
             
            }
            con.Close();
        }

        private void btnUpdateAppointment_Click(object sender, EventArgs e)
        {
            con.Open();
            String st = "update Appointment set AppointmentID='" + int.Parse(txtAppointmentID.Text.Trim()) + "', PatientID= '" + int.Parse(txtPatientID.Text.Trim()) + "', StaffID= '" + int.Parse(txtStaffID3.Text.Trim()) + "',  TimeSlotID= '" + int.Parse(txtTimeSlotID.Text.Trim()) + "', Status='" + txtStatus.Text.Trim() + "' Where AppointmentID= '" + int.Parse(txtAppointmentID.Text.Trim()) + "' ";
            SqlCommand com = new SqlCommand(st, con);

            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Appointment Info Updated Successfully");
        }

        private void btnAppointmentRefersh_Click(object sender, EventArgs e)
        {
            txtAppointmentID.Clear(); txtPatientID.Clear(); txtStaffID3.Clear(); txtTimeSlotID.Clear(); txtStatus.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'asmaraClinicDataSet1.TimeSlotDetail' table. You can move, or remove it, as needed.
            //this.timeSlotDetailTableAdapter.Fill(this.asmaraClinicDataSet1.TimeSlotDetail);

        }

        private void btnViewSchedule_Click(object sender, EventArgs e)
        {
            sqlDataAdapter5.Fill(dataSet51);
        }

   
       private void button3_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand scm = new SqlCommand("Select PatientID from Patient ORDER BY PatientID ASC", con);
            SqlDataReader rd = scm.ExecuteReader();

            while (rd.Read())
            {
                cmbPatientID.Items.Add(rd["PatientID"]);
            }
            con.Close();
        }

       private void btnViewAppointments_Click(object sender, EventArgs e)
       {
           sqlDataAdapter6.Fill(dataSet71);
       }

      

      

       

       

      

            
    }
}
