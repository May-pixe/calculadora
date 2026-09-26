using System.Globalization;

namespace Calcular
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        //cultura brasileira; usa virgula como separador
        CultureInfo ptBR = new CultureInfo("pt-BR");

        //indica se o tulyimo comando foi botão
        bool novoCalculo = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnZero_Click_1(object sender, EventArgs e)
        {
            AdicionarNumero("0");
        }
                private void txtResultado(object sender, EventArgs e)
        {

        }

       // numeros
       private void AdicionarNumero(string numero)
        {
          if(novoCalculo)
            {
                txtResultado.Text = "";
                novoCalculo = false;
            }


    }
}