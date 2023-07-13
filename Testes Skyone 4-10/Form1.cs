

namespace Testes_Skyone_Windows_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool loginVazio = string.IsNullOrEmpty(enviarLogin.Text);
            bool senhaVazia = string.IsNullOrEmpty(enviarSenha.Text);

            if (loginVazio)
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }

            if (senhaVazia)
            {
                label3.Visible = true;
            }
            else
            {
                label3.Visible = false;
            }

            if (loginVazio || senhaVazia)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                pagina_teste5 form2 = new pagina_teste5();
                form2.Show();
                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void enviarLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void enviarSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}