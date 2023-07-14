namespace Testes_Skyone_Windows_Forms
{
    partial class pagina_teste5
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
            Limpar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Nome = new TextBox();
            Nota1 = new TextBox();
            Nota2 = new TextBox();
            Enviar = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            aprovadoLabel = new Label();
            reprovadoLabel = new Label();
            SuspendLayout();
            // 
            // Limpar
            // 
            Limpar.BackColor = Color.CadetBlue;
            Limpar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Limpar.Location = new Point(64, 344);
            Limpar.Name = "Limpar";
            Limpar.Size = new Size(107, 46);
            Limpar.TabIndex = 0;
            Limpar.Text = "Limpar campos";
            Limpar.UseVisualStyleBackColor = true;
            Limpar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(64, 99);
            label1.Name = "label1";
            label1.Size = new Size(80, 32);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(64, 180);
            label2.Name = "label2";
            label2.Size = new Size(91, 32);
            label2.TabIndex = 2;
            label2.Text = "1ª nota";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(66, 268);
            label3.Name = "label3";
            label3.Size = new Size(91, 32);
            label3.TabIndex = 3;
            label3.Text = "2ª nota";
            // 
            // Nome
            // 
            Nome.Location = new Point(192, 104);
            Nome.Name = "Nome";
            Nome.Size = new Size(153, 27);
            Nome.TabIndex = 4;
            // 
            // Nota1
            // 
            Nota1.Location = new Point(192, 185);
            Nota1.Name = "Nota1";
            Nota1.Size = new Size(153, 27);
            Nota1.TabIndex = 5;
            // 
            // Nota2
            // 
            Nota2.Location = new Point(192, 273);
            Nota2.Name = "Nota2";
            Nota2.Size = new Size(153, 27);
            Nota2.TabIndex = 6;
            // 
            // Enviar
            // 
            Enviar.BackColor = Color.CadetBlue;
            Enviar.BackgroundImageLayout = ImageLayout.None;
            Enviar.FlatAppearance.BorderColor = Color.Coral;
            Enviar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Enviar.Location = new Point(469, 156);
            Enviar.Name = "Enviar";
            Enviar.Size = new Size(159, 56);
            Enviar.TabIndex = 7;
            Enviar.Text = "Enviar";
            Enviar.UseVisualStyleBackColor = true;
            Enviar.Click += button2_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(219, 9);
            label4.Name = "label4";
            label4.Size = new Size(342, 65);
            label4.TabIndex = 8;
            label4.Text = "lançamento de notas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(192, 146);
            label5.Name = "label5";
            label5.Size = new Size(217, 20);
            label5.TabIndex = 9;
            label5.Text = "A caixa tem que ser preenchida";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(192, 230);
            label6.Name = "label6";
            label6.Size = new Size(144, 20);
            label6.TabIndex = 10;
            label6.Text = "A nota é obrigatória";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(192, 319);
            label7.Name = "label7";
            label7.Size = new Size(144, 20);
            label7.TabIndex = 11;
            label7.Text = "A nota é obrigatória";
            label7.Visible = false;
            // 
            // aprovadoLabel
            // 
            aprovadoLabel.Location = new Point(487, 230);
            aprovadoLabel.Name = "aprovadoLabel";
            aprovadoLabel.Size = new Size(122, 43);
            aprovadoLabel.TabIndex = 12;
            aprovadoLabel.Text = " Aprovado";
            aprovadoLabel.TextAlign = ContentAlignment.MiddleCenter;
            aprovadoLabel.Visible = false;
            // 
            // reprovadoLabel
            // 
            reprovadoLabel.Location = new Point(487, 230);
            reprovadoLabel.Name = "reprovadoLabel";
            reprovadoLabel.Size = new Size(122, 43);
            reprovadoLabel.TabIndex = 13;
            reprovadoLabel.Text = "Reprovado";
            reprovadoLabel.TextAlign = ContentAlignment.MiddleCenter;
            reprovadoLabel.Visible = false;
            // 
            // pagina_teste5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(800, 450);
            Controls.Add(reprovadoLabel);
            Controls.Add(aprovadoLabel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Enviar);
            Controls.Add(Nota2);
            Controls.Add(Nota1);
            Controls.Add(Nome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Limpar);
            Name = "pagina_teste5";
            Text = "pagina_teste5";
            Load += pagina_teste5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Limpar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Nome;
        private TextBox Nota1;
        private TextBox Nota2;
        private Button Enviar;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label aprovadoLabel;
        private Label reprovadoLabel;
    }
}