namespace GeradorDeSenha
{
    public partial class Form1 : Form
    {
        int tamanhoSenhaAtual = 0;
        Random caractere = new Random();

        private void geradorSenha(int tamanhoSenha)
        {
            string todosCaracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890!@#$%&";
            string senhaAleatoria = "";

            for (int i = 0; i < tamanhoSenha; i++)
            {
                int numeroAleatorio = caractere.Next(0, todosCaracteres.Length);
                senhaAleatoria += todosCaracteres[numeroAleatorio];
            }
            senhaTexto.Text = senhaAleatoria;
        }

        public Form1()
        {
            InitializeComponent();
            tamanhoSenhaSlider.Minimum = 5;
            tamanhoSenhaSlider.Maximum = 20;
            geradorSenha(5);
        }

        private void copiarSenhaBotao_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(senhaTexto.Text);
        }

        private void tamanhoSenhaSlider_Scroll(object sender, EventArgs e)
        {
            tamanhoSenhaTexto.Text = "Tamanho da Senha: " + tamanhoSenhaSlider.Value.ToString();
            tamanhoSenhaAtual = tamanhoSenhaSlider.Value;
            geradorSenha(tamanhoSenhaAtual);
        }

        private void senhaGerar_Click(object sender, EventArgs e)
        {
            geradorSenha(tamanhoSenhaAtual);
        }
    }
}