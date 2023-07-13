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
        //button2 envia dados
        private void button2_Click(object sender, EventArgs e)
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
        //button1 apaga os textos do textbox 
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textbox = (TextBox)control;
                    textbox.Text = string.Empty;
                }
            }
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
