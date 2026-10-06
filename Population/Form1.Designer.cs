namespace Population
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
            label1 = new Label();
            txtStart = new TextBox();
            label2 = new Label();
            txtRate = new TextBox();
            label3 = new Label();
            txtDays = new TextBox();
            btnCal = new Button();
            btnClr = new Button();
            lstPopulation = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 52);
            label1.Name = "label1";
            label1.Size = new Size(203, 20);
            label1.TabIndex = 0;
            label1.Text = "Starting number of organism:";
            // 
            // txtStart
            // 
            txtStart.Location = new Point(240, 52);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(169, 27);
            txtStart.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 108);
            label2.Name = "label2";
            label2.Size = new Size(187, 20);
            label2.TabIndex = 2;
            label2.Text = "Average daily increase (%):";
            // 
            // txtRate
            // 
            txtRate.Location = new Point(240, 105);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(169, 27);
            txtRate.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 154);
            label3.Name = "label3";
            label3.Size = new Size(194, 20);
            label3.TabIndex = 4;
            label3.Text = "Number of days to multiply:";
            // 
            // txtDays
            // 
            txtDays.Location = new Point(240, 154);
            txtDays.Name = "txtDays";
            txtDays.Size = new Size(169, 27);
            txtDays.TabIndex = 5;
            // 
            // btnCal
            // 
            btnCal.Location = new Point(47, 222);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(108, 37);
            btnCal.TabIndex = 6;
            btnCal.Text = "Calculate";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click;
            // 
            // btnClr
            // 
            btnClr.Location = new Point(184, 222);
            btnClr.Name = "btnClr";
            btnClr.Size = new Size(108, 37);
            btnClr.TabIndex = 7;
            btnClr.Text = "Clear";
            btnClr.UseVisualStyleBackColor = true;
            btnClr.Click += btnClr_Click;
            // 
            // lstPopulation
            // 
            lstPopulation.FormattingEnabled = true;
            lstPopulation.Location = new Point(40, 287);
            lstPopulation.Name = "lstPopulation";
            lstPopulation.Size = new Size(431, 144);
            lstPopulation.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 471);
            Controls.Add(lstPopulation);
            Controls.Add(btnClr);
            Controls.Add(btnCal);
            Controls.Add(txtDays);
            Controls.Add(label3);
            Controls.Add(txtRate);
            Controls.Add(label2);
            Controls.Add(txtStart);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Population";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtStart;
        private Label label2;
        private TextBox txtRate;
        private Label label3;
        private TextBox txtDays;
        private Button btnCal;
        private Button btnClr;
        private ListBox lstPopulation;
    }
}
