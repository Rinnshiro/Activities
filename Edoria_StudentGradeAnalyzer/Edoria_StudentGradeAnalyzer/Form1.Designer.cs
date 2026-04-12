namespace Edoria_StudentGradeAnalyzer
{
	partial class Form1
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

		private void InitializeComponent()
		{
			this.lblStudentNumber = new System.Windows.Forms.Label();
			this.lblStudentName = new System.Windows.Forms.Label();
			this.lblPrelim = new System.Windows.Forms.Label();
			this.lblMidterm = new System.Windows.Forms.Label();
			this.lblFinal = new System.Windows.Forms.Label();
			this.txtStudentNumber = new System.Windows.Forms.TextBox();
			this.txtStudentName = new System.Windows.Forms.TextBox();
			this.txtPrelim = new System.Windows.Forms.TextBox();
			this.txtMidterm = new System.Windows.Forms.TextBox();
			this.txtFinal = new System.Windows.Forms.TextBox();
			this.btnCompute = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.lstOutput = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// lblStudentNumber
			// 
			this.lblStudentNumber.AutoSize = true;
			this.lblStudentNumber.Location = new System.Drawing.Point(28, 25);
			this.lblStudentNumber.Name = "lblStudentNumber";
			this.lblStudentNumber.Size = new System.Drawing.Size(95, 13);
			this.lblStudentNumber.TabIndex = 0;
			this.lblStudentNumber.Text = "Student Number:";
			// 
			// lblStudentName
			// 
			this.lblStudentName.AutoSize = true;
			this.lblStudentName.Location = new System.Drawing.Point(28, 60);
			this.lblStudentName.Name = "lblStudentName";
			this.lblStudentName.Size = new System.Drawing.Size(83, 13);
			this.lblStudentName.TabIndex = 1;
			this.lblStudentName.Text = "Student Name:";
			// 
			// lblPrelim
			// 
			this.lblPrelim.AutoSize = true;
			this.lblPrelim.Location = new System.Drawing.Point(28, 95);
			this.lblPrelim.Name = "lblPrelim";
			this.lblPrelim.Size = new System.Drawing.Size(75, 13);
			this.lblPrelim.TabIndex = 2;
			this.lblPrelim.Text = "Prelim Grade:";
			// 
			// lblMidterm
			// 
			this.lblMidterm.AutoSize = true;
			this.lblMidterm.Location = new System.Drawing.Point(28, 130);
			this.lblMidterm.Name = "lblMidterm";
			this.lblMidterm.Size = new System.Drawing.Size(87, 13);
			this.lblMidterm.TabIndex = 3;
			this.lblMidterm.Text = "Midterm Grade:";
			// 
			// lblFinal
			// 
			this.lblFinal.AutoSize = true;
			this.lblFinal.Location = new System.Drawing.Point(28, 165);
			this.lblFinal.Name = "lblFinal";
			this.lblFinal.Size = new System.Drawing.Size(69, 13);
			this.lblFinal.TabIndex = 4;
			this.lblFinal.Text = "Final Grade:";
			// 
			// txtStudentNumber
			// 
			this.txtStudentNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtStudentNumber.Location = new System.Drawing.Point(140, 22);
			this.txtStudentNumber.Name = "txtStudentNumber";
			this.txtStudentNumber.Size = new System.Drawing.Size(180, 22);
			this.txtStudentNumber.TabIndex = 5;
			// 
			// txtStudentName
			// 
			this.txtStudentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtStudentName.Location = new System.Drawing.Point(140, 57);
			this.txtStudentName.Name = "txtStudentName";
			this.txtStudentName.Size = new System.Drawing.Size(180, 22);
			this.txtStudentName.TabIndex = 6;
			// 
			// txtPrelim
			// 
			this.txtPrelim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPrelim.Location = new System.Drawing.Point(140, 92);
			this.txtPrelim.Name = "txtPrelim";
			this.txtPrelim.Size = new System.Drawing.Size(180, 22);
			this.txtPrelim.TabIndex = 7;
			// 
			// txtMidterm
			// 
			this.txtMidterm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMidterm.Location = new System.Drawing.Point(140, 127);
			this.txtMidterm.Name = "txtMidterm";
			this.txtMidterm.Size = new System.Drawing.Size(180, 22);
			this.txtMidterm.TabIndex = 8;
			// 
			// txtFinal
			// 
			this.txtFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFinal.Location = new System.Drawing.Point(140, 162);
			this.txtFinal.Name = "txtFinal";
			this.txtFinal.Size = new System.Drawing.Size(180, 22);
			this.txtFinal.TabIndex = 9;
			// 
			// btnCompute
			// 
			this.btnCompute.BackColor = System.Drawing.Color.Crimson;
			this.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCompute.Location = new System.Drawing.Point(31, 205);
			this.btnCompute.Name = "btnCompute";
			this.btnCompute.Size = new System.Drawing.Size(120, 35);
			this.btnCompute.TabIndex = 10;
			this.btnCompute.Text = "Compute";
			this.btnCompute.UseVisualStyleBackColor = false;
			this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.Crimson;
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClear.Location = new System.Drawing.Point(200, 205);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(120, 35);
			this.btnClear.TabIndex = 11;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// lstOutput
			// 
			this.lstOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lstOutput.FormattingEnabled = true;
			this.lstOutput.Location = new System.Drawing.Point(31, 260);
			this.lstOutput.Name = "lstOutput";
			this.lstOutput.Size = new System.Drawing.Size(289, 145);
			this.lstOutput.TabIndex = 12;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MistyRose;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(360, 430);
			this.Controls.Add(this.lstOutput);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnCompute);
			this.Controls.Add(this.txtFinal);
			this.Controls.Add(this.txtMidterm);
			this.Controls.Add(this.txtPrelim);
			this.Controls.Add(this.txtStudentName);
			this.Controls.Add(this.txtStudentNumber);
			this.Controls.Add(this.lblFinal);
			this.Controls.Add(this.lblMidterm);
			this.Controls.Add(this.lblPrelim);
			this.Controls.Add(this.lblStudentName);
			this.Controls.Add(this.lblStudentNumber);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Student Grade Analyzer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblStudentNumber;
		private System.Windows.Forms.Label lblStudentName;
		private System.Windows.Forms.Label lblPrelim;
		private System.Windows.Forms.Label lblMidterm;
		private System.Windows.Forms.Label lblFinal;
		private System.Windows.Forms.TextBox txtStudentNumber;
		private System.Windows.Forms.TextBox txtStudentName;
		private System.Windows.Forms.TextBox txtPrelim;
		private System.Windows.Forms.TextBox txtMidterm;
		private System.Windows.Forms.TextBox txtFinal;
		private System.Windows.Forms.Button btnCompute;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.ListBox lstOutput;
	}
}