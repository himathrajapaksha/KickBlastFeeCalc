namespace KBV2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            rjButton1 = new CustomControls.RJControls.RJButton();
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
            rjButton1.Location = new Point(319, 370);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(188, 50);
            rjButton1.TabIndex = 0;
            rjButton1.Text = "Welcome";
            rjButton1.TextColor = Color.Cyan;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(825, 450);
            Controls.Add(rjButton1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Welcome";
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.RJControls.RJButton rjButton1;
    }
}
