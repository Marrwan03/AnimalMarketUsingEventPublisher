namespace AnimalMarketUsingEventPublisher
{
    partial class butcher
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAnimalAmount = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUnSubscribe = new System.Windows.Forms.Button();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ctrlAnimalInfo1 = new AnimalMarketUsingEventPublisher.ctrlAnimalInfo();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnStartKill = new System.Windows.Forms.Button();
            this.lblPercentProcess = new System.Windows.Forms.Label();
            this.pbProcess = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbAnimalAmount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AnimalMarketUsingEventPublisher.Properties.Resources.SlaughterMan;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "butcher Screen";
            // 
            // gbAnimalAmount
            // 
            this.gbAnimalAmount.Controls.Add(this.label7);
            this.gbAnimalAmount.Controls.Add(this.label6);
            this.gbAnimalAmount.Controls.Add(this.label5);
            this.gbAnimalAmount.Controls.Add(this.label4);
            this.gbAnimalAmount.Controls.Add(this.label2);
            this.gbAnimalAmount.Controls.Add(this.label3);
            this.gbAnimalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAnimalAmount.ForeColor = System.Drawing.Color.White;
            this.gbAnimalAmount.Location = new System.Drawing.Point(490, 12);
            this.gbAnimalAmount.Name = "gbAnimalAmount";
            this.gbAnimalAmount.Size = new System.Drawing.Size(218, 117);
            this.gbAnimalAmount.TabIndex = 9;
            this.gbAnimalAmount.TabStop = false;
            this.gbAnimalAmount.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(117, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "15 $";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(117, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "35 $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(117, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "50 $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sheep : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cow : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Camel : ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AnimalMarketUsingEventPublisher.Properties.Resources.Slaughterhouse;
            this.pictureBox2.Location = new System.Drawing.Point(105, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUnSubscribe);
            this.groupBox1.Controls.Add(this.btnSubscribe);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(490, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 105);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer setting";
            // 
            // btnUnSubscribe
            // 
            this.btnUnSubscribe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnSubscribe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnSubscribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnSubscribe.ForeColor = System.Drawing.Color.Black;
            this.btnUnSubscribe.Location = new System.Drawing.Point(46, 67);
            this.btnUnSubscribe.Name = "btnUnSubscribe";
            this.btnUnSubscribe.Size = new System.Drawing.Size(116, 29);
            this.btnUnSubscribe.TabIndex = 13;
            this.btnUnSubscribe.Text = "Un Subscribe";
            this.btnUnSubscribe.UseVisualStyleBackColor = true;
            this.btnUnSubscribe.Click += new System.EventHandler(this.btnUnSubscribe_Click);
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubscribe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubscribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubscribe.ForeColor = System.Drawing.Color.Black;
            this.btnSubscribe.Location = new System.Drawing.Point(58, 32);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(95, 29);
            this.btnSubscribe.TabIndex = 12;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMoney);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(490, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 68);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "butcher Money";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.ForeColor = System.Drawing.Color.Black;
            this.lblMoney.Location = new System.Drawing.Point(144, 35);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(28, 18);
            this.lblMoney.TabIndex = 4;
            this.lblMoney.Text = "0 $";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "In Your Card : ";
            // 
            // ctrlAnimalInfo1
            // 
            this.ctrlAnimalInfo1.BackColor = System.Drawing.Color.CadetBlue;
            this.ctrlAnimalInfo1.Location = new System.Drawing.Point(5, 330);
            this.ctrlAnimalInfo1.Name = "ctrlAnimalInfo1";
            this.ctrlAnimalInfo1.Size = new System.Drawing.Size(703, 216);
            this.ctrlAnimalInfo1.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnStartKill);
            this.groupBox3.Controls.Add(this.lblPercentProcess);
            this.groupBox3.Controls.Add(this.pbProcess);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(458, 207);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Slaughterhouse Center";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnStartKill
            // 
            this.btnStartKill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartKill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartKill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartKill.ForeColor = System.Drawing.Color.Black;
            this.btnStartKill.Location = new System.Drawing.Point(167, 131);
            this.btnStartKill.Name = "btnStartKill";
            this.btnStartKill.Size = new System.Drawing.Size(95, 29);
            this.btnStartKill.TabIndex = 14;
            this.btnStartKill.Text = "Start To Kill";
            this.btnStartKill.UseVisualStyleBackColor = true;
            this.btnStartKill.Click += new System.EventHandler(this.btnStartKill_Click);
            // 
            // lblPercentProcess
            // 
            this.lblPercentProcess.AutoSize = true;
            this.lblPercentProcess.Location = new System.Drawing.Point(195, 78);
            this.lblPercentProcess.Name = "lblPercentProcess";
            this.lblPercentProcess.Size = new System.Drawing.Size(41, 18);
            this.lblPercentProcess.TabIndex = 1;
            this.lblPercentProcess.Text = "00 %";
            // 
            // pbProcess
            // 
            this.pbProcess.Location = new System.Drawing.Point(109, 102);
            this.pbProcess.Name = "pbProcess";
            this.pbProcess.Size = new System.Drawing.Size(225, 23);
            this.pbProcess.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // butcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(718, 549);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ctrlAnimalInfo1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAnimalAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "butcher";
            this.Text = "butcher";
            this.Load += new System.EventHandler(this.Slaughterhouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbAnimalAmount.ResumeLayout(false);
            this.gbAnimalAmount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbAnimalAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUnSubscribe;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label label8;
        private ctrlAnimalInfo ctrlAnimalInfo1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblPercentProcess;
        private System.Windows.Forms.ProgressBar pbProcess;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStartKill;
    }
}