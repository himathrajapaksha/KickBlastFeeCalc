using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBV2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            usertxt.Clear();
            passtxt.Clear();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Are you Sure bruv? Do you Want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void rjButton2_Click(object sender, EventArgs e)
        {
            string username = usertxt.Text;
            string password = passtxt.Text;

            if ((username == "Admin") && (password == "12345"))
            {
                MessageBox.Show("Login Success!");
                this.Hide();
                Form3 obj = new Form3();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Login Not Success", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
