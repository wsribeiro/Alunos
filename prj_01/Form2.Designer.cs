namespace prj_01
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
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.lbl_inf1 = new System.Windows.Forms.Label();
            this.lbl_inf2 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(12, 64);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(189, 20);
            this.txt_user.TabIndex = 0;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(12, 103);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(189, 20);
            this.txt_senha.TabIndex = 1;
            // 
            // lbl_inf1
            // 
            this.lbl_inf1.AutoSize = true;
            this.lbl_inf1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inf1.Location = new System.Drawing.Point(9, 48);
            this.lbl_inf1.Name = "lbl_inf1";
            this.lbl_inf1.Size = new System.Drawing.Size(50, 13);
            this.lbl_inf1.TabIndex = 2;
            this.lbl_inf1.Text = "Usuário";
            // 
            // lbl_inf2
            // 
            this.lbl_inf2.AutoSize = true;
            this.lbl_inf2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inf2.Location = new System.Drawing.Point(9, 87);
            this.lbl_inf2.Name = "lbl_inf2";
            this.lbl_inf2.Size = new System.Drawing.Size(43, 13);
            this.lbl_inf2.TabIndex = 3;
            this.lbl_inf2.Text = "Senha";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(23, 129);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(167, 23);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Entrar";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.ForeColor = System.Drawing.Color.Navy;
            this.lbl_senha.Location = new System.Drawing.Point(57, 155);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(108, 13);
            this.lbl_senha.TabIndex = 5;
            this.lbl_senha.Text = "Esqueci minha senha";
            this.lbl_senha.Click += new System.EventHandler(this.Lbl_senha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "Validação de \r\npermissão";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 172);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_inf2);
            this.Controls.Add(this.lbl_inf1);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label lbl_inf1;
        private System.Windows.Forms.Label lbl_inf2;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Label label1;
    }
}