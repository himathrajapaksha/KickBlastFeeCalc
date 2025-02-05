namespace KBV2
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            rjButton1 = new CustomControls.RJControls.RJButton();
            rjButton2 = new CustomControls.RJControls.RJButton();
            label1 = new Label();
            rjButton3 = new CustomControls.RJControls.RJButton();
            groupBox1 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
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
            rjButton1.Font = new Font("Cascadia Code", 16.2F, FontStyle.Bold);
            rjButton1.ForeColor = Color.Cyan;
            rjButton1.Location = new Point(12, 12);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(188, 50);
            rjButton1.TabIndex = 2;
            rjButton1.Text = "Back";
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
            rjButton2.Font = new Font("Cascadia Code", 16.2F, FontStyle.Bold);
            rjButton2.ForeColor = Color.Cyan;
            rjButton2.Location = new Point(379, 12);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(188, 50);
            rjButton2.TabIndex = 4;
            rjButton2.Text = "Exit";
            rjButton2.TextColor = Color.Cyan;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += rjButton2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Cascadia Mono SemiBold", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(210, 440);
            label1.Name = "label1";
            label1.Size = new Size(574, 154);
            label1.TabIndex = 5;
            label1.Text = "*Note\n\n🔹 Private Coaching: Up to five hours weekly.\n\n🔹 Competition Entry: Intermediate & Elite athletes only.\n\n🔹 Monthly Competitions: Second Saturday of every month.";
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
            rjButton3.Font = new Font("Cascadia Code", 16.2F, FontStyle.Bold);
            rjButton3.ForeColor = Color.Cyan;
            rjButton3.Location = new Point(726, 12);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(222, 50);
            rjButton3.TabIndex = 6;
            rjButton3.Text = "New Athlete";
            rjButton3.TextColor = Color.Cyan;
            rjButton3.UseVisualStyleBackColor = false;
            rjButton3.Click += rjButton3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Location = new Point(105, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(786, 367);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(6, 13);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(774, 348);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Black;
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.BackgroundImageLayout = ImageLayout.Center;
            tabPage1.Location = new Point(4, 36);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(766, 308);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Training Plan";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Black;
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.BackgroundImageLayout = ImageLayout.Center;
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(766, 315);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Weight Category";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(960, 648);
            Controls.Add(rjButton3);
            Controls.Add(label1);
            Controls.Add(rjButton2);
            Controls.Add(rjButton1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "Information";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton rjButton2;
        private Label label1;
        private CustomControls.RJControls.RJButton rjButton3;
        private GroupBox groupBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}