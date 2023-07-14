

namespace Testes_Skyone_Windows_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void botaoAtivo()
        {

            bool loginVazio = string.IsNullOrEmpty(enviarLogin.Text);
            bool senhaVazia = string.IsNullOrEmpty(enviarSenha.Text);

            //botão ativo quando as duas caixas estiverem preenchidas
            button1.Enabled = !(loginVazio || senhaVazia);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool loginVazio = string.IsNullOrEmpty(enviarLogin.Text);
            bool senhaVazia = string.IsNullOrEmpty(enviarSenha.Text);
            
            //botão ativo quando as duas caixas estiverem preenchidas
            button1.Enabled = !(loginVazio || senhaVazia);

            if (loginVazio)
            {
                label1.Visible = true;
                label1.ForeColor = Color.Red;
            }
            else
            {
                label1.Visible = false;
            }

            if (senhaVazia)
            {
                label3.Visible = true;
                label3.ForeColor = Color.Red;
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
            botaoAtivo();
        }

        private void enviarSenha_TextChanged(object sender, EventArgs e)
        {
            botaoAtivo();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}