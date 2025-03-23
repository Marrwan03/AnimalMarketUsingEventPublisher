namespace AnimalMarketUsingEventPublisher
{
    partial class ctrlBillinfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.lblTotalBillAmount = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ctrlAnimalInfo1 = new AnimalMarketUsingEventPublisher.ctrlAnimalInfo();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBillDate);
            this.groupBox1.Controls.Add(this.lblTotalBillAmount);
            this.groupBox1.Controls.Add(this.lblTax);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ctrlAnimalInfo1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 498);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Butcher Bill Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblBillDate
            // 
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.ForeColor = System.Drawing.Color.Black;
            this.lblBillDate.Location = new System.Drawing.Point(205, 162);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(112, 18);
            this.lblBillDate.TabIndex = 8;
            this.lblBillDate.Text = "[ ?? / ?? / ???? ]";
            // 
            // lblTotalBillAmount
            // 
            this.lblTotalBillAmount.AutoSize = true;
            this.lblTotalBillAmount.ForeColor = System.Drawing.Color.Black;
            this.lblTotalBillAmount.Location = new System.Drawing.Point(205, 127);
            this.lblTotalBillAmount.Name = "lblTotalBillAmount";
            this.lblTotalBillAmount.Size = new System.Drawing.Size(48, 18);
            this.lblTotalBillAmount.TabIndex = 7;
            this.lblTotalBillAmount.Text = "[ ??? ]";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.ForeColor = System.Drawing.Color.Black;
            this.lblTax.Location = new System.Drawing.Point(205, 92);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(48, 18);
            this.lblTax.TabIndex = 6;
            this.lblTax.Text = "[ ??? ]";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(205, 57);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 18);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "[ ??? ]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bill Date : ";
            // 
            // ctrlAnimalInfo1
            // 
            this.ctrlAnimalInfo1.BackColor = System.Drawing.Color.CadetBlue;
            this.ctrlAnimalInfo1.Font = new System.Drawing.Font("Onyx", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlAnimalInfo1.Location = new System.Drawing.Point(7, 184);
            this.ctrlAnimalInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlAnimalInfo1.Name = "ctrlAnimalInfo1";
            this.ctrlAnimalInfo1.Size = new System.Drawing.Size(469, 298);
            this.ctrlAnimalInfo1.TabIndex = 3;
            this.ctrlAnimalInfo1.Load += new System.EventHandler(this.ctrlAnimalInfo1_Load);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Bill Amount : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tax : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price : ";
            // 
            // ctrlBillinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlBillinfo";
            this.Size = new System.Drawing.Size(515, 516);
            this.Load += new System.EventHandler(this.ctrlBillinfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private ctrlAnimalInfo ctrlAnimalInfo1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.Label lblTotalBillAmount;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblPrice;
    }
}
