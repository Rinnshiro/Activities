namespace StudentInfoApplication
{
	partial class frmStudentInfo
	{

		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblStudentNo = new System.Windows.Forms.Label();
			this.lblLastName = new System.Windows.Forms.Label();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.txtStudentNo = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lstStudentNo = new System.Windows.Forms.ListBox();
			this.lstLastName = new System.Windows.Forms.ListBox();
			this.lstFirstName = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.BackColor = System.Drawing.Color.Transparent;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.lblTitle.Location = new System.Drawing.Point(150, 19);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(170, 20);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Student Information";
			// 
			// lblStudentNo
			// 
			this.lblStudentNo.AutoSize = true;
			this.lblStudentNo.Location = new System.Drawing.Point(34, 67);
			this.lblStudentNo.Name = "lblStudentNo";
			this.lblStudentNo.Size = new System.Drawing.Size(64, 13);
			this.lblStudentNo.TabIndex = 1;
			this.lblStudentNo.Text = "Student No:";
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Location = new System.Drawing.Point(34, 101);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(61, 13);
			this.lblLastName.TabIndex = 2;
			this.lblLastName.Text = "Last Name:";
			// 
			// lblFirstName
			// 
			this.lblFirstName.AutoSize = true;
			this.lblFirstName.Location = new System.Drawing.Point(34, 136);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size = new System.Drawing.Size(60, 13);
			this.lblFirstName.TabIndex = 3;
			this.lblFirstName.Text = "First Name:";
			// 
			// txtStudentNo
			// 
			this.txtStudentNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtStudentNo.Location = new System.Drawing.Point(112, 64);
			this.txtStudentNo.Name = "txtStudentNo";
			this.txtStudentNo.Size = new System.Drawing.Size(170, 20);
			this.txtStudentNo.TabIndex = 4;
			// 
			// txtLastName
			// 
			this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLastName.Location = new System.Drawing.Point(112, 98);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(170, 20);
			this.txtLastName.TabIndex = 5;
			// 
			// txtFirstName
			// 
			this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFirstName.Location = new System.Drawing.Point(112, 133);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(170, 20);
			this.txtFirstName.TabIndex = 6;
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnAdd.Location = new System.Drawing.Point(112, 170);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(170, 30);
			this.btnAdd.TabIndex = 7;
			this.btnAdd.Text = "Add Student Info";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// lstStudentNo
			// 
			this.lstStudentNo.FormattingEnabled = true;
			this.lstStudentNo.Location = new System.Drawing.Point(37, 234);
			this.lstStudentNo.Name = "lstStudentNo";
			this.lstStudentNo.Size = new System.Drawing.Size(120, 147);
			this.lstStudentNo.TabIndex = 8;
			// 
			// lstLastName
			// 
			this.lstLastName.FormattingEnabled = true;
			this.lstLastName.Location = new System.Drawing.Point(176, 234);
			this.lstLastName.Name = "lstLastName";
			this.lstLastName.Size = new System.Drawing.Size(120, 147);
			this.lstLastName.TabIndex = 9;
			// 
			// lstFirstName
			// 
			this.lstFirstName.FormattingEnabled = true;
			this.lstFirstName.Location = new System.Drawing.Point(317, 234);
			this.lstFirstName.Name = "lstFirstName";
			this.lstFirstName.Size = new System.Drawing.Size(120, 147);
			this.lstFirstName.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(51, 218);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Student ID List";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(195, 218);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Last Name List";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(343, 218);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "First Name List";
			// 
			// frmStudentInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::StudentInfoApplication.Properties.Resources.abstract_rose_quarz_pink_fusia_background;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(476, 411);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lstFirstName);
			this.Controls.Add(this.lstLastName);
			this.Controls.Add(this.lstStudentNo);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.txtStudentNo);
			this.Controls.Add(this.lblFirstName);
			this.Controls.Add(this.lblLastName);
			this.Controls.Add(this.lblStudentNo);
			this.Controls.Add(this.lblTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmStudentInfo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StudentInfoApplication";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblStudentNo;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.Label lblFirstName;
		private System.Windows.Forms.TextBox txtStudentNo;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ListBox lstStudentNo;
		private System.Windows.Forms.ListBox lstLastName;
		private System.Windows.Forms.ListBox lstFirstName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}