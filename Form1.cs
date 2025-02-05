namespace KBV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 obj = new Form2();
            obj.Show();
        }
    }
}
