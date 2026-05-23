namespace EdoriaCashierApplication
{
    partial class frmPurchaseDiscountedItem
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblChangeLabel;
        private System.Windows.Forms.Label lblChange;

        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPayment;

        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnSubmit;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblChangeLabel = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();

            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPayment = new System.Windows.Forms.TextBox();

            this.btnCompute = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 24);
            this.lblTitle.Text = "Purchase Discounted Item";

            // lblItem
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(35, 75);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(30, 13);
            this.lblItem.Text = "Item:";

            // txtItem
            this.txtItem.Location = new System.Drawing.Point(130, 72);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(180, 20);

            // lblPrice
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(35, 110);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.Text = "Price:";

            // txtPrice
            this.txtPrice.Location = new System.Drawing.Point(130, 107);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(180, 20);

            // lblDiscount
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(35, 145);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(67, 13);
            this.lblDiscount.Text = "Discount (%):";

            // txtDiscount
            this.txtDiscount.Location = new System.Drawing.Point(130, 142);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(180, 20);

            // lblQuantity
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(35, 180);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.Text = "Quantity:";

            // txtQuantity
            this.txtQuantity.Location = new System.Drawing.Point(130, 177);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(180, 20);

            // btnCompute
            this.btnCompute.Location = new System.Drawing.Point(130, 215);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(180, 30);
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);

            // lblTotalLabel
            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.Location = new System.Drawing.Point(35, 265);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(73, 13);
            this.lblTotalLabel.Text = "Total Amount:";

            // lblTotalAmount
            this.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalAmount.Location = new System.Drawing.Point(130, 260);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(180, 25);
            this.lblTotalAmount.Text = "0.00";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // lblPayment
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(35, 310);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(51, 13);
            this.lblPayment.Text = "Payment:";

            // txtPayment
            this.txtPayment.Location = new System.Drawing.Point(130, 307);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(180, 20);

            // btnSubmit
            this.btnSubmit.Location = new System.Drawing.Point(130, 345);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(180, 30);
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // lblChangeLabel
            this.lblChangeLabel.AutoSize = true;
            this.lblChangeLabel.Location = new System.Drawing.Point(35, 395);
            this.lblChangeLabel.Name = "lblChangeLabel";
            this.lblChangeLabel.Size = new System.Drawing.Size(47, 13);
            this.lblChangeLabel.Text = "Change:";

            // lblChange
            this.lblChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblChange.Location = new System.Drawing.Point(130, 390);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(180, 25);
            this.lblChange.Text = "0.00";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // frmPurchaseDiscountedItem
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 455);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.lblTotalLabel);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblChangeLabel);
            this.Controls.Add(this.lblChange);
            this.Name = "frmPurchaseDiscountedItem";
            this.Text = "Cashier Application";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}