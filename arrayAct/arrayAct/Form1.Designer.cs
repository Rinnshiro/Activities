namespace arrayAct
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.classmateNameList = new System.Windows.Forms.ListBox();
            this.showAll = new System.Windows.Forms.Button();
            this.rowandcolumnsTexBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // classmateNameList
            // 
            this.classmateNameList.FormattingEnabled = true;
            this.classmateNameList.ItemHeight = 19;
            this.classmateNameList.Location = new System.Drawing.Point(45, 50);
            this.classmateNameList.Name = "classmateNameList";
            this.classmateNameList.Size = new System.Drawing.Size(162, 156);
            this.classmateNameList.TabIndex = 0;
            // 
            // showAll
            // 
            this.showAll.Location = new System.Drawing.Point(125, 236);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(153, 54);
            this.showAll.TabIndex = 1;
            this.showAll.Text = "Click To Show";
            this.showAll.UseVisualStyleBackColor = true;
            this.showAll.Click += new System.EventHandler(this.showAll_Click);
            // 
            // rowandcolumnsTexBox
            // 
            this.rowandcolumnsTexBox.Location = new System.Drawing.Point(213, 50);
            this.rowandcolumnsTexBox.Multiline = true;
            this.rowandcolumnsTexBox.Name = "rowandcolumnsTexBox";
            this.rowandcolumnsTexBox.Size = new System.Drawing.Size(162, 116);
            this.rowandcolumnsTexBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 407);
            this.Controls.Add(this.rowandcolumnsTexBox);
            this.Controls.Add(this.showAll);
            this.Controls.Add(this.classmateNameList);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox classmateNameList;
        private System.Windows.Forms.Button showAll;
        private System.Windows.Forms.TextBox rowandcolumnsTexBox;
    }
}

