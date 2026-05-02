namespace Quiz09
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Button btnComputeDiameter;
        private System.Windows.Forms.Label lblDiameterResult;

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnCreateProduct;
        private System.Windows.Forms.Label lblProductResult;

        private System.Windows.Forms.Button btnCreatePerson;
        private System.Windows.Forms.Label lblPersonResult;

        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label lblAccountResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblRadius = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.btnComputeDiameter = new System.Windows.Forms.Button();
            this.lblDiameterResult = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.lblProductResult = new System.Windows.Forms.Label();
            this.btnCreatePerson = new System.Windows.Forms.Button();
            this.lblPersonResult = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.lblAccountResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(22, 24);
            this.lblRadius.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(43, 13);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Radius:";
            // 
            // txtRadius
            // 
            this.txtRadius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRadius.Location = new System.Drawing.Point(112, 22);
            this.txtRadius.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(114, 20);
            this.txtRadius.TabIndex = 1;
            // 
            // btnComputeDiameter
            // 
            this.btnComputeDiameter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnComputeDiameter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComputeDiameter.Location = new System.Drawing.Point(240, 20);
            this.btnComputeDiameter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnComputeDiameter.Name = "btnComputeDiameter";
            this.btnComputeDiameter.Size = new System.Drawing.Size(112, 24);
            this.btnComputeDiameter.TabIndex = 2;
            this.btnComputeDiameter.Text = "Compute Diameter";
            this.btnComputeDiameter.UseVisualStyleBackColor = false;
            this.btnComputeDiameter.Click += new System.EventHandler(this.btnComputeDiameter_Click);
            // 
            // lblDiameterResult
            // 
            this.lblDiameterResult.AutoSize = true;
            this.lblDiameterResult.Location = new System.Drawing.Point(112, 49);
            this.lblDiameterResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiameterResult.Name = "lblDiameterResult";
            this.lblDiameterResult.Size = new System.Drawing.Size(52, 13);
            this.lblDiameterResult.TabIndex = 3;
            this.lblDiameterResult.Text = "Diameter:";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(22, 89);
            this.lblCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(35, 13);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "Code:";
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Location = new System.Drawing.Point(112, 87);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(114, 20);
            this.txtCode.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(22, 118);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Location = new System.Drawing.Point(112, 115);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(114, 20);
            this.txtDescription.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(22, 146);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Location = new System.Drawing.Point(112, 144);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(114, 20);
            this.txtPrice.TabIndex = 9;
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateProduct.Location = new System.Drawing.Point(240, 114);
            this.btnCreateProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(112, 24);
            this.btnCreateProduct.TabIndex = 10;
            this.btnCreateProduct.Text = "Create Product";
            this.btnCreateProduct.UseVisualStyleBackColor = false;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // lblProductResult
            // 
            this.lblProductResult.AutoSize = true;
            this.lblProductResult.Location = new System.Drawing.Point(112, 175);
            this.lblProductResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductResult.Name = "lblProductResult";
            this.lblProductResult.Size = new System.Drawing.Size(68, 13);
            this.lblProductResult.TabIndex = 11;
            this.lblProductResult.Text = "Product Info:";
            // 
            // btnCreatePerson
            // 
            this.btnCreatePerson.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreatePerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreatePerson.Location = new System.Drawing.Point(22, 219);
            this.btnCreatePerson.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreatePerson.Name = "btnCreatePerson";
            this.btnCreatePerson.Size = new System.Drawing.Size(112, 24);
            this.btnCreatePerson.TabIndex = 12;
            this.btnCreatePerson.Text = "Create Person";
            this.btnCreatePerson.UseVisualStyleBackColor = false;
            this.btnCreatePerson.Click += new System.EventHandler(this.btnCreatePerson_Click);
            // 
            // lblPersonResult
            // 
            this.lblPersonResult.AutoSize = true;
            this.lblPersonResult.Location = new System.Drawing.Point(150, 225);
            this.lblPersonResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersonResult.Name = "lblPersonResult";
            this.lblPersonResult.Size = new System.Drawing.Size(43, 13);
            this.lblPersonResult.TabIndex = 13;
            this.lblPersonResult.Text = "Person:";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(22, 276);
            this.lblAccountNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(90, 13);
            this.lblAccountNumber.TabIndex = 14;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccountNumber.Location = new System.Drawing.Point(112, 274);
            this.txtAccountNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(114, 20);
            this.txtAccountNumber.TabIndex = 15;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateAccount.Location = new System.Drawing.Point(240, 272);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(112, 24);
            this.btnCreateAccount.TabIndex = 16;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // lblAccountResult
            // 
            this.lblAccountResult.AutoSize = true;
            this.lblAccountResult.Location = new System.Drawing.Point(112, 305);
            this.lblAccountResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountResult.Name = "lblAccountResult";
            this.lblAccountResult.Size = new System.Drawing.Size(50, 13);
            this.lblAccountResult.TabIndex = 17;
            this.lblAccountResult.Text = "Account:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(412, 349);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.btnComputeDiameter);
            this.Controls.Add(this.lblDiameterResult);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnCreateProduct);
            this.Controls.Add(this.lblProductResult);
            this.Controls.Add(this.btnCreatePerson);
            this.Controls.Add(this.lblPersonResult);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.lblAccountResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Quiz09";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
