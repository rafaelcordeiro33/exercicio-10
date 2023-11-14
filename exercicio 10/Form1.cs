namespace exercicio_10
{
    using Microsoft.VisualBasic;
    public partial class Form1 : Form
    {
        public string passwordcerta;
        public string password;
        public Form1()
        {
            InitializeComponent();
            passwordcerta = "password";
        }
        //olá
        private void button1_Click(object sender, EventArgs e)
        {
            password = Interaction.InputBox("Por favor, insira a palavra passe:", "Input Box");
            if (password == passwordcerta)
            {
                MessageBox.Show("Password válida");
            }
            else
                MessageBox.Show("Password inválida");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            passwordcerta = Interaction.InputBox("Por favor, insira a nova palavra passe:", "Input Box");
            MessageBox.Show("Password trocada com sucesso");
        }
    }
}