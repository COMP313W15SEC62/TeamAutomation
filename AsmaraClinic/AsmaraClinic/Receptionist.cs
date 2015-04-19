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
    public partial class Receptionist : Form
    {
        SqlConnection con = new SqlConnection("data source=.; database = AsmaraClinic; integrated security = SSPI");
       
        public Receptionist(String username)
        {
            InitializeComponent();
            lblUser.Text = "User: " + username;
            load_StaffId();
            load_DateTime();
            load_ID();
            load_StaffID();
           dTime.Start();
           txtID.Hide(); lblID.Hide();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
           // btnAdd.Enabled = false;
            try
            {
                sqlCommand1.CommandText = @" insert into Patient(FName, LName, Street, City, Province, PostalCode, PhoneNumber, Email, OhipCard, StaffID, Status) 
            values('" + txtFName.Text.Trim() + "', '" + txtLName.Text.Trim() + "', '" + txtStreet.Text.Trim() + "', '" + txtCity.Text.Trim() + "', '" + txtProvince.Text.Trim() + "', '" + txtPostalCode.Text.Trim() + "', '" + txtPhone.Text.Trim() + "', '" + txtEmail.Text.Trim() + "', '" + txtOhip.Text.Trim() + "', '" + int.Parse(txtStaffID.Text.Trim()) + "', '" + cmbPStatus.Text.Trim() + "')";

                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                this.Refresh();
                MessageBox.Show("Patient Added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            sqlConnection1.Close();
        }

        private void btnViewPatient_Click(object sender, EventArgs e)
        {
            try
            {
                txtID.Show(); lblID.Show();

                con.Open();
                String st = "Select * from Patient where PhoneNumber='" + int.Parse(txtFindPhone.Text.Trim()) + "' ";
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
                    String status = rd.GetString(11);

                    txtID.Text = id; txtFName.Text = fname; txtLName.Text = lname; txtStreet.Text = street;
                    txtCity.Text = city; txtProvince.Text = province; txtPostalCode.Text = pCode;
                    txtPhone.Text = phone; txtEmail.Text = email; txtOhip.Text = ohip; txtStaffID.Text = staffId; cmbPStatus.Text = status;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            con.Close();
        }
       

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String st = "update Patient set  FName= '" + txtFName.Text.Trim() + "', LName= '" + txtLName.Text.Trim() + "', Street= '" + txtStreet.Text.Trim() + "', City= '" + txtCity.Text.Trim() + "', Province= '" + txtProvince.Text.Trim() + "', PostalCode= '" + txtPostalCode.Text.Trim() + "', PhoneNumber= '" + txtPhone.Text.Trim() + "', Email= '" + txtEmail.Text.Trim() + "', OhipCard= '" + txtOhip.Text.Trim() + "', StaffID= '" + int.Parse(txtStaffID.Text.Trim()) + "', Status= '" + cmbPStatus.Text.Trim() + "' Where PatientID= '" + int.Parse(txtID.Text.Trim()) + "' ";
                SqlCommand com = new SqlCommand(st, con);

                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Patient Info Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void cmbPatientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Show(); lblID.Show();

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
                String status = rd.GetString(11);

                txtID.Text = id; txtFName.Text = fname; txtLName.Text = lname; txtStreet.Text = street;
                txtCity.Text = city; txtProvince.Text = province; txtPostalCode.Text = pCode;
                txtPhone.Text = phone; txtEmail.Text = email; txtOhip.Text = ohip; txtStaffID.Text = staffId; cmbPStatus.Text = status;
            }
            con.Close();
        }

        private void btnViewPatients_Click_1(object sender, EventArgs e)
        {
            
            SqlDataAdapter sqd = new SqlDataAdapter("Select * from Patient ", con);
            DataTable dt = new DataTable();
            sqd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnActivePatients_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqd = new SqlDataAdapter("Select * from Patient where Status = 'Active'", con);
            DataTable dt = new DataTable();
            sqd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnNonActivePatients_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqd = new SqlDataAdapter("Select * from Patient where Status = 'Not Active'", con);
            DataTable dt = new DataTable();
            sqd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                txtFindPhone.Clear(); txtID.Clear(); txtFName.Clear(); txtLName.Clear(); txtStreet.Clear();
                txtCity.Clear(); txtProvince.SelectedIndex = -1; txtPostalCode.Clear(); txtFindPhone.Clear();
                txtOhip.Clear(); txtEmail.Clear(); txtPhone.Clear(); txtStaffID.SelectedIndex = -1; cmbPStatus.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCommand2.CommandText = @" insert into Staff(StaffID, FName, LName, JobTitle, HireDate, Address, PhoneNumber, Email, Status) 
            values('" + int.Parse(txtStaffID1.Text.Trim()) + "', '" + txtSFName.Text.Trim() + "', '" + txtSLName.Text.Trim() + "', '" + txtJobTitle.Text.Trim() + "', '" + DateTime.Parse(txtHireDate.Text.Trim()) + "', '" + txtAddress.Text.Trim() + "', '" + txtSPhone.Text.Trim() + "', '" + txtSEmail.Text.Trim() + "', '" + cmbStaffStatus.Text.Trim() + "')";

                sqlConnection1.Open();
                sqlCommand2.ExecuteNonQuery();
                sqlConnection1.Close();
                this.Refresh();
                MessageBox.Show("New Staff Added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection1.Close();
        }

        private void btnRefsresh_Click(object sender, EventArgs e)
        {
            try
            {
                txtStaffID1.Clear(); txtSFName.Clear(); txtSLName.Clear(); txtJobTitle.SelectedIndex = -1;
                txtFindStaff.SelectedIndex = -1; txtAddress.Clear(); txtSEmail.Clear(); txtSPhone.Clear(); cmbStaffStatus.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            
        }

       

        private void btnAllStaff_Click_1(object sender, EventArgs e)
        {
            SqlDataAdapter sqd = new SqlDataAdapter("Select * from Staff ", con);
            DataTable dt = new DataTable();
            sqd.Fill(dt);
            dataGridView2.DataSource = dt;
        }   

        private void btnActiveStaff_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqd = new SqlDataAdapter("Select * from Staff where Status = 'Active'", con);
            DataTable dt = new DataTable();
            sqd.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        
        private void cmbJobTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sqd = new SqlDataAdapter("Select * from Staff where JobTitle = '" + cmbJobTitle.Text.Trim() + "' ", con);
            DataTable dt = new DataTable();
            sqd.Fill(dt);
            dataGridView2.DataSource = dt;
        }

       
        private void btnViewStaff_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                String st = "Select * from Staff where StaffID='" + int.Parse(txtFindStaff.Text.Trim()) + "' ";
                SqlCommand com = new SqlCommand(st, con);
              //  txtStaffID1.Text = null;
                SqlDataReader rd = com.ExecuteReader();

                while (rd.Read())
                {
                    String id = rd.GetInt32(0).ToString();
                    String fname = rd.GetString(1);
                    String lname = rd.GetString(2);
                    String jobTitle = rd.GetString(3);
                    String hireDate = rd.GetDateTime (4).ToString();
                    String address = rd.GetString(5);
                    String phone = rd.GetString(6);
                    String email = rd.GetString(7);
                    String status = rd.GetString(8);


                    txtStaffID1.Text = id;  txtSFName.Text = fname; txtSLName.Text = lname; txtJobTitle.Text = jobTitle;
                    txtHireDate.Text = hireDate; txtAddress.Text = address;
                    txtSPhone.Text = phone; txtSEmail.Text = email; cmbStaffStatus.Text = status;
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String st = "update Staff set StaffID='" + int.Parse(txtStaffID1.Text.Trim()) + "', FName= '" + txtSFName.Text.Trim() + "', LName= '" + txtSLName.Text.Trim() + "', JobTitle= '" + txtJobTitle.Text.Trim() + "', HireDate= '" + DateTime.Parse(txtHireDate.Text.Trim()) + "', Address= '" + txtAddress.Text.Trim() + "', PhoneNumber= '" + txtSPhone.Text.Trim() + "', Email= '" + txtSEmail.Text.Trim() + "' , Status= '" + cmbStaffStatus.Text.Trim() + "' Where StaffID= '" + int.Parse(txtStaffID1.Text.Trim()) + "' ";
                SqlCommand com = new SqlCommand(st, con);

                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Staff Info Updated Successfully");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

      
        private void btnAddAppointment_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                //New
                String st1 = "Select * from Appointment where StaffID='" + int.Parse(txtStaffID3.Text.Trim()) + "' and DateTime = '" + DateTime.Parse(cmbTimeSlot.Text.Trim()) + "' ";
                SqlCommand com1 = new SqlCommand(st1, con);
                SqlDataReader rd = com1.ExecuteReader();

                if (rd.HasRows)
                {
                    MessageBox.Show("Duplucate booking!");
                   //rd.Close();
                   con.Close();
                }
                else
                {
//                    con.Open();
//                     st1 = @" insert into Appointment(PatientID, StaffID, DateTime, Status) 
//            values( '" + int.Parse(cmbPatientID2.Text.Trim()) + "', '" + int.Parse(txtStaffID3.Text.Trim()) + "', '" + DateTime.Parse(cmbTimeSlot.Text.Trim()) + "', 'Active')";
                    sqlCommand3.CommandText = @" insert into Appointment(PatientID, StaffID, DateTime, Status) 
                                values( '" + int.Parse(cmbPatientID2.Text.Trim()) + "', '" + int.Parse(txtStaffID3.Text.Trim()) + "', '" + DateTime.Parse(cmbTimeSlot.Text.Trim()) + "', 'Active')";

                    sqlConnection1.Open();

                    sqlCommand3.ExecuteNonQuery();

                    sqlConnection1.Close();

                    this.Refresh();
                  //  SqlCommand com = new SqlCommand(st, con);

                    //com1.ExecuteNonQuery();
                   // con.Close();
                    MessageBox.Show("New Appointment Added Successfully");

                    
                }
               con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
                
            }
                con.Close();
        }

        
        private void btnViewAppointment_Click_1(object sender, EventArgs e)
        {
            con.Open();
            String st = "Select * from Appointment where PatientID='" + int.Parse(cmbPatientID2.Text.Trim()) + "' ";
            SqlCommand com = new SqlCommand(st, con);

            SqlDataReader rd = com.ExecuteReader();

            if (rd.HasRows)
            {
                
                while (rd.Read())
                {
                    
                    String paId = rd.GetInt32(1).ToString();
                    String staId = rd.GetInt32(2).ToString();
                    String tiId = rd.GetDateTime(3).ToString();
                    String stat = rd.GetString(4);


                    cmbPatientID2.Text = paId; txtStaffID3.Text = staId; cmbTimeSlot.Text = tiId; cmbStatus.Text = stat;
                 }
              }
           
               else
                 {
                     MessageBox.Show("No appointment found for the patient!");
               
                  }
          
            con.Close();
        }

      
        private void btnUpdateAppointment_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String st = "update Appointment set PatientID= '" + int.Parse(cmbPatientID2.Text.Trim()) + "', StaffID= '" + int.Parse(txtStaffID3.Text.Trim()) + "',  DateTime= '" + DateTime.Parse(cmbTimeSlot.Text.Trim()) + "', Status='" + cmbStatus.Text.Trim() + "'  ";
                SqlCommand com = new SqlCommand(st, con);

                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Appointment Info Updated Successfully");
            }

            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            
            }
            con.Close();
        }


        private void cmbPatientID2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String Query = "Select StaffID from Patient where PatientID = '" + int.Parse(cmbPatientID2.Text) + "' ";
                 SqlCommand scm = new SqlCommand(Query, con);
                   
                SqlDataReader rd = scm.ExecuteReader();
                
                while (rd.Read())
                {
                    String staId = rd.GetInt32(0).ToString();

                    txtStaffID3.Text = staId;

                }

                con.Close();
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            try
            {
                con.Open();
                String Query = "Select DateTime from TimeSlotDetail where StaffID = '" + int.Parse(txtStaffID3.Text) + "' ";
                SqlCommand scm = new SqlCommand(Query, con);

                SqlDataReader rd = scm.ExecuteReader();

                while (rd.Read())
                {
                    cmbTimeSlot.Items.Add(rd["DateTime"]);

                }

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

      

        private void btnAppointmentRefersh_Click_1(object sender, EventArgs e)
        {
            cmbPatientID2.Text = ""; txtStaffID3.Clear(); cmbTimeSlot.Text = "" ; cmbStatus.Text = "";
        }

        private void btnViewAppointments_Click(object sender, EventArgs e)
        {
            try
            {
                //sqlDataAdapter6.Fill(dataSet91);

                SqlDataAdapter sqd = new SqlDataAdapter("Select * from Appointment ", con);
                DataTable dt = new DataTable();
                sqd.Fill(dt);
                dgrAppointment.DataSource = dt;
                // cmbStaffID3.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'asmaraClinicDataSet1.TimeSlotDetail' table. You can move, or remove it, as needed.
            //this.timeSlotDetailTableAdapter.Fill(this.asmaraClinicDataSet1.TimeSlotDetail);

        }

        private void btnViewSchedule_Click(object sender, EventArgs e)
        {

            
            try
            {
              //  sqlDataAdapter5.Fill(dataSet101);
                cmbDateTime.SelectedIndex = -1; cmbStaffID.SelectedIndex = -1;
                SqlDataAdapter sqd = new SqlDataAdapter("Select * from TimeSlotDetail ", con);
                DataTable dt = new DataTable();
                sqd.Fill(dt);
                dataGridView3.DataSource = dt;
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnIndSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                //  sqlDataAdapter5.Fill(dataSet101);
                
                    SqlDataAdapter sqd = new SqlDataAdapter("Select * from TimeSlotDetail Where StaffID = '" + int.Parse(cmbStaffID.Text.Trim()) + "'; ", con);
                    DataTable dt = new DataTable();
                    sqd.Fill(dt);
                    dataGridView3.DataSource = dt;
              
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sqd = new SqlDataAdapter("Select * from TimeSlotDetail Where DateTime = '" + DateTime.Parse(cmbDateTime.Text.Trim()) + "'; ", con);
                DataTable dt = new DataTable();
                sqd.Fill(dt);
                dataGridView3.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void load_ID() 
        {
            con.Open();
            SqlCommand scm = new SqlCommand("Select PatientID from Patient ORDER BY PatientID ASC", con);
            SqlDataReader rd = scm.ExecuteReader();

            while (rd.Read())
            {
                cmbPatientID.Items.Add(rd["PatientID"]);
                cmbPatientID2.Items.Add(rd["PatientID"]);
            }
            con.Close();
        }

        public void load_StaffID()
        {
            con.Open();
            SqlCommand scm = new SqlCommand("Select StaffID from Staff ORDER BY StaffID ASC", con);
            SqlDataReader rd = scm.ExecuteReader();

            while (rd.Read())
            {
                cmbStaffID3.Items.Add(rd["StaffID"]);
                txtFindStaff.Items.Add(rd["StaffID"]);
               
            }
            con.Close();
        }
     
       private void btnTimeSlotView_Click_1(object sender, EventArgs e)
       {
           try
           {
               sqlDataAdapter7.Fill(dataSet111);
           }

           catch (Exception ex)
           {

               MessageBox.Show(ex.Message);
           }
       }
    


       private void btnAddDateAndTime_Click(object sender, EventArgs e)
       {
           sqlCommand4.CommandText = @" insert into TimeSlot(DateTime) 
            values('" + dateTimePicker1.Value + "')";

           sqlConnection1.Open();
           sqlCommand4.ExecuteNonQuery();
           this.Refresh();
           sqlConnection1.Close();
           MessageBox.Show("New Slot Added Successfully");
       }

       private void AsmaraClinic_FormClosing(object sender, FormClosingEventArgs e)
       {
           DialogResult dialog = MessageBox.Show("Do you really want to Exit?",
              "Exit", MessageBoxButtons.YesNo);

           if (dialog == DialogResult.Yes)
           {
               Application.Exit();
           }

           if (dialog == DialogResult.No)
           {
               e.Cancel = true;
           }
       }

       private void textBox1_TextChanged(object sender, EventArgs e)
       {
          
          
       }

       private void timer1_Tick_1(object sender, EventArgs e)
       {
           DateTime dTime = DateTime.Now;

          this.lblDateTime.Text = dTime.ToString();
       }

       void load_StaffId() 
       {
           con.Open();
           SqlCommand scm = new SqlCommand("Select StaffID from Staff where JobTitle = 'Doctor' ORDER BY StaffID ASC", con);
           SqlDataReader rd = scm.ExecuteReader();

           while (rd.Read())
           {
               cmbStaffID.Items.Add(rd["StaffID"]);
               txtStaffID.Items.Add(rd["StaffID"]);
           }
           con.Close();
       
       }

       void load_DateTime()
       {
           con.Open();
           SqlCommand scm = new SqlCommand("Select DateTime from TimeSlot ORDER BY DateTime ASC", con);
           SqlDataReader rd = scm.ExecuteReader();

           while (rd.Read())
           {
               cmbDateTime.Items.Add(rd["DateTime"]);
           }
           con.Close();
       }

       private void btnCreateSchedule_Click(object sender, EventArgs e)
       {
           try
           {
               con.Open();
               String Query = "Insert into TimeSlotDetail(StaffID, DateTime) Values ('" + int.Parse(cmbStaffID.Text.Trim()) + "', '" + DateTime.Parse(cmbDateTime.Text.Trim()) + "') ";
               SqlCommand scm = new SqlCommand(Query, con);

               SqlDataReader rd = scm.ExecuteReader();

               this.Refresh();
              // con.Close();
               MessageBox.Show("Schedule Created");
           }

           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);

           }
           con.Close();
       }

       private void cmbStaffID3_SelectedIndexChanged(object sender, EventArgs e)
       {
           SqlDataAdapter sqd = new SqlDataAdapter("Select * from Appointment where StaffID = '" + int.Parse(cmbStaffID3.Text) + "' ;", con);
           DataTable dt = new DataTable();
           sqd.Fill(dt);
           dgrAppointment.DataSource = dt;
       }

      

      

      

       
      

    }
            
 }
