namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string operation;
        double Number1;
        double Number2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Entraste na calculadora");
        }

        private void n1_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + Convert.ToString(1);
        }

        private void n2_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + Convert.ToString(2);
        }

        private void n3_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + Convert.ToString(3);
        }

        private void n4_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + Convert.ToString(4);
        }

        private void n5_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + Convert.ToString(5);
        }

        private void n6_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + Convert.ToString(6);
        }

        private void n7_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + Convert.ToString(7);
        }

        private void n8_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + Convert.ToString(8);
        }

        private void n9_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + Convert.ToString(9);
        }

        private void n0_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + Convert.ToString(0);
        }

        private void soma_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(resultado.Text);
            operation = "+";
            resultado.Clear();
        }

        private void subtrair_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(resultado.Text);
            operation = "-";
            resultado.Clear();
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(resultado.Text);
            operation = "*";
            resultado.Clear();
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(resultado.Text);
            operation = "/";
            resultado.Clear();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            Number2 = Convert.ToDouble(resultado.Text);

            switch (operation)
            {
                case "+":
                    double resultadoSoma = Number1 + Number2;
                    resultado.Text = Convert.ToString(resultadoSoma);
                    break;
                case "-":
                    double resultadoSubtracao = Number1 - Number2;
                    resultado.Text = Convert.ToString(resultadoSubtracao);
                    break;
                case "*":
                    double resultadoMultiplicacao = Number1 * Number2;
                    resultado.Text = Convert.ToString(resultadoMultiplicacao);
                    break;
                case "/":
                    double resultadoDivisao = Number1 / Number2;
                    resultado.Text = Convert.ToString(resultadoDivisao);
                    break;
            }
        }

        private void colon_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + ",";
        }

        private void apagar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(resultado.Text))
            {
                resultado.Text = resultado.Text.Remove(resultado.Text.Length - 1);
            }
        }
    }
}
    
