using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Testes_Skyone_Windows_Forms
{
    public partial class pagina_teste5 : Form
    {
        SqlConnection connection = new SqlConnection();
        String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\leoco\\Documents\\SkyOne.mdf;Integrated Security=True;Connect Timeout=30";
        public pagina_teste5()
        {
            InitializeComponent();
        }
        //função para as labels de textbox vazias aparecerem, e para o botão parar de funcionar 
        private void condicaoBotao()
        {
            bool NomeVazio = string.IsNullOrEmpty(Nome.Text);
            bool Nota1Vazio = string.IsNullOrEmpty(Nota1.Text);
            bool Nota2Vazio = string.IsNullOrEmpty(Nota2.Text);

            if (NomeVazio)
            {
                label5.Visible = true;
            }
            else
            {
                label5.Visible = false;
            }
            if (Nota1Vazio)
            {
                label5.Visible = true;
            }
            else
            {
                label5.Visible = false;
            }
            if (Nota2Vazio)
            {
                label5.Visible = true;
            }
            else
            {
                label5.Visible = false;
            }
            if (NomeVazio || Nota1Vazio || Nota2Vazio)
            {
                Enviar.Enabled = false;

            }
            else
            {
                Enviar.Enabled = true;
            }

        }
        //button2 envia dados
        private void button2_Click(object sender, EventArgs e)
        {
            condicaoBotao();
            string nome = Nome.Text;
            int semestre1, semestre2;
            bool nota1Valida = int.TryParse(Nota1.Text, out semestre1);
            bool nota2Valida = int.TryParse(Nota2.Text, out semestre2);

            if (nota1Valida && nota2Valida)
            {
                int soma = semestre1 + semestre2;
                int media = soma / 2;
                if (media >= 6.5)
                {
                    aprovadoLabel.Visible = true;
                    aprovadoLabel.ForeColor = Color.Green;
                    reprovadoLabel.Visible = false;
                }
                else
                {
                    aprovadoLabel.Visible = false;
                    reprovadoLabel.Visible = true;
                    reprovadoLabel.ForeColor = Color.Red;
                }
            }
            else
            {
                // Exibir mensagem de erro para as notas inválidas
                MessageBox.Show("Insira valores numéricos válidos nas notas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            enviaDados();
        }
        private void enviaDados()
        {

        }
        //button1 apaga os textos do textbox 
        private void button1_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void limpar()
        {
            Nome.Text = string.Empty;
            Nota1.Text = string.Empty;
            Nota2.Text = string.Empty;
            aprovadoLabel.Visible = false;
            reprovadoLabel.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
        }

        
        public void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
