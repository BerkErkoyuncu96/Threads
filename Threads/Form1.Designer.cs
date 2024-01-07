namespace Threads
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
            this.LblThread1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTekSayi = new System.Windows.Forms.RichTextBox();
            this.threadbtn1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtCiftSayi = new System.Windows.Forms.RichTextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtAsalSayi = new System.Windows.Forms.RichTextBox();
            this.lbl = new DevExpress.XtraEditors.LabelControl();
            this.txtAsalSayi2 = new System.Windows.Forms.RichTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // LblThread1
            // 
            this.LblThread1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblThread1.Appearance.Options.UseFont = true;
            this.LblThread1.Location = new System.Drawing.Point(30, 38);
            this.LblThread1.Name = "LblThread1";
            this.LblThread1.Size = new System.Drawing.Size(171, 25);
            this.LblThread1.TabIndex = 0;
            this.LblThread1.Text = "Tek Sayıları Yazdır";
            // 
            // txtTekSayi
            // 
            this.txtTekSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTekSayi.Location = new System.Drawing.Point(26, 69);
            this.txtTekSayi.Name = "txtTekSayi";
            this.txtTekSayi.Size = new System.Drawing.Size(175, 520);
            this.txtTekSayi.TabIndex = 1;
            this.txtTekSayi.Text = "";
            // 
            // threadbtn1
            // 
            this.threadbtn1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.threadbtn1.Appearance.Options.UseFont = true;
            this.threadbtn1.Location = new System.Drawing.Point(428, 595);
            this.threadbtn1.Name = "threadbtn1";
            this.threadbtn1.Size = new System.Drawing.Size(299, 55);
            this.threadbtn1.TabIndex = 2;
            this.threadbtn1.Text = "Threadleri Başlat";
            this.threadbtn1.Click += new System.EventHandler(this.threadbtn1_Click);
            // 
            // txtCiftSayi
            // 
            this.txtCiftSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCiftSayi.Location = new System.Drawing.Point(302, 69);
            this.txtCiftSayi.Name = "txtCiftSayi";
            this.txtCiftSayi.Size = new System.Drawing.Size(219, 520);
            this.txtCiftSayi.TabIndex = 4;
            this.txtCiftSayi.Text = "";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(329, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(170, 25);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Çift Sayıları Yazdır";
            // 
            // txtAsalSayi
            // 
            this.txtAsalSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAsalSayi.Location = new System.Drawing.Point(585, 69);
            this.txtAsalSayi.Name = "txtAsalSayi";
            this.txtAsalSayi.Size = new System.Drawing.Size(207, 520);
            this.txtAsalSayi.TabIndex = 7;
            this.txtAsalSayi.Text = "";
            // 
            // lbl
            // 
            this.lbl.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl.Appearance.Options.UseFont = true;
            this.lbl.Location = new System.Drawing.Point(597, 13);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(176, 50);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "Asal Sayıları Yazdır\r\n(0-500.000)";
            // 
            // txtAsalSayi2
            // 
            this.txtAsalSayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAsalSayi2.Location = new System.Drawing.Point(849, 69);
            this.txtAsalSayi2.Name = "txtAsalSayi2";
            this.txtAsalSayi2.Size = new System.Drawing.Size(207, 520);
            this.txtAsalSayi2.TabIndex = 9;
            this.txtAsalSayi2.Text = "";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(861, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(185, 50);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Asal Sayıları Yazdır\r\n(500.000-1.000.000)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 652);
            this.Controls.Add(this.txtAsalSayi2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtAsalSayi);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtCiftSayi);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.threadbtn1);
            this.Controls.Add(this.txtTekSayi);
            this.Controls.Add(this.LblThread1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LblThread1;
        private System.Windows.Forms.RichTextBox txtTekSayi;
        private DevExpress.XtraEditors.SimpleButton threadbtn1;
        private System.Windows.Forms.RichTextBox txtCiftSayi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RichTextBox txtAsalSayi;
        private DevExpress.XtraEditors.LabelControl lbl;
        private System.Windows.Forms.RichTextBox txtAsalSayi2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}

