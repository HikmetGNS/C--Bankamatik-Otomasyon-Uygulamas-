namespace WindowsFormsApp7
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdCheck = new System.Windows.Forms.TextBox();
            this.txtPhoneNumberCheck = new System.Windows.Forms.TextBox();
            this.txtPasswordCheck = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID\'niz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefon Numaranız:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifreniz:";
            // 
            // txtIdCheck
            // 
            this.txtIdCheck.Location = new System.Drawing.Point(169, 30);
            this.txtIdCheck.Name = "txtIdCheck";
            this.txtIdCheck.Size = new System.Drawing.Size(145, 20);
            this.txtIdCheck.TabIndex = 3;
            // 
            // txtPhoneNumberCheck
            // 
            this.txtPhoneNumberCheck.Location = new System.Drawing.Point(169, 70);
            this.txtPhoneNumberCheck.Name = "txtPhoneNumberCheck";
            this.txtPhoneNumberCheck.Size = new System.Drawing.Size(145, 20);
            this.txtPhoneNumberCheck.TabIndex = 4;
            // 
            // txtPasswordCheck
            // 
            this.txtPasswordCheck.Location = new System.Drawing.Point(169, 120);
            this.txtPasswordCheck.Name = "txtPasswordCheck";
            this.txtPasswordCheck.PasswordChar = '*';
            this.txtPasswordCheck.Size = new System.Drawing.Size(145, 20);
            this.txtPasswordCheck.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPasswordCheck);
            this.Controls.Add(this.txtPhoneNumberCheck);
            this.Controls.Add(this.txtIdCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Bilgilerinizi Giriniz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdCheck;
        private System.Windows.Forms.TextBox txtPhoneNumberCheck;
        private System.Windows.Forms.TextBox txtPasswordCheck;
        private System.Windows.Forms.Button button1;
    }
}