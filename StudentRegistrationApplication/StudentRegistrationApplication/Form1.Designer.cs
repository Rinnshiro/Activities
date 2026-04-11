namespace StudentRegistrationApplication
{
    partial class frmStudentRegistration
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

        #region

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
            this.label1 = new System.Windows.Forms.Label();
            this.selectProgrambox = new System.Windows.Forms.ComboBox();
            this.studentPictureBox = new System.Windows.Forms.PictureBox();
            this.uploadPhotoButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.studentPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(11, 84);
            this.lastNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(287, 27);
            this.lastNameBox.TabIndex = 0;
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(11, 148);
            this.firstNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(287, 27);
            this.firstNameBox.TabIndex = 1;
            // 
            // middleNameBox
            // 
            this.middleNameBox.Location = new System.Drawing.Point(11, 215);
            this.middleNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.middleNameBox.Name = "middleNameBox";
            this.middleNameBox.Size = new System.Drawing.Size(287, 27);
            this.middleNameBox.TabIndex = 2;
            // 
            // headline
            // 
            this.headline.AutoSize = true;
            this.headline.BackColor = System.Drawing.Color.Transparent;
            this.headline.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headline.Location = new System.Drawing.Point(8, 18);
            this.headline.Name = "headline";
            this.headline.Size = new System.Drawing.Size(255, 26);
            this.headline.TabIndex = 3;
            this.headline.Text = "Student Registration Form";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.BackColor = System.Drawing.Color.Transparent;
            this.lastName.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(7, 63);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(85, 19);
            this.lastName.TabIndex = 4;
            this.lastName.Text = "Last Name:";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.BackColor = System.Drawing.Color.Transparent;
            this.firstName.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(7, 126);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(87, 19);
            this.firstName.TabIndex = 5;
            this.firstName.Text = "First Name:";
            // 
            // middleName
            // 
            this.middleName.AutoSize = true;
            this.middleName.BackColor = System.Drawing.Color.Transparent;
            this.middleName.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleName.Location = new System.Drawing.Point(7, 193);
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(104, 19);
            this.middleName.TabIndex = 6;
            this.middleName.Text = "Middle Name:";
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.BackColor = System.Drawing.Color.Transparent;
            this.maleRadio.Location = new System.Drawing.Point(84, 259);
            this.maleRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(61, 23);
            this.maleRadio.TabIndex = 7;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = false;
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.BackColor = System.Drawing.Color.Transparent;
            this.femaleRadio.Location = new System.Drawing.Point(164, 259);
            this.femaleRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(76, 23);
            this.femaleRadio.TabIndex = 8;
            this.femaleRadio.TabStop = true;
            this.femaleRadio.Text = "Female";
            this.femaleRadio.UseVisualStyleBackColor = false;
            // 
            // genderSelect
            // 
            this.genderSelect.AutoSize = true;
            this.genderSelect.BackColor = System.Drawing.Color.Transparent;
            this.genderSelect.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderSelect.Location = new System.Drawing.Point(7, 262);
            this.genderSelect.Name = "genderSelect";
            this.genderSelect.Size = new System.Drawing.Size(63, 19);
            this.genderSelect.TabIndex = 9;
            this.genderSelect.Text = "Gender:";
            // 
            // dateSelect
            // 
            this.dateSelect.AutoSize = true;
            this.dateSelect.BackColor = System.Drawing.Color.Transparent;
            this.dateSelect.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSelect.Location = new System.Drawing.Point(7, 286);
            this.dateSelect.Name = "dateSelect";
            this.dateSelect.Size = new System.Drawing.Size(100, 19);
            this.dateSelect.TabIndex = 10;
            this.dateSelect.Text = "Date of birth:";
            // 
            // daySelect
            // 
            this.daySelect.FormattingEnabled = true;
            this.daySelect.Location = new System.Drawing.Point(11, 307);
            this.daySelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.daySelect.Name = "daySelect";
            this.daySelect.Size = new System.Drawing.Size(80, 27);
            this.daySelect.TabIndex = 11;
            this.daySelect.Text = "DD";
            // 
            // monthSelect
            // 
            this.monthSelect.FormattingEnabled = true;
            this.monthSelect.Location = new System.Drawing.Point(96, 307);
            this.monthSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monthSelect.Name = "monthSelect";
            this.monthSelect.Size = new System.Drawing.Size(80, 27);
            this.monthSelect.TabIndex = 12;
            this.monthSelect.Text = "MM";
            // 
            // yearSelect
            // 
            this.yearSelect.FormattingEnabled = true;
            this.yearSelect.Location = new System.Drawing.Point(182, 307);
            this.yearSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yearSelect.Name = "yearSelect";
            this.yearSelect.Size = new System.Drawing.Size(116, 27);
            this.yearSelect.TabIndex = 13;
            this.yearSelect.Text = "YYYY";
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Red;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerButton.Location = new System.Drawing.Point(11, 424);
            this.registerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(196, 31);
            this.registerButton.TabIndex = 14;
            this.registerButton.Text = "Register Student";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Program to apply:";
            // 
            // selectProgrambox
            // 
            this.selectProgrambox.FormattingEnabled = true;
            this.selectProgrambox.Location = new System.Drawing.Point(11, 374);
            this.selectProgrambox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectProgrambox.Name = "selectProgrambox";
            this.selectProgrambox.Size = new System.Drawing.Size(287, 27);
            this.selectProgrambox.TabIndex = 16;
            // 
            // studentPictureBox
            // 
            this.studentPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentPictureBox.Location = new System.Drawing.Point(320, 84);
            this.studentPictureBox.Name = "studentPictureBox";
            this.studentPictureBox.Size = new System.Drawing.Size(180, 180);
            this.studentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studentPictureBox.TabIndex = 17;
            this.studentPictureBox.TabStop = false;
            // 
            // uploadPhotoButton
            // 
            this.uploadPhotoButton.Location = new System.Drawing.Point(320, 270);
            this.uploadPhotoButton.Name = "uploadPhotoButton";
            this.uploadPhotoButton.Size = new System.Drawing.Size(180, 30);
            this.uploadPhotoButton.TabIndex = 18;
            this.uploadPhotoButton.Text = "Upload Photo";
            this.uploadPhotoButton.UseVisualStyleBackColor = true;
            this.uploadPhotoButton.Click += new System.EventHandler(this.uploadPhotoButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            // 
            // frmStudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentRegistrationApplication.Properties.Resources.pngtree_simple_gradient_on_gray_background_image_557021;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(525, 499);
            this.Controls.Add(this.studentPictureBox);
            this.Controls.Add(this.uploadPhotoButton);
            this.Controls.Add(this.selectProgrambox);
            this.Controls.Add(this.label1);
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
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmStudentRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration";
            this.Load += new System.EventHandler(this.frmStudentRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentPictureBox)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectProgrambox;
        private System.Windows.Forms.PictureBox studentPictureBox;
        private System.Windows.Forms.Button uploadPhotoButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
