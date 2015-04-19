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
    public partial class Doctor : Form
    {

        SqlConnection con = new SqlConnection("data source=.; database = AsmaraClinic; integrated security = SSPI");
       
        public Doctor(String username)
        {
            InitializeComponent();
            lblUser.Text = "User: " + username;
            dateTime.Start();
            load_StaffId();
        }
       // DataTable dt;

        private void btnViewMySchedule_Click(object sender, EventArgs e)
        {
            try
            {
               // SqlDataAdapter sqAd = new SqlDataAdapter();
               // LogIn lgn = new LogIn();
               //// String user = lgn.txtUserName.Text;
               // sqlDataAdapter1.Fill(dataSet121);

                SqlDataAdapter sqd = new SqlDataAdapter("Select * from TimeSlotDetail ", con);
                DataTable dt = new DataTable();
                sqd.Fill(dt);
                dgrSchedule.DataSource = dt;
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sqd = new SqlDataAdapter("Select * from TimeSlotDetail where StaffID = '" + int.Parse(cmdID.Text) + "' ;", con);
            DataTable dt = new DataTable();
            sqd.Fill(dt);
            dgrSchedule.DataSource = dt;
        }

        void load_StaffId()
        {
            con.Open();
            SqlCommand scm = new SqlCommand("Select StaffID from Staff where JobTitle = 'Doctor' ORDER BY StaffID ASC", con);
            SqlDataReader rd = scm.ExecuteReader();

            while (rd.Read())
            {
                cmdID.Items.Add(rd["StaffID"]);
                cmbStaff.Items.Add(rd["StaffID"]);
            }
            con.Close();

        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            //sqlDataAdapter2.Fill(dataSet9);
            SqlDataAdapter sqd = new SqlDataAdapter("Select * from Appointment ", con);
            DataTable dt = new DataTable();
            sqd.Fill(dt);
            dgrAppointment.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlDataAdapter sqd = new SqlDataAdapter("Select * from Appointment where StaffID = '" + int.Parse(cmbStaff.Text) + "' ;", con);
            DataTable dt = new DataTable();
            sqd.Fill(dt);
            dgrAppointment.DataSource = dt;
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;

            this.lblDateTime.Text = dateTime.ToString();
        }

       
        private void Doctor_FormClosing(object sender, FormClosingEventArgs e)
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
      
    }
}
