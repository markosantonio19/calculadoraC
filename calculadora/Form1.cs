namespace calculadora
{
    public partial class Form1 : Form
    {
        private double valor1;
        private double valor2;

        private double resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //boton 6
            tbDisplay.Text = tbDisplay.Text + "6";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            //boton 0
            tbDisplay.Text = tbDisplay.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //boton 1
            tbDisplay.Text = tbDisplay.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //boton 2
            tbDisplay.Text = tbDisplay.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //boton 3
            tbDisplay.Text = tbDisplay.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //boton 4
            tbDisplay.Text = tbDisplay.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //boton 5
            tbDisplay.Text = tbDisplay.Text + "5";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //boton 7
            tbDisplay.Text = tbDisplay.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //boton 8
            tbDisplay.Text = tbDisplay.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //boton 9
            tbDisplay.Text = tbDisplay.Text + "9";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //boton limpiar
            tbDisplay.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            //boton igual 
            valor2 = Convert.ToDouble(tbDisplay.Text);

            resultado = valor1 + valor2;
            tbDisplay.Text = resultado.ToString();


        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            //boton suma 
            valor1 = Convert.ToDouble (tbDisplay.Text);

            tbDisplay.Text = "";
        }
    }
}