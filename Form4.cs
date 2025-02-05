using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;
using System.Reflection;

namespace KBV2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hiros\source\repos\KBV2\Database1.mdf;Integrated Security=True");


        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 obj = new Form3();
            obj.Show();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {

            DialogResult confirmation = MessageBox.Show("Are you Sure? Do you Want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (confirmation == DialogResult.No)
            {
                //do nothing
            }
            else
            {
                //do nothing
            }
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 obj = new Form5();
            obj.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(cmbid.Text);
                string query_search = "Select * from CustomerTB where CustomerID='" + id + "'";
                SqlCommand cmnd = new SqlCommand(query_search, Conn);
                Conn.Open();
                SqlDataReader r = cmnd.ExecuteReader();
                while (r.Read())
                {
                    cmbid.Text = r[0].ToString();
                    string gender;
                    if (malerb.Checked)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }
                    nametxt.Text = r[2].ToString();
                    cnotxt.Text = r[3].ToString();
                    dateTimePicker1.Text = r[4].ToString();
                    emailtxt.Text = r[5].ToString();
                    ecnotxt.Text = r[6].ToString();
                    weighttxt.Text = r[7].ToString();
                    heighttxt.Text = r[8].ToString();
                    cmbplan.Text = r[9].ToString();
                }


            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}"); }


            finally { }
        }

        private void rjButton6_Click(object sender, EventArgs e)
        {

            try
            {

                int customerID = int.Parse(cmbid.Text);
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hiros\\source\\repos\\KBV2\\Database1.mdf;Integrated Security=True";

                string query_delete = "DELETE FROM CustomerTB WHERE CustomerID = @CustomerID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query_delete, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerID);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Bye Bye Customer!!!, Customer record deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Yo your customer got vanished, Customer record not found.");
                        }
                    }





                }
            }
            catch (Exception ex) { MessageBox.Show("WTF mate?, Error while Deleting" + ex); }

            finally
            {
                Conn.Close();
            }
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            cmbid.SelectedIndex = 0;
            malerb.Checked = false;
            femalerb.Checked = false;
            nametxt.Clear();
            cnotxt.Clear();
            dateTimePicker1.Value = DateTime.Now;
            emailtxt.Clear();
            ecnotxt.Clear();
            weighttxt.Clear();
            heighttxt.Clear();
            cmbplan.SelectedIndex = 0;
        }

        private void rjButton7_Click(object sender, EventArgs e)
        {
            try
            {
                int id = cmbid.Text != "" ? int.Parse(cmbid.Text) : 0;
                string gender;
                if (malerb.Checked)
                {
                    gender = "Male";
                }
                else { gender = "Female"; }

                string customername = nametxt.Text;
                string contactno = cnotxt.Text;
                DateTime dateofbirth = dateTimePicker1.Value;
                string email = emailtxt.Text;
                string emergencycontact = ecnotxt.Text;
                string weightid = weighttxt.Text;
                string heightid = heighttxt.Text;
                string planid = cmbplan.Text;

                string query_update = "UPDATE CustomerTB SET " +
                       "Gender = '" + gender + "', " +
                       "FullName = '" + customername + "', " +
                       "ContactNo = '" + contactno + "', " +
                       "DateOfBirth = '" + dateofbirth.ToString("yyyy-MM-dd") + "', " +
                       "Email = '" + email + "', " +
                       "EmergencyContact = '" + emergencycontact + "', " +
                       "WeightID = '" + weightid + "', " +
                       "HeightID = '" + heightid + "', " +
                       "PlanID = '" + planid + "' " +
                       "WHERE CustomerID = '" + id + "'";

                SqlCommand cmnd = new SqlCommand(query_update, Conn);
                Conn.Open();
                cmnd.ExecuteNonQuery();

                MessageBox.Show("Yay bruv,customer Record Updated Successfully", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show("WTF mate? Error got while updating!!" + ex);


            }
            finally
            {
                Conn.Close();
            }
        }

        private void rjButton8_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(cmbid.Text);
                string gender;
                if (malerb.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                string customername = nametxt.Text;
                string contactno = cnotxt.Text;
                DateTime dateofbirth = dateTimePicker1.Value;
                string email = emailtxt.Text;
                string emergencycontact = ecnotxt.Text;
                string weightid = weighttxt.Text;
                string heightid = heighttxt.Text;
                string planid = cmbplan.Text;

                string query_insert = "Insert into CustomerTB values('" + id + "','" + gender + "','" + customername + "','" + contactno + "','" + dateofbirth + "','" + email + "','" + emergencycontact + "','" + weightid + "','" + heightid + "','" + planid + "')";
                SqlCommand cmnd = new SqlCommand(query_insert, Conn);

                Conn.Open();
                cmnd.ExecuteNonQuery();
                MessageBox.Show("Record Saved Successfully", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

            catch (Exception ex)
            {

                MessageBox.Show("WTF mate?, Error while Saving" + ex);


            }

            finally
            {
                Conn.Close();
            }
        }
    }
}
