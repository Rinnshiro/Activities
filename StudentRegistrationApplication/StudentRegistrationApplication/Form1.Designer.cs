namespace StudentRegistrationApplication
{
	partial class frmStudentRegistration
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
			this.lastNameBox = new System.Windows.Forms.TextBox();
			this.firstNameBox = new System.Windows.Forms.TextBox();
			this.middleNameBox = new System.Windows.Forms.TextBox();
			this.headline = new System.Windows.Forms.Label();
			this.lastName = new System.Windows.Forms.Label();
			this.firstName = new System.Windows.Forms.Label();
			this.middleName = new System.Windows.Forms.Label();
			this.maleRadio = new System.Windows.Forms.RadioButton();
			this.femaleRadio = new System.Windows.Forms.RadioButton();
			this.genderSelect = new System.Windows.Forms.Label();
			this.dateSelect = new System.Windows.Forms.Label();
			this.daySelect = new System.Windows.Forms.ComboBox();
			this.monthSelect = new System.Windows.Forms.ComboBox();
			this.yearSelect = new System.Windows.Forms.ComboBox();
			this.registerButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lastNameBox
			// 
			this.lastNameBox.Location = new System.Drawing.Point(12, 102);
			this.lastNameBox.Name = "lastNameBox";
			this.lastNameBox.Size = new System.Drawing.Size(314, 30);
			this.lastNameBox.TabIndex = 0;
			// 
			// firstNameBox
			// 
			this.firstNameBox.Location = new System.Drawing.Point(12, 179);
			this.firstNameBox.Name = "firstNameBox";
			this.firstNameBox.Size = new System.Drawing.Size(314, 30);
			this.firstNameBox.TabIndex = 1;
			// 
			// middleNameBox
			// 
			this.middleNameBox.Location = new System.Drawing.Point(12, 260);
			this.middleNameBox.Name = "middleNameBox";
			this.middleNameBox.Size = new System.Drawing.Size(314, 30);
			this.middleNameBox.TabIndex = 2;
			// 
			// headline
			// 
			this.headline.AutoSize = true;
			this.headline.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headline.Location = new System.Drawing.Point(64, 18);
			this.headline.Name = "headline";
			this.headline.Size = new System.Drawing.Size(216, 23);
			this.headline.TabIndex = 3;
			this.headline.Text = "Student Registration Form";
			// 
			// lastName
			// 
			this.lastName.AutoSize = true;
			this.lastName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lastName.Location = new System.Drawing.Point(8, 76);
			this.lastName.Name = "lastName";
			this.lastName.Size = new System.Drawing.Size(101, 23);
			this.lastName.TabIndex = 4;
			this.lastName.Text = "Last Name:";
			// 
			// firstName
			// 
			this.firstName.AutoSize = true;
			this.firstName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.firstName.Location = new System.Drawing.Point(8, 153);
			this.firstName.Name = "firstName";
			this.firstName.Size = new System.Drawing.Size(105, 23);
			this.firstName.TabIndex = 5;
			this.firstName.Text = "First Name:";
			// 
			// middleName
			// 
			this.middleName.AutoSize = true;
			this.middleName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.middleName.Location = new System.Drawing.Point(8, 234);
			this.middleName.Name = "middleName";
			this.middleName.Size = new System.Drawing.Size(116, 23);
			this.middleName.TabIndex = 6;
			this.middleName.Text = "Middle Name:";
			// 
			// maleRadio
			// 
			this.maleRadio.AutoSize = true;
			this.maleRadio.Location = new System.Drawing.Point(81, 316);
			this.maleRadio.Name = "maleRadio";
			this.maleRadio.Size = new System.Drawing.Size(64, 27);
			this.maleRadio.TabIndex = 7;
			this.maleRadio.TabStop = true;
			this.maleRadio.Text = "Male";
			this.maleRadio.UseVisualStyleBackColor = true;
			// 
			// femaleRadio
			// 
			this.femaleRadio.AutoSize = true;
			this.femaleRadio.Location = new System.Drawing.Point(151, 316);
			this.femaleRadio.Name = "femaleRadio";
			this.femaleRadio.Size = new System.Drawing.Size(78, 27);
			this.femaleRadio.TabIndex = 8;
			this.femaleRadio.TabStop = true;
			this.femaleRadio.Text = "Female";
			this.femaleRadio.UseVisualStyleBackColor = true;
			// 
			// genderSelect
			// 
			this.genderSelect.AutoSize = true;
			this.genderSelect.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.genderSelect.Location = new System.Drawing.Point(8, 316);
			this.genderSelect.Name = "genderSelect";
			this.genderSelect.Size = new System.Drawing.Size(71, 23);
			this.genderSelect.TabIndex = 9;
			this.genderSelect.Text = "Gender:";
			// 
			// dateSelect
			// 
			this.dateSelect.AutoSize = true;
			this.dateSelect.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateSelect.Location = new System.Drawing.Point(12, 369);
			this.dateSelect.Name = "dateSelect";
			this.dateSelect.Size = new System.Drawing.Size(124, 23);
			this.dateSelect.TabIndex = 10;
			this.dateSelect.Text = "Date of birth:";
			// 
			// daySelect
			// 
			this.daySelect.FormattingEnabled = true;
			this.daySelect.Location = new System.Drawing.Point(16, 405);
			this.daySelect.Name = "daySelect";
			this.daySelect.Size = new System.Drawing.Size(89, 31);
			this.daySelect.TabIndex = 11;
			// 
			// monthSelect
			// 
			this.monthSelect.FormattingEnabled = true;
			this.monthSelect.Location = new System.Drawing.Point(111, 405);
			this.monthSelect.Name = "monthSelect";
			this.monthSelect.Size = new System.Drawing.Size(89, 31);
			this.monthSelect.TabIndex = 12;
			// 
			// yearSelect
			// 
			this.yearSelect.FormattingEnabled = true;
			this.yearSelect.Location = new System.Drawing.Point(206, 405);
			this.yearSelect.Name = "yearSelect";
			this.yearSelect.Size = new System.Drawing.Size(120, 31);
			this.yearSelect.TabIndex = 13;
			// 
			// registerButton
			// 
			this.registerButton.BackColor = System.Drawing.Color.Crimson;
			this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.registerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.registerButton.Location = new System.Drawing.Point(16, 456);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(173, 34);
			this.registerButton.TabIndex = 14;
			this.registerButton.Text = "Register Student";
			this.registerButton.UseVisualStyleBackColor = false;
			this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
			// 
			// frmStudentRegistration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.ClientSize = new System.Drawing.Size(338, 512);
			this.Controls.Add(this.registerButton);
			this.Controls.Add(this.yearSelect);
			this.Controls.Add(this.monthSelect);
			this.Controls.Add(this.daySelect);
			this.Controls.Add(this.dateSelect);
			this.Controls.Add(this.genderSelect);
			this.Controls.Add(this.femaleRadio);
			this.Controls.Add(this.maleRadio);
			this.Controls.Add(this.middleName);
			this.Controls.Add(this.firstName);
			this.Controls.Add(this.lastName);
			this.Controls.Add(this.headline);
			this.Controls.Add(this.middleNameBox);
			this.Controls.Add(this.firstNameBox);
			this.Controls.Add(this.lastNameBox);
			this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "frmStudentRegistration";
			this.Text = "Student Registration";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox lastNameBox;
		private System.Windows.Forms.TextBox firstNameBox;
		private System.Windows.Forms.TextBox middleNameBox;
		private System.Windows.Forms.Label headline;
		private System.Windows.Forms.Label lastName;
		private System.Windows.Forms.Label firstName;
		private System.Windows.Forms.Label middleName;
		private System.Windows.Forms.RadioButton maleRadio;
		private System.Windows.Forms.RadioButton femaleRadio;
		private System.Windows.Forms.Label genderSelect;
		private System.Windows.Forms.Label dateSelect;
		private System.Windows.Forms.ComboBox daySelect;
		private System.Windows.Forms.ComboBox monthSelect;
		private System.Windows.Forms.ComboBox yearSelect;
		private System.Windows.Forms.Button registerButton;
	}
}

