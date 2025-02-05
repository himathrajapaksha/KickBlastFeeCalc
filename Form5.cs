using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KBV2
{
    public partial class Form5 : Form
    {



        private const decimal BEGINNER_RATE = 50.00M;
        private const decimal INTERMEDIATE_RATE = 75.00M;
        private const decimal ELITE_RATE = 100.00M;
        private const decimal PRIVATE_COACHING_RATE = 30.00M;
        private const decimal COMPETITION_FEE = 50.00M;


        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Please enter athlete name.", "Validation Error");
                    return;
                }

                if (!decimal.TryParse(txtCurrentWeight.Text, out decimal currentWeight))
                {
                    MessageBox.Show("Please enter a valid current weight.", "Validation Error");
                    return;
                }

                if (!decimal.TryParse(txtCompetitionWeight.Text, out decimal competitionWeight))
                {
                    MessageBox.Show("Please enter a valid competition weight.", "Validation Error");
                    return;
                }

                // Calculate base training cost
                decimal trainingCost = cboTrainingPlan.Text switch
                {
                    "Beginner" => BEGINNER_RATE,
                    "Intermediate" => INTERMEDIATE_RATE,
                    "Elite" => ELITE_RATE,
                    _ => 0
                };

                // Calculate private coaching cost
                decimal coachingCost = numPrivateHours.Value * PRIVATE_COACHING_RATE;

                // Calculate competition costs (only for Intermediate and Elite)
                decimal competitionCost = 0;
                if (cboTrainingPlan.Text != "Beginner")
                {
                    competitionCost = numCompetitions.Value * COMPETITION_FEE;
                }
                else if (numCompetitions.Value > 0)
                {
                    MessageBox.Show("Note: Beginner athletes cannot participate in competitions.", "Information");
                    numCompetitions.Value = 0;
                }

                // Calculate total
                decimal totalCost = trainingCost + coachingCost + competitionCost;

                // Prepare weight comparison message
                string weightMessage = currentWeight == competitionWeight
                    ? "Current weight matches competition weight category."
                    : currentWeight < competitionWeight
                        ? $"Current weight is {competitionWeight - currentWeight:F1}kg below competition weight category."
                        : $"Current weight is {currentWeight - competitionWeight:F1}kg above competition weight category.";

                // Show detailed cost breakdown
                string message = $"Cost Breakdown for {txtName.Text}:\n\n" +
                               $"Base Training ({cboTrainingPlan.Text}): {trainingCost:C}\n" +
                               $"Private Coaching ({numPrivateHours.Value} hours): {coachingCost:C}\n" +
                               $"Competition Fees ({numCompetitions.Value} competitions): {competitionCost:C}\n" +
                               $"Total Monthly Cost: {totalCost:C}\n\n" +
                               $"Weight Status: {weightMessage}";

                MessageBox.Show(message, "Monthly Cost Calculation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rjButton3_Click(object sender, EventArgs e)
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

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 obj = new Form4();
            obj.Show();
        }
    }
}
