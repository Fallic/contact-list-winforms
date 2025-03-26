namespace ContactList
{
    partial class AddContactForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblsdt = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExtraInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(100, 72);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(42, 13);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Họ tên:";
            this.lblname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblsdt
            // 
            this.lblsdt.AutoSize = true;
            this.lblsdt.Location = new System.Drawing.Point(103, 114);
            this.lblsdt.Name = "lblsdt";
            this.lblsdt.Size = new System.Drawing.Size(29, 13);
            this.lblsdt.TabIndex = 2;
            this.lblsdt.Text = "SDT";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(148, 224);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Lưu";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(148, 148);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email";
            // 
            // lblExtraInfo
            // 
            this.lblExtraInfo.AutoSize = true;
            this.lblExtraInfo.Location = new System.Drawing.Point(103, 26);
            this.lblExtraInfo.Name = "lblExtraInfo";
            this.lblExtraInfo.Size = new System.Drawing.Size(93, 13);
            this.lblExtraInfo.TabIndex = 7;
            this.lblExtraInfo.Text = "Thông tin bổ sung";
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 271);
            this.Controls.Add(this.lblExtraInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblsdt);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.textBox1);
            this.Name = "AddContactForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblsdt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExtraInfo;
    }
}