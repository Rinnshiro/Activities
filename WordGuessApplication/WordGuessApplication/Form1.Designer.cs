namespace WordGuessApplication
{
	partial class frmGuessWord
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
			this.btnGuess = new System.Windows.Forms.Button();
			this.wrongGuess = new System.Windows.Forms.ListBox();
			this.displayWordToGuess = new System.Windows.Forms.Label();
			this.txtYourGuess = new System.Windows.Forms.TextBox();
			this.border1 = new System.Windows.Forms.Panel();
			this.wrongGuesslabel = new System.Windows.Forms.Label();
			this.border2 = new System.Windows.Forms.Panel();
			this.btnHint = new System.Windows.Forms.Button();
			this.hintCount = new System.Windows.Forms.Label();
			this.border1.SuspendLayout();
			this.border2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnGuess
			// 
			this.btnGuess.BackColor = System.Drawing.Color.Gold;
			this.btnGuess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnGuess.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuess.Location = new System.Drawing.Point(31, 141);
			this.btnGuess.Name = "btnGuess";
			this.btnGuess.Size = new System.Drawing.Size(142, 45);
			this.btnGuess.TabIndex = 0;
			this.btnGuess.Text = "Guess";
			this.btnGuess.UseVisualStyleBackColor = false;
			this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
			// 
			// wrongGuess
			// 
			this.wrongGuess.BackColor = System.Drawing.Color.LightYellow;
			this.wrongGuess.FormattingEnabled = true;
			this.wrongGuess.ItemHeight = 23;
			this.wrongGuess.Location = new System.Drawing.Point(365, 71);
			this.wrongGuess.Name = "wrongGuess";
			this.wrongGuess.Size = new System.Drawing.Size(181, 165);
			this.wrongGuess.TabIndex = 1;
			this.wrongGuess.SelectedIndexChanged += new System.EventHandler(this.wrongGuess_SelectedIndexChanged);
			// 
			// displayWordToGuess
			// 
			this.displayWordToGuess.AutoSize = true;
			this.displayWordToGuess.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.displayWordToGuess.Location = new System.Drawing.Point(114, 30);
			this.displayWordToGuess.Name = "displayWordToGuess";
			this.displayWordToGuess.Size = new System.Drawing.Size(84, 32);
			this.displayWordToGuess.TabIndex = 2;
			this.displayWordToGuess.Text = "Word";
			this.displayWordToGuess.UseWaitCursor = true;
			this.displayWordToGuess.Visible = false;
			this.displayWordToGuess.Click += new System.EventHandler(this.displayWordToGuess_Click);
			// 
			// txtYourGuess
			// 
			this.txtYourGuess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtYourGuess.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtYourGuess.Location = new System.Drawing.Point(31, 104);
			this.txtYourGuess.Name = "txtYourGuess";
			this.txtYourGuess.Size = new System.Drawing.Size(291, 31);
			this.txtYourGuess.TabIndex = 3;
			this.txtYourGuess.TextChanged += new System.EventHandler(this.txtYourGuess_TextChanged);
			// 
			// border1
			// 
			this.border1.BackColor = System.Drawing.Color.Bisque;
			this.border1.Controls.Add(this.displayWordToGuess);
			this.border1.Location = new System.Drawing.Point(12, 12);
			this.border1.Name = "border1";
			this.border1.Size = new System.Drawing.Size(338, 86);
			this.border1.TabIndex = 4;
			// 
			// wrongGuesslabel
			// 
			this.wrongGuesslabel.AutoSize = true;
			this.wrongGuesslabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.wrongGuesslabel.Location = new System.Drawing.Point(32, 12);
			this.wrongGuesslabel.Name = "wrongGuesslabel";
			this.wrongGuesslabel.Size = new System.Drawing.Size(117, 23);
			this.wrongGuesslabel.TabIndex = 5;
			this.wrongGuesslabel.Text = "Wrong Guess";
			// 
			// border2
			// 
			this.border2.BackColor = System.Drawing.Color.Bisque;
			this.border2.Controls.Add(this.wrongGuesslabel);
			this.border2.Location = new System.Drawing.Point(365, 12);
			this.border2.Name = "border2";
			this.border2.Size = new System.Drawing.Size(181, 53);
			this.border2.TabIndex = 6;
			// 
			// btnHint
			// 
			this.btnHint.BackColor = System.Drawing.Color.Gold;
			this.btnHint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnHint.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHint.Location = new System.Drawing.Point(180, 141);
			this.btnHint.Name = "btnHint";
			this.btnHint.Size = new System.Drawing.Size(142, 45);
			this.btnHint.TabIndex = 7;
			this.btnHint.Text = "Hint";
			this.btnHint.UseVisualStyleBackColor = false;
			this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
			// 
			// hintCount
			// 
			this.hintCount.AutoSize = true;
			this.hintCount.BackColor = System.Drawing.Color.Wheat;
			this.hintCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.hintCount.Location = new System.Drawing.Point(179, 189);
			this.hintCount.Name = "hintCount";
			this.hintCount.Size = new System.Drawing.Size(143, 25);
			this.hintCount.TabIndex = 8;
			this.hintCount.Text = "Hint Remaining: ";
			this.hintCount.Click += new System.EventHandler(this.hintCount_Click);
			// 
			// frmGuessWord
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(588, 310);
			this.Controls.Add(this.hintCount);
			this.Controls.Add(this.btnHint);
			this.Controls.Add(this.border2);
			this.Controls.Add(this.border1);
			this.Controls.Add(this.txtYourGuess);
			this.Controls.Add(this.wrongGuess);
			this.Controls.Add(this.btnGuess);
			this.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "frmGuessWord";
			this.Text = "Guess The Word";
			this.border1.ResumeLayout(false);
			this.border1.PerformLayout();
			this.border2.ResumeLayout(false);
			this.border2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGuess;
		private System.Windows.Forms.ListBox wrongGuess;
		private System.Windows.Forms.Label displayWordToGuess;
		private System.Windows.Forms.TextBox txtYourGuess;
		private System.Windows.Forms.Panel border1;
		private System.Windows.Forms.Label wrongGuesslabel;
		private System.Windows.Forms.Panel border2;
		private System.Windows.Forms.Button btnHint;
		private System.Windows.Forms.Label hintCount;
	}
}

