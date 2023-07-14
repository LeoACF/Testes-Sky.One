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

using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Testes_Skyone_Windows_Forms
{
    public partial class pagina_teste5 : Form
    {
        String status;
        int anoAtual;

        SqlConnection connection = new SqlConnection();
        String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\leoco\\Documents\\SkyOne.mdf;Integrated Security=True;Connect Timeout=30";

        public pagina_teste5()
        {
            InitializeComponent();
            mostrarAno();
        }

        private void mostrarAno()
        {
            anoAtual = DateTime.Now.Year;
        }

        private void condicaoBotao()
        {
            bool NomeVazio = string.IsNullOrEmpty(Nome.Text);
            bool Nota1Vazio = string.IsNullOrEmpty(Nota1.Text);
            bool Nota2Vazio = string.IsNullOrEmpty(Nota2.Text);

            Enviar.Enabled = !(NomeVazio || Nota1Vazio || Nota2Vazio);
            label5.Visible = NomeVazio;
            label6.Visible = Nota1Vazio;
            label7.Visible = Nota2Vazio;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            condicaoBotao();
            string nome = Nome.Text;
            int semestre1, semestre2;
            bool nota1Valida = int.TryParse(Nota1.Text, out semestre1);
            bool nota2Valida = int.TryParse(Nota2.Text, out semestre2);
            int soma = semestre1 + semestre2;
            int media = soma / 2;

            if (nota1Valida && nota2Valida)
            {
                if (media >= 6.5)
                {
                    aprovadoLabel.Visible = true;
                    aprovadoLabel.ForeColor = Color.Green;
                    reprovadoLabel.Visible = false;
                    status = "Aprovado";
                }
                else
                {
                    aprovadoLabel.Visible = false;
                    reprovadoLabel.Visible = true;
                    reprovadoLabel.ForeColor = Color.Red;
                    status = "Reprovado";
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO [dbo].[Alunos-Notas] (Aluno, Semestre1, Semestre2, media_anual, status) VALUES (@Nome_Aluno, @Semestre1, @Semestre2, @Media_Anual, @Status)";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Nome_Aluno", nome);
                        command.Parameters.AddWithValue("@Semestre1", semestre1);
                        command.Parameters.AddWithValue("@Semestre2", semestre2);
                        command.Parameters.AddWithValue("@Media_Anual", media);
                        command.Parameters.AddWithValue("@Status", status);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao enviar os dados para o SQL Server: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Insira valores numéricos válidos nas notas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpar.Enabled = true;
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

        private void pagina_teste5_Load(object sender, EventArgs e)
        {
        }
    }
}
