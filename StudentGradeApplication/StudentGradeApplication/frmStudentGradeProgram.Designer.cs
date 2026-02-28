namespace StudentGradeApplication
{
    partial class frmStudentGradeProgram
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentGradeProgram));
			this.name = new System.Windows.Forms.Label();
			this.englishText = new System.Windows.Forms.Label();
			this.mathText = new System.Windows.Forms.Label();
			this.scienceText = new System.Windows.Forms.Label();
			this.filipinoText = new System.Windows.Forms.Label();
			this.historyText = new System.Windows.Forms.Label();
			this.englishGrade = new System.Windows.Forms.TextBox();
			this.mathGrade = new System.Windows.Forms.TextBox();
			this.scienceGrade = new System.Windows.Forms.TextBox();
			this.filipinoGrade = new System.Windows.Forms.TextBox();
			this.historyGrade = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.nameBox = new System.Windows.Forms.TextBox();
			this.gradesText = new System.Windows.Forms.Label();
			this.resultOutput = new System.Windows.Forms.Label();
			this.statusResult = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// name
			// 
			this.name.AutoSize = true;
			this.name.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.name.Location = new System.Drawing.Point(50, 51);
			this.name.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(112, 40);
			this.name.TabIndex = 0;
			this.name.Text = "Name: ";
			this.name.Click += new System.EventHandler(this.name_Click);
			// 
			// englishText
			// 
			this.englishText.AutoSize = true;
			this.englishText.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.englishText.Location = new System.Drawing.Point(24, 172);
			this.englishText.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.englishText.Name = "englishText";
			this.englishText.Size = new System.Drawing.Size(121, 40);
			this.englishText.TabIndex = 1;
			this.englishText.Text = "English:";
			// 
			// mathText
			// 
			this.mathText.AutoSize = true;
			this.mathText.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mathText.Location = new System.Drawing.Point(39, 245);
			this.mathText.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.mathText.Name = "mathText";
			this.mathText.Size = new System.Drawing.Size(97, 40);
			this.mathText.TabIndex = 2;
			this.mathText.Text = "Math:";
			// 
			// scienceText
			// 
			this.scienceText.AutoSize = true;
			this.scienceText.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scienceText.Location = new System.Drawing.Point(12, 314);
			this.scienceText.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.scienceText.Name = "scienceText";
			this.scienceText.Size = new System.Drawing.Size(131, 40);
			this.scienceText.TabIndex = 3;
			this.scienceText.Text = "Science:";
			// 
			// filipinoText
			// 
			this.filipinoText.AutoSize = true;
			this.filipinoText.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.filipinoText.Location = new System.Drawing.Point(23, 392);
			this.filipinoText.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.filipinoText.Name = "filipinoText";
			this.filipinoText.Size = new System.Drawing.Size(122, 40);
			this.filipinoText.TabIndex = 4;
			this.filipinoText.Text = "Filipino:";
			// 
			// historyText
			// 
			this.historyText.AutoSize = true;
			this.historyText.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.historyText.Location = new System.Drawing.Point(12, 464);
			this.historyText.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.historyText.Name = "historyText";
			this.historyText.Size = new System.Drawing.Size(128, 40);
			this.historyText.TabIndex = 5;
			this.historyText.Text = "History:";
			// 
			// englishGrade
			// 
			this.englishGrade.Location = new System.Drawing.Point(141, 169);
			this.englishGrade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.englishGrade.Name = "englishGrade";
			this.englishGrade.Size = new System.Drawing.Size(155, 48);
			this.englishGrade.TabIndex = 6;
			this.englishGrade.TextChanged += new System.EventHandler(this.englishGrade_TextChanged);
			// 
			// mathGrade
			// 
			this.mathGrade.Location = new System.Drawing.Point(141, 237);
			this.mathGrade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mathGrade.Name = "mathGrade";
			this.mathGrade.Size = new System.Drawing.Size(155, 48);
			this.mathGrade.TabIndex = 7;
			this.mathGrade.TextChanged += new System.EventHandler(this.mathGrade_TextChanged);
			// 
			// scienceGrade
			// 
			this.scienceGrade.Location = new System.Drawing.Point(141, 314);
			this.scienceGrade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.scienceGrade.Name = "scienceGrade";
			this.scienceGrade.Size = new System.Drawing.Size(155, 48);
			this.scienceGrade.TabIndex = 8;
			this.scienceGrade.TextChanged += new System.EventHandler(this.scienceGrade_TextChanged);
			// 
			// filipinoGrade
			// 
			this.filipinoGrade.Location = new System.Drawing.Point(141, 389);
			this.filipinoGrade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.filipinoGrade.Name = "filipinoGrade";
			this.filipinoGrade.Size = new System.Drawing.Size(155, 48);
			this.filipinoGrade.TabIndex = 9;
			this.filipinoGrade.TextChanged += new System.EventHandler(this.filipinoGrade_TextChanged);
			// 
			// historyGrade
			// 
			this.historyGrade.Location = new System.Drawing.Point(141, 464);
			this.historyGrade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.historyGrade.Name = "historyGrade";
			this.historyGrade.Size = new System.Drawing.Size(155, 48);
			this.historyGrade.TabIndex = 10;
			this.historyGrade.TextChanged += new System.EventHandler(this.historyGrade_TextChanged);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(68, 550);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(228, 109);
			this.button1.TabIndex = 11;
			this.button1.Text = "Generate Average";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// nameBox
			// 
			this.nameBox.Location = new System.Drawing.Point(151, 48);
			this.nameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.nameBox.Name = "nameBox";
			this.nameBox.Size = new System.Drawing.Size(472, 48);
			this.nameBox.TabIndex = 12;
			this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
			// 
			// gradesText
			// 
			this.gradesText.AutoSize = true;
			this.gradesText.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gradesText.Location = new System.Drawing.Point(160, 115);
			this.gradesText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.gradesText.Name = "gradesText";
			this.gradesText.Size = new System.Drawing.Size(113, 40);
			this.gradesText.TabIndex = 13;
			this.gradesText.Text = "Grades";
			// 
			// resultOutput
			// 
			this.resultOutput.AutoSize = true;
			this.resultOutput.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resultOutput.Location = new System.Drawing.Point(414, 353);
			this.resultOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.resultOutput.Name = "resultOutput";
			this.resultOutput.Size = new System.Drawing.Size(18, 29);
			this.resultOutput.TabIndex = 14;
			this.resultOutput.Text = ".";
			// 
			// statusResult
			// 
			this.statusResult.AutoSize = true;
			this.statusResult.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusResult.Location = new System.Drawing.Point(472, 323);
			this.statusResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.statusResult.Name = "statusResult";
			this.statusResult.Size = new System.Drawing.Size(18, 29);
			this.statusResult.TabIndex = 15;
			this.statusResult.Text = ".";
			this.statusResult.Click += new System.EventHandler(this.label2_Click_1);
			// 
			// frmStudentGradeProgram
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 40F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleGreen;
			this.ClientSize = new System.Drawing.Size(1037, 678);
			this.Controls.Add(this.statusResult);
			this.Controls.Add(this.resultOutput);
			this.Controls.Add(this.gradesText);
			this.Controls.Add(this.nameBox);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.historyGrade);
			this.Controls.Add(this.filipinoGrade);
			this.Controls.Add(this.scienceGrade);
			this.Controls.Add(this.mathGrade);
			this.Controls.Add(this.englishGrade);
			this.Controls.Add(this.historyText);
			this.Controls.Add(this.filipinoText);
			this.Controls.Add(this.scienceText);
			this.Controls.Add(this.mathText);
			this.Controls.Add(this.englishText);
			this.Controls.Add(this.name);
			this.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
			this.Name = "frmStudentGradeProgram";
			this.Text = "Student Grade Application";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label englishText;
        private System.Windows.Forms.Label mathText;
        private System.Windows.Forms.Label scienceText;
        private System.Windows.Forms.Label filipinoText;
        private System.Windows.Forms.Label historyText;
        private System.Windows.Forms.TextBox englishGrade;
        private System.Windows.Forms.TextBox mathGrade;
        private System.Windows.Forms.TextBox scienceGrade;
        private System.Windows.Forms.TextBox filipinoGrade;
        private System.Windows.Forms.TextBox historyGrade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label gradesText;
        private System.Windows.Forms.Label resultOutput;
		private System.Windows.Forms.Label statusResult;
	}
}

