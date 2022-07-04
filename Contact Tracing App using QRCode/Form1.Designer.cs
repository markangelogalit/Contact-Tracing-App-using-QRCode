namespace Contact_Tracing_App_using_QRCode
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
            this.btnqr1 = new System.Windows.Forms.Button();
            this.cmbqr1 = new System.Windows.Forms.ComboBox();
            this.tbxqr1 = new System.Windows.Forms.TextBox();
            this.lblqr1 = new System.Windows.Forms.Label();
            this.pcbqr1 = new System.Windows.Forms.PictureBox();
            this.lblqr2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbqr1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnqr1
            // 
            this.btnqr1.Location = new System.Drawing.Point(98, 90);
            this.btnqr1.Name = "btnqr1";
            this.btnqr1.Size = new System.Drawing.Size(75, 23);
            this.btnqr1.TabIndex = 0;
            this.btnqr1.Text = "SCAN";
            this.btnqr1.UseVisualStyleBackColor = true;
            this.btnqr1.Click += new System.EventHandler(this.btnqr1_Click);
            // 
            // cmbqr1
            // 
            this.cmbqr1.FormattingEnabled = true;
            this.cmbqr1.Location = new System.Drawing.Point(426, 90);
            this.cmbqr1.Name = "cmbqr1";
            this.cmbqr1.Size = new System.Drawing.Size(334, 21);
            this.cmbqr1.TabIndex = 1;
            // 
            // tbxqr1
            // 
            this.tbxqr1.Location = new System.Drawing.Point(12, 117);
            this.tbxqr1.Multiline = true;
            this.tbxqr1.Name = "tbxqr1";
            this.tbxqr1.Size = new System.Drawing.Size(261, 399);
            this.tbxqr1.TabIndex = 2;
            this.tbxqr1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblqr1
            // 
            this.lblqr1.AutoSize = true;
            this.lblqr1.Location = new System.Drawing.Point(365, 93);
            this.lblqr1.Name = "lblqr1";
            this.lblqr1.Size = new System.Drawing.Size(55, 13);
            this.lblqr1.TabIndex = 3;
            this.lblqr1.Text = "CAMERA:";
            // 
            // pcbqr1
            // 
            this.pcbqr1.Location = new System.Drawing.Point(279, 117);
            this.pcbqr1.Name = "pcbqr1";
            this.pcbqr1.Size = new System.Drawing.Size(481, 399);
            this.pcbqr1.TabIndex = 4;
            this.pcbqr1.TabStop = false;
            // 
            // lblqr2
            // 
            this.lblqr2.AutoSize = true;
            this.lblqr2.Location = new System.Drawing.Point(276, 28);
            this.lblqr2.Name = "lblqr2";
            this.lblqr2.Size = new System.Drawing.Size(185, 13);
            this.lblqr2.TabIndex = 5;
            this.lblqr2.Text = "QR CODE CONTACT TRACING APP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.lblqr2);
            this.Controls.Add(this.pcbqr1);
            this.Controls.Add(this.lblqr1);
            this.Controls.Add(this.tbxqr1);
            this.Controls.Add(this.cmbqr1);
            this.Controls.Add(this.btnqr1);
            this.Name = "Form1";
            this.Text = "QRCode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbqr1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnqr1;
        private System.Windows.Forms.ComboBox cmbqr1;
        private System.Windows.Forms.TextBox tbxqr1;
        private System.Windows.Forms.Label lblqr1;
        private System.Windows.Forms.PictureBox pcbqr1;
        private System.Windows.Forms.Label lblqr2;
    }
}

