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
using System.Security.Cryptography;

namespace AsmaraClinic
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();

        }
        private const string MyConnString = "data source=.; database = AsmaraClinic; integrated security = SSPI";

        private string HashPassword(string suppliedPwd)
        {

            // Create a new hash type using Create().
            HashAlgorithm hashAlg = HashAlgorithm.Create("MD5");
            // Now encode the string into a byte array.
            byte[] myMsgAsByteArray = Encoding.Default.GetBytes(suppliedPwd);
            // Now hash it.
            byte[] myHashCode = hashAlg.ComputeHash(myMsgAsByteArray);
            return Encoding.Default.GetString(myHashCode);
        }

       

        private bool ValidatePasswordHash(string storedPwd, string suppliedPwd)
        {
            if (storedPwd == HashPassword(suppliedPwd))
                return true;
            else
                return false;
        }

     

        private void btnNewAccount_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Get supplied password and hash it.
                string hashedPassword = HashPassword(this.txtPassword.Text);
                // Insert new info to the database.
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = MyConnString;
                string sqlStr = string.Format
                ("Insert LoginInfo (StaffID, Password) Values ('{0}', '{1}')",
                int.Parse(txtUserName.Text.Trim()), hashedPassword);
                SqlCommand sql = new SqlCommand(sqlStr, cn);
                cn.Open();
                sql.ExecuteNonQuery();
                MessageBox.Show("New user account created successfully!");
                cn.Close();
                //MessageBox.Show("New user account created successfully!");
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnLigIn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = MyConnString;
                string sqlStr =
                string.Format("Select * from LoginInfo Where StaffID='{0}'",
                this.txtUserName.Text);
                SqlDataReader myReader;
                SqlCommand sql = new SqlCommand(sqlStr, cn);
                cn.Open();
                myReader = sql.ExecuteReader(CommandBehavior.CloseConnection);
                string storedPwd = "";
                while (myReader.Read())
                    storedPwd = myReader["Password"].ToString().Trim();
                myReader.Close();
                // Now validate the stored password with the supplied password.
                bool passWordIsValid = ValidatePasswordHash(storedPwd,
                this.txtPassword.Text);
                // Now let user in or kick 'em out.
                if (!passWordIsValid)
                {
                    MessageBox.Show("Sorry, your password is not valid...See ya!");
                    this.DialogResult = DialogResult.Cancel;
                }
                else {
                    MessageBox.Show("Userame and password is correct");
                    this.Hide();
                    AsmaraClinic f2 = new AsmaraClinic();
                    f2.ShowDialog();
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
