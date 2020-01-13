namespace Application_Desktop
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
            this.Txt_Auth_Login = new System.Windows.Forms.TextBox();
            this.Lab_Login = new System.Windows.Forms.Label();
            this.Btn_Connecter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Auth_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Txt_Auth_Login
            // 
            this.Txt_Auth_Login.Location = new System.Drawing.Point(141, 57);
            this.Txt_Auth_Login.Name = "Txt_Auth_Login";
            this.Txt_Auth_Login.Size = new System.Drawing.Size(185, 20);
            this.Txt_Auth_Login.TabIndex = 0;
            // 
            // Lab_Login
            // 
            this.Lab_Login.AutoSize = true;
            this.Lab_Login.Location = new System.Drawing.Point(51, 64);
            this.Lab_Login.Name = "Lab_Login";
            this.Lab_Login.Size = new System.Drawing.Size(39, 13);
            this.Lab_Login.TabIndex = 1;
            this.Lab_Login.Text = "Login :";
            // 
            // Btn_Connecter
            // 
            this.Btn_Connecter.Location = new System.Drawing.Point(177, 131);
            this.Btn_Connecter.Name = "Btn_Connecter";
            this.Btn_Connecter.Size = new System.Drawing.Size(94, 39);
            this.Btn_Connecter.TabIndex = 2;
            this.Btn_Connecter.Text = "Valider";
            this.Btn_Connecter.UseVisualStyleBackColor = true;
            this.Btn_Connecter.Click += new System.EventHandler(this.Btn_Connecter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password :";
            // 
            // Txt_Auth_Password
            // 
            this.Txt_Auth_Password.Location = new System.Drawing.Point(141, 92);
            this.Txt_Auth_Password.Name = "Txt_Auth_Password";
            this.Txt_Auth_Password.Size = new System.Drawing.Size(185, 20);
            this.Txt_Auth_Password.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 196);
            this.Controls.Add(this.Txt_Auth_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Connecter);
            this.Controls.Add(this.Lab_Login);
            this.Controls.Add(this.Txt_Auth_Login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Auth_Login;
        private System.Windows.Forms.Label Lab_Login;
        private System.Windows.Forms.Button Btn_Connecter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Auth_Password;
    }
}

