namespace _26._LeapYear
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
            lblYear = new Label();
            txbYear = new TextBox();
            btnYear = new Button();
            SuspendLayout();
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(78, 55);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(59, 15);
            lblYear.TabIndex = 0;
            lblYear.Text = "Enter Year";
            // 
            // txbYear
            // 
            txbYear.Location = new Point(224, 53);
            txbYear.Name = "txbYear";
            txbYear.Size = new Size(100, 23);
            txbYear.TabIndex = 1;
            // 
            // btnYear
            // 
            btnYear.Location = new Point(203, 136);
            btnYear.Name = "btnYear";
            btnYear.Size = new Size(75, 23);
            btnYear.TabIndex = 2;
            btnYear.Text = "Is It a Leap Year or Not?";
            btnYear.UseVisualStyleBackColor = true;
            btnYear.Click += btnYear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnYear);
            Controls.Add(txbYear);
            Controls.Add(lblYear);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblYear;
        private TextBox txbYear;
        private Button btnYear;
    }
}
