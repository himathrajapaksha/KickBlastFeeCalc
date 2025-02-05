namespace KBV2
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label1 = new Label();
            txtName = new TextBox();
            txtCurrentWeight = new TextBox();
            label2 = new Label();
            txtCompetitionWeight = new TextBox();
            label3 = new Label();
            cboTrainingPlan = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            numCompetitions = new NumericUpDown();
            numPrivateHours = new NumericUpDown();
            rjButton1 = new CustomControls.RJControls.RJButton();
            rjButton2 = new CustomControls.RJControls.RJButton();
            rjButton3 = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)numCompetitions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrivateHours).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono SemiBold", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(299, 84);
            label1.Name = "label1";
            label1.Size = new Size(50, 22);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Font = new Font("Cascadia Mono SemiBold", 10.2F, FontStyle.Bold);
            txtName.Location = new Point(424, 84);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 1;
            // 
            // txtCurrentWeight
            // 
            txtCurrentWeight.Font = new Font("Cascadia Mono SemiBold", 10.2F, FontStyle.Bold);
            txtCurrentWeight.Location = new Point(424, 128);
            txtCurrentWeight.Name = "txtCurrentWeight";
            txtCurrentWeight.Size = new Size(125, 27);
            txtCurrentWeight.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Mono SemiBold", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(279, 126);
            label2.Name = "label2";
            label2.Size = new Size(70, 22);
            label2.TabIndex = 2;
            label2.Text = "Weight";
            // 
            // txtCompetitionWeight
            // 
            txtCompetitionWeight.Font = new Font("Cascadia Mono SemiBold", 10.2F, FontStyle.Bold);
            txtCompetitionWeight.Location = new Point(424, 175);
            txtCompetitionWeight.Name = "txtCompetitionWeight";
            txtCompetitionWeight.Size = new Size(125, 27);
            txtCompetitionWeight.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Mono SemiBold", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(159, 175);
            label3.Name = "label3";
            label3.Size = new Size(190, 22);
            label3.TabIndex = 4;
            label3.Text = "Competition Weight";
            // 
            // cboTrainingPlan
            // 
            cboTrainingPlan.Font = new Font("Cascadia Mono SemiBold", 10.2F, FontStyle.Bold);
            cboTrainingPlan.FormattingEnabled = true;
            cboTrainingPlan.Items.AddRange(new object[] { "Beginner", "Intermediate", "Elite", "Private", "Competition" });
            cboTrainingPlan.Location = new Point(424, 217);
            cboTrainingPlan.Name = "cboTrainingPlan";
            cboTrainingPlan.Size = new Size(151, 30);
            cboTrainingPlan.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Mono SemiBold", 10.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(209, 320);
            label4.Name = "label4";
            label4.Size = new Size(140, 22);
            label4.TabIndex = 9;
            label4.Text = "private hours";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Mono SemiBold", 10.2F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(219, 272);
            label5.Name = "label5";
            label5.Size = new Size(130, 22);
            label5.TabIndex = 8;
            label5.Text = "competitions";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Mono SemiBold", 10.2F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(209, 220);
            label6.Name = "label6";
            label6.Size = new Size(140, 22);
            label6.TabIndex = 7;
            label6.Text = "Training plan";
            // 
            // numCompetitions
            // 
            numCompetitions.Font = new Font("Cascadia Mono SemiBold", 10.2F, FontStyle.Bold);
            numCompetitions.Location = new Point(425, 270);
            numCompetitions.Name = "numCompetitions";
            numCompetitions.Size = new Size(52, 27);
            numCompetitions.TabIndex = 10;
            // 
            // numPrivateHours
            // 
            numPrivateHours.Font = new Font("Cascadia Mono SemiBold", 10.2F, FontStyle.Bold);
            numPrivateHours.Location = new Point(425, 315);
            numPrivateHours.Name = "numPrivateHours";
            numPrivateHours.Size = new Size(52, 27);
            numPrivateHours.TabIndex = 11;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = SystemColors.WindowText;
            rjButton1.BackgroundColor = SystemColors.WindowText;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 0;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Cascadia Mono SemiBold", 10.2F, FontStyle.Bold);
            rjButton1.ForeColor = Color.Cyan;
            rjButton1.Location = new Point(638, 369);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(115, 38);
            rjButton1.TabIndex = 12;
            rjButton1.Text = "Calculate";
            rjButton1.TextColor = Color.Cyan;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = SystemColors.WindowText;
            rjButton2.BackgroundColor = SystemColors.WindowText;
            rjButton2.BorderColor = Color.PaleVioletRed;
            rjButton2.BorderRadius = 0;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Cascadia Mono SemiBold", 10.2F, FontStyle.Bold);
            rjButton2.ForeColor = Color.Cyan;
            rjButton2.Location = new Point(638, 42);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(115, 38);
            rjButton2.TabIndex = 13;
            rjButton2.Text = "Back";
            rjButton2.TextColor = Color.Cyan;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += rjButton2_Click;
            // 
            // rjButton3
            // 
            rjButton3.BackColor = SystemColors.WindowText;
            rjButton3.BackgroundColor = SystemColors.WindowText;
            rjButton3.BorderColor = Color.PaleVioletRed;
            rjButton3.BorderRadius = 0;
            rjButton3.BorderSize = 0;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = FlatStyle.Flat;
            rjButton3.Font = new Font("Cascadia Mono SemiBold", 10.2F, FontStyle.Bold);
            rjButton3.ForeColor = Color.Cyan;
            rjButton3.Location = new Point(638, 117);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(115, 38);
            rjButton3.TabIndex = 14;
            rjButton3.Text = "Exit";
            rjButton3.TextColor = Color.Cyan;
            rjButton3.UseVisualStyleBackColor = false;
            rjButton3.Click += rjButton3_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(rjButton3);
            Controls.Add(rjButton2);
            Controls.Add(rjButton1);
            Controls.Add(numPrivateHours);
            Controls.Add(numCompetitions);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(cboTrainingPlan);
            Controls.Add(txtCompetitionWeight);
            Controls.Add(label3);
            Controls.Add(txtCurrentWeight);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlDark;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form5";
            Text = "Payment";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)numCompetitions).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrivateHours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtCurrentWeight;
        private Label label2;
        private TextBox txtCompetitionWeight;
        private Label label3;
        private ComboBox cboTrainingPlan;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown numCompetitions;
        private NumericUpDown numPrivateHours;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton3;
    }
}