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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 obj = new Form2();
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
            Form4 obj = new Form4();
            obj.Show();
        }
    }
}
