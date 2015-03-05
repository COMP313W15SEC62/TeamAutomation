using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsmaraClinic
{
    public partial class Form1 : Form
    {
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtID.Clear(); txtFName.Clear(); txtLName.Clear(); txtStreet.Clear();
            txtCity.Clear(); txtProvince.Clear(); txtPostalCode.Clear();
            txtOhip.Clear(); txtEmail.Clear(); txtPhone.Clear(); txtStaffID.Clear();


        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            sqlCommand2.CommandText = @" insert into Staff(StaffID, FName, LName, JobTitle, JobID, HireDate, Address, PhoneNumber, Email) 
            values('" + int.Parse(txtStaffID1.Text.Trim()) + "', '" + txtSFName.Text.Trim() + "', '" + txtSLName.Text.Trim() + "', '" + txtJobTitle.Text.Trim() + "', '" + txtJobId.Text.Trim() + "', '" + txtHireDate.Text.Trim() + "', '" + txtAddress.Text.Trim() + "', '" + txtSPhone.Text.Trim() + "', '" + txtSEmail.Text.Trim() +  "')";

            sqlConnection1.Open();
            sqlCommand2.ExecuteNonQuery();
            sqlConnection1.Close();
            MessageBox.Show("New Staff Added Successfully");
        }

        private void btnRefsresh_Click(object sender, EventArgs e)
        {
            txtStaffID1.Clear(); txtSFName.Clear(); txtSLName.Clear(); txtJobTitle.Clear();
            txtJobId.Clear(); txtHireDate.Clear(); txtAddress.Clear();
            txtSEmail.Clear(); txtSPhone.Clear();
        }

        

        private void btnViewPatients_Click(object sender, EventArgs e)
        {
           // sqlDataAdapter1.Fill
        }

        private void btnViewPatients_Click_1(object sender, EventArgs e)
        {
            sqlDataAdapter1.Fill(dataSet21);
        }

        private void btnAllStaff_Click(object sender, EventArgs e)
        {
            sqlDataAdapter2.Fill(dataSet31);
        }
    }
}
