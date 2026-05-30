namespace EmployeeApplication1
{
    partial class frmComputeSalary
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.TextBox txtRatePerHour;
        private System.Windows.Forms.TextBox txtTotalHoursWorked;

        private System.Windows.Forms.Button btnComputeSalary;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.Label lblSalary;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRatePerHour = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalHoursWorked = new System.Windows.Forms.TextBox();
            this.btnComputeSalary = new System.Windows.Forms.Button();

            this.label7 = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.Text = "First Name:";

            // txtFirstName
            this.txtFirstName.Location = new System.Drawing.Point(160, 27);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(180, 20);

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.Text = "Last Name:";

            // txtLastName
            this.txtLastName.Location = new System.Drawing.Point(160, 62);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(180, 20);

            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.Text = "Department:";

            // txtDepartment
            this.txtDepartment.Location = new System.Drawing.Point(160, 97);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(180, 20);

            // label4
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.Text = "Job Title:";

            // txtJobTitle
            this.txtJobTitle.Location = new System.Drawing.Point(160, 132);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(180, 20);

            // label5
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.Text = "Rate per Hour:";

            // txtRatePerHour
            this.txtRatePerHour.Location = new System.Drawing.Point(160, 167);
            this.txtRatePerHour.Name = "txtRatePerHour";
            this.txtRatePerHour.Size = new System.Drawing.Size(180, 20);

            // label6
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.Text = "Total Hours Worked:";

            // txtTotalHoursWorked
            this.txtTotalHoursWorked.Location = new System.Drawing.Point(160, 202);
            this.txtTotalHoursWorked.Name = "txtTotalHoursWorked";
            this.txtTotalHoursWorked.Size = new System.Drawing.Size(180, 20);

            // btnComputeSalary
            this.btnComputeSalary.Location = new System.Drawing.Point(160, 240);
            this.btnComputeSalary.Name = "btnComputeSalary";
            this.btnComputeSalary.Size = new System.Drawing.Size(180, 35);
            this.btnComputeSalary.Text = "Compute Salary";
            this.btnComputeSalary.UseVisualStyleBackColor = true;
            this.btnComputeSalary.Click += new System.EventHandler(this.btnComputeSalary_Click);

            // label7
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.Text = "Full Name:";

            // lblFullName
            this.lblFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFullName.Location = new System.Drawing.Point(160, 300);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(180, 23);

            // label8
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.Text = "Department:";

            // lblDepartment
            this.lblDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDepartment.Location = new System.Drawing.Point(160, 335);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(180, 23);

            // label9
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.Text = "Job Title:";

            // lblJobTitle
            this.lblJobTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJobTitle.Location = new System.Drawing.Point(160, 370);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(180, 23);

            // label10
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 410);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.Text = "Salary:";

            // lblSalary
            this.lblSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalary.Location = new System.Drawing.Point(160, 405);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(180, 23);

            // frmComputeSalary
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtJobTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRatePerHour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalHoursWorked);
            this.Controls.Add(this.btnComputeSalary);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblJobTitle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblSalary);
            this.Name = "frmComputeSalary";
            this.Text = "Compute Salary";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}