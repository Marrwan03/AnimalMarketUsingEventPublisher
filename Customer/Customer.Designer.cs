namespace AnimalMarketUsingEventPublisher
{
    partial class Customer
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
            this.label4 = new System.Windows.Forms.Label();
            this.lblBuy = new System.Windows.Forms.Button();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.btnUnSubscribe = new System.Windows.Forms.Button();
            this.ctrlAnimalInfo1 = new AnimalMarketUsingEventPublisher.ctrlAnimalInfo();
            this.ctrlBillinfo1 = new AnimalMarketUsingEventPublisher.ctrlBillinfo();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSubScriveButcher = new System.Windows.Forms.Button();
            this.btnUnSubscribeButcher = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Customer Screen";
            // 
            // lblBuy
            // 
            this.lblBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuy.Location = new System.Drawing.Point(314, 103);
            this.lblBuy.Name = "lblBuy";
            this.lblBuy.Size = new System.Drawing.Size(84, 29);
            this.lblBuy.TabIndex = 9;
            this.lblBuy.Text = "Buy it";
            this.lblBuy.UseVisualStyleBackColor = true;
            this.lblBuy.Click += new System.EventHandler(this.lblBuy_Click);
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubscribe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubscribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubscribe.ForeColor = System.Drawing.Color.Black;
            this.btnSubscribe.Location = new System.Drawing.Point(25, 43);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(95, 29);
            this.btnSubscribe.TabIndex = 10;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // btnUnSubscribe
            // 
            this.btnUnSubscribe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnSubscribe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnSubscribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnSubscribe.ForeColor = System.Drawing.Color.Black;
            this.btnUnSubscribe.Location = new System.Drawing.Point(15, 78);
            this.btnUnSubscribe.Name = "btnUnSubscribe";
            this.btnUnSubscribe.Size = new System.Drawing.Size(116, 29);
            this.btnUnSubscribe.TabIndex = 11;
            this.btnUnSubscribe.Text = "Un Subscribe";
            this.btnUnSubscribe.UseVisualStyleBackColor = true;
            this.btnUnSubscribe.Click += new System.EventHandler(this.OnSubscribe_Click);
            // 
            // ctrlAnimalInfo1
            // 
            this.ctrlAnimalInfo1.BackColor = System.Drawing.Color.CadetBlue;
            this.ctrlAnimalInfo1.Location = new System.Drawing.Point(12, 126);
            this.ctrlAnimalInfo1.Name = "ctrlAnimalInfo1";
            this.ctrlAnimalInfo1.Size = new System.Drawing.Size(703, 216);
            this.ctrlAnimalInfo1.TabIndex = 8;
            // 
            // ctrlBillinfo1
            // 
            this.ctrlBillinfo1.BackColor = System.Drawing.Color.CadetBlue;
            this.ctrlBillinfo1.Location = new System.Drawing.Point(721, 2);
            this.ctrlBillinfo1.Name = "ctrlBillinfo1";
            this.ctrlBillinfo1.Size = new System.Drawing.Size(515, 516);
            this.ctrlBillinfo1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSubscribe);
            this.groupBox1.Controls.Add(this.btnUnSubscribe);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(363, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 141);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seller Setting";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSubScriveButcher);
            this.groupBox2.Controls.Add(this.btnUnSubscribeButcher);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(205, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 141);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Butcher Setting";
            // 
            // btnSubScriveButcher
            // 
            this.btnSubScriveButcher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubScriveButcher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubScriveButcher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubScriveButcher.ForeColor = System.Drawing.Color.Black;
            this.btnSubScriveButcher.Location = new System.Drawing.Point(27, 43);
            this.btnSubScriveButcher.Name = "btnSubScriveButcher";
            this.btnSubScriveButcher.Size = new System.Drawing.Size(95, 29);
            this.btnSubScriveButcher.TabIndex = 10;
            this.btnSubScriveButcher.Text = "Subscribe";
            this.btnSubScriveButcher.UseVisualStyleBackColor = true;
            this.btnSubScriveButcher.Click += new System.EventHandler(this.btnSubScriveButcher_Click);
            // 
            // btnUnSubscribeButcher
            // 
            this.btnUnSubscribeButcher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnSubscribeButcher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnSubscribeButcher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnSubscribeButcher.ForeColor = System.Drawing.Color.Black;
            this.btnUnSubscribeButcher.Location = new System.Drawing.Point(17, 78);
            this.btnUnSubscribeButcher.Name = "btnUnSubscribeButcher";
            this.btnUnSubscribeButcher.Size = new System.Drawing.Size(116, 29);
            this.btnUnSubscribeButcher.TabIndex = 11;
            this.btnUnSubscribeButcher.Text = "Un Subscribe";
            this.btnUnSubscribeButcher.UseVisualStyleBackColor = true;
            this.btnUnSubscribeButcher.Click += new System.EventHandler(this.btnUnSubscribeButcher_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1233, 516);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlBillinfo1);
            this.Controls.Add(this.lblBuy);
            this.Controls.Add(this.ctrlAnimalInfo1);
            this.Controls.Add(this.label4);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private ctrlAnimalInfo ctrlAnimalInfo1;
        private System.Windows.Forms.Button lblBuy;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Button btnUnSubscribe;
        private ctrlBillinfo ctrlBillinfo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSubScriveButcher;
        private System.Windows.Forms.Button btnUnSubscribeButcher;
    }
}