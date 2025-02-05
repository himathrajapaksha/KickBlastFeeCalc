namespace KBV2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            groupBox1 = new GroupBox();
            passtxt = new TextBox();
            label2 = new Label();
            usertxt = new TextBox();
            label1 = new Label();
            rjButton1 = new CustomControls.RJControls.RJButton();
            rjButton2 = new CustomControls.RJControls.RJButton();
            rjButton3 = new CustomControls.RJControls.RJButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(passtxt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(usertxt);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(166, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(470, 212);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // passtxt
            // 
            passtxt.Font = new Font("Cascadia Code", 10.2F);
            passtxt.Location = new Point(279, 123);
            passtxt.Name = "passtxt";
            passtxt.PasswordChar = '*';
            passtxt.Size = new Size(125, 27);
            passtxt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(111, 130);
            label2.Name = "label2";
            label2.Size = new Size(90, 22);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // usertxt
            // 
            usertxt.Font = new Font("Cascadia Code", 10.2F);
            usertxt.Location = new Point(279, 66);
            usertxt.Name = "usertxt";
            usertxt.Size = new Size(125, 27);
            usertxt.TabIndex = 1;
            usertxt.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(111, 73);
            label1.Name = "label1";
            label1.Size = new Size(90, 22);
            label1.TabIndex = 0;
            label1.Text = "Username";
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
            rjButton1.Location = new Point(166, 352);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(188, 50);
            rjButton1.TabIndex = 1;
            rjButton1.Text = "Clear";
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
            rjButton2.Location = new Point(448, 352);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(188, 50);
            rjButton2.TabIndex = 2;
            rjButton2.Text = "Login";
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
            rjButton3.Font = new Font("Cascadia Code", 16.2F, FontStyle.Bold);
            rjButton3.ForeColor = Color.Cyan;
            rjButton3.Location = new Point(600, 12);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(188, 50);
            rjButton3.TabIndex = 3;
            rjButton3.Text = "Exit";
            rjButton3.TextColor = Color.Cyan;
            rjButton3.UseVisualStyleBackColor = false;
            rjButton3.Click += rjButton3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(rjButton3);
            Controls.Add(rjButton2);
            Controls.Add(groupBox1);
            Controls.Add(rjButton1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox passtxt;
        private Label label2;
        private TextBox usertxt;
        private Label label1;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton3;
    }
}