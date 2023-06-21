namespace atividadeIdade
{
    public partial class Form1 : Form
    {

        Funcionario? fun = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(trackBar1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fun == null)
            {
                fun = new Funcionario();
            }

            fun.Nome = Convert.ToString(textBox1.Text);
            fun.Idade = Convert.ToInt32(label3.Text);


            labelNome.Text = fun.Nome;
            labelidade.Text = Convert.ToString(fun.Idade);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}