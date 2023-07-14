namespace Testes_Skyone_Windows_Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            login = new Label();
            senha = new Label();
            button1 = new Button();
            enviarLogin = new TextBox();
            enviarSenha = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // login
            // 
            login.AutoSize = true;
            login.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            login.Location = new Point(86, 164);
            login.Name = "login";
            login.Size = new Size(73, 32);
            login.TabIndex = 0;
            login.Text = "Login";
            // 
            // senha
            // 
            senha.AutoSize = true;
            senha.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            senha.Location = new Point(83, 270);
            senha.Name = "senha";
            senha.Size = new Size(80, 32);
            senha.TabIndex = 1;
            senha.Text = "Senha";
            senha.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(504, 214);
            button1.Name = "button1";
            button1.Size = new Size(147, 49);
            button1.TabIndex = 2;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // enviarLogin
            // 
            enviarLogin.Location = new Point(228, 169);
            enviarLogin.Name = "enviarLogin";
            enviarLogin.Size = new Size(125, 27);
            enviarLogin.TabIndex = 3;
            enviarLogin.TextChanged += enviarLogin_TextChanged;
            // 
            // enviarSenha
            // 
            enviarSenha.Location = new Point(228, 275);
            enviarSenha.Name = "enviarSenha";
            enviarSenha.Size = new Size(125, 27);
            enviarSenha.TabIndex = 4;
            enviarSenha.TextChanged += enviarSenha_TextChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.Coral;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(228, 37);
            label2.Name = "label2";
            label2.Size = new Size(338, 62);
            label2.TabIndex = 6;
            label2.Text = "Login do professor";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 214);
            label1.Name = "label1";
            label1.Size = new Size(217, 20);
            label1.TabIndex = 7;
            label1.Text = "A caixa tem que ser preenchida";
            label1.Visible = false;
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(228, 332);
            label3.Name = "label3";
            label3.Size = new Size(217, 20);
            label3.TabIndex = 8;
            label3.Text = "A caixa tem que ser preenchida";
            label3.Visible = false;
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(enviarSenha);
            Controls.Add(enviarLogin);
            Controls.Add(button1);
            Controls.Add(senha);
            Controls.Add(login);
            Name = "Form1";
            Text = "Login do Professor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label login;
        private Label senha;
        private Button button1;
        private TextBox enviarLogin;
        private TextBox enviarSenha;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}