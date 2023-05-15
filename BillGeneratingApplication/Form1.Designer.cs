namespace BillGeneratingApplication
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtAmnt = new System.Windows.Forms.TextBox();
            this.radioResidential = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioCommercial = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.outputLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate Bill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAmnt
            // 
            this.txtAmnt.Location = new System.Drawing.Point(207, 122);
            this.txtAmnt.Name = "txtAmnt";
            this.txtAmnt.Size = new System.Drawing.Size(131, 23);
            this.txtAmnt.TabIndex = 1;
            this.txtAmnt.TextChanged += new System.EventHandler(this.txtAmnt_TextChanged);
            // 
            // radioResidential
            // 
            this.radioResidential.AutoSize = true;
            this.radioResidential.Location = new System.Drawing.Point(209, 171);
            this.radioResidential.Name = "radioResidential";
            this.radioResidential.Size = new System.Drawing.Size(82, 19);
            this.radioResidential.TabIndex = 2;
            this.radioResidential.TabStop = true;
            this.radioResidential.Text = "Residential";
            this.radioResidential.UseVisualStyleBackColor = true;
            this.radioResidential.CheckedChanged += new System.EventHandler(this.radioResidential_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of Units Consumed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type of Consumer:";
            // 
            // radioCommercial
            // 
            this.radioCommercial.AutoSize = true;
            this.radioCommercial.Location = new System.Drawing.Point(209, 196);
            this.radioCommercial.Name = "radioCommercial";
            this.radioCommercial.Size = new System.Drawing.Size(90, 19);
            this.radioCommercial.TabIndex = 5;
            this.radioCommercial.TabStop = true;
            this.radioCommercial.Text = "Commercial";
            this.radioCommercial.UseVisualStyleBackColor = true;
            this.radioCommercial.CheckedChanged += new System.EventHandler(this.radioCommercial_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount to be Paid:";
            // 
            // outputLbl
            // 
            this.outputLbl.AutoSize = true;
            this.outputLbl.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.outputLbl.Location = new System.Drawing.Point(495, 120);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(18, 25);
            this.outputLbl.TabIndex = 7;
            this.outputLbl.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 329);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioCommercial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioResidential);
            this.Controls.Add(this.txtAmnt);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Calculate Bill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox txtAmnt;
        private RadioButton radioResidential;
        private Label label1;
        private Label label2;
        private RadioButton radioCommercial;
        private Label label3;
        private Label outputLbl;
    }
}