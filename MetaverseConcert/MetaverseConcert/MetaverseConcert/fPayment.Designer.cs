namespace MetaverseConcert
{
    partial class fPayment
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.rdobank = new System.Windows.Forms.RadioButton();
            this.rdoCreditcard = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAname = new System.Windows.Forms.TextBox();
            this.txtANumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtcvv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExpired = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.rdobank.AutoSize = true;
            this.rdobank.Location = new System.Drawing.Point(240, 66);
            this.rdobank.Name = "rdobank";
            this.rdobank.Size = new System.Drawing.Size(152, 27);
            this.rdobank.TabIndex = 0;
            this.rdobank.TabStop = true;
            this.rdobank.Text = "หักบัญชีธนาคาร";
            this.rdobank.UseVisualStyleBackColor = true;
            this.rdobank.CheckedChanged += new System.EventHandler(this.rdobank_CheckedChanged);
            this.rdoCreditcard.AutoSize = true;
            this.rdoCreditcard.Location = new System.Drawing.Point(240, 217);
            this.rdoCreditcard.Name = "rdoCreditcard";
            this.rdoCreditcard.Size = new System.Drawing.Size(134, 27);
            this.rdoCreditcard.TabIndex = 1;
            this.rdoCreditcard.TabStop = true;
            this.rdoCreditcard.Text = "หักบัตรเครดิต";
            this.rdoCreditcard.UseVisualStyleBackColor = true;
            this.rdoCreditcard.CheckedChanged += new System.EventHandler(this.rdoCreditcard_CheckedChanged);
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "ชื่อบัญชี";
            this.txtAname.Location = new System.Drawing.Point(412, 111);
            this.txtAname.Name = "txtAname";
            this.txtAname.Size = new System.Drawing.Size(100, 30);
            this.txtAname.TabIndex = 3;
            this.txtANumber.Location = new System.Drawing.Point(412, 159);
            this.txtANumber.Name = "txtANumber";
            this.txtANumber.Size = new System.Drawing.Size(100, 30);
            this.txtANumber.TabIndex = 5;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "หมายเลขบัญชี";
            this.txtCno.Location = new System.Drawing.Point(412, 309);
            this.txtCno.Name = "txtCno";
            this.txtCno.Size = new System.Drawing.Size(100, 30);
            this.txtCno.TabIndex = 9;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "หมายเลขบัตร";
            this.txtCname.Location = new System.Drawing.Point(412, 261);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(100, 30);
            this.txtCname.TabIndex = 7;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "ชื่อผู้ถือบัตร"; 
            this.button1.Location = new System.Drawing.Point(274, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 81);
            this.button1.TabIndex = 10;
            this.button1.Text = "ยืนยันการจอง";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button2.Location = new System.Drawing.Point(459, 512);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 81);
            this.button2.TabIndex = 11;
            this.button2.Text = "ยกเลิกการจอง";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click); 
            this.txtcvv.Location = new System.Drawing.Point(412, 402);
            this.txtcvv.Name = "txtcvv";
            this.txtcvv.Size = new System.Drawing.Size(100, 30);
            this.txtcvv.TabIndex = 15; 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "หมายเลข CVV";
            this.txtExpired.Location = new System.Drawing.Point(412, 354);
            this.txtExpired.Name = "txtExpired";
            this.txtExpired.Size = new System.Drawing.Size(100, 30);
            this.txtExpired.TabIndex = 13; 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "วันที่หมดอายุ";
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 796);
            this.Controls.Add(this.txtcvv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtExpired);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtANumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdoCreditcard);
            this.Controls.Add(this.rdobank);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "fPayment";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdobank;
        private System.Windows.Forms.RadioButton rdoCreditcard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAname;
        private System.Windows.Forms.TextBox txtANumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtcvv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExpired;
        private System.Windows.Forms.Label label6;
    }
}