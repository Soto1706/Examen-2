using System.Drawing;

namespace Examen_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbOperaciones.Items.Add("USD - Dolar Estadounidense");
            this.cmbOperaciones.Items.Add("MXN - Peso Mexicano");
            this.cmbOperaciones.Items.Add("CAD - Dolar Canadiense");
            this.cmbOperaciones.Items.Add("EUR - Euro");
            this.cmbOperaciones.Items.Add("JPY - Yen Japones");


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double mxn = 0, peso = 0;
            double cad = 0, dolar = 0;
            double eur = 0, euro = 0;
            double jyp = 0, yen = 0;
            double usd = 0, dolaru = 0;
            string operacion = this.cmbOperaciones.SelectedItem.ToString();
            switch (operacion)
            {
                case "USD - Dolar Estadounidense":

                    peso = 17.08;
                    dolar = 1.38;
                    euro = 0.94;
                    yen = 154.60;
                    dolaru = 1;

                    mxn = double.Parse(this.txtNum1.Text) * peso;
                    cad = double.Parse(this.txtNum1.Text) * dolar;
                    eur = double.Parse(this.txtNum1.Text) * euro;
                    jyp = double.Parse(this.txtNum1.Text) * yen;
                    usd = double.Parse(this.txtNum1.Text) * dolaru;

                    break;

                case "MXN - Peso Mexicano":
                    peso = 1;
                    dolar = 0.08;
                    euro = 0.06;
                    yen = 9.05;
                    dolaru = 0.06;

                    mxn = double.Parse(this.txtNum1.Text) * peso;
                    cad = double.Parse(this.txtNum1.Text) * dolar;
                    eur = double.Parse(this.txtNum1.Text) * euro;
                    jyp = double.Parse(this.txtNum1.Text) * yen;
                    usd = double.Parse(this.txtNum1.Text) * dolaru;
                    break;
                case "CAD - Dolar Canadiense":
                    peso = 12.40;
                    dolar = 1;
                    euro = 0.68;
                    yen = 112.26;
                    dolaru = 0.73;

                    mxn = double.Parse(this.txtNum1.Text) * peso;
                    cad = double.Parse(this.txtNum1.Text) * dolar;
                    eur = double.Parse(this.txtNum1.Text) * euro;
                    jyp = double.Parse(this.txtNum1.Text) * yen;
                    usd = double.Parse(this.txtNum1.Text) * dolaru;
                    break;

                case "EUR - Euro":
                    peso = 18.17;
                    dolar = 1.47;
                    euro = 1;
                    yen = 164.55;
                    dolaru = 1.06;

                    mxn = double.Parse(this.txtNum1.Text) * peso;
                    cad = double.Parse(this.txtNum1.Text) * dolar;
                    eur = double.Parse(this.txtNum1.Text) * euro;
                    jyp = double.Parse(this.txtNum1.Text) * yen;
                    usd = double.Parse(this.txtNum1.Text) * dolaru;
                    break;

                case "JPY - Yen Japones":
                    peso = 0.1104;
                    dolar = 0.0089;
                    euro = 0.0061;
                    yen = 1;
                    dolaru = 0.0065;

                    mxn = double.Parse(this.txtNum1.Text) * peso;
                    cad = double.Parse(this.txtNum1.Text) * dolar;
                    eur = double.Parse(this.txtNum1.Text) * euro;
                    jyp = double.Parse(this.txtNum1.Text) * yen;
                    usd = double.Parse(this.txtNum1.Text) * dolaru;
                    break;



                default:
                    break;
            }
            this.txtMXN.Text = mxn.ToString();
            this.txtCAD.Text = cad.ToString();
            this.txtEUR.Text = eur.ToString();
            this.txtJPY.Text = jyp.ToString();
            this.txtUSD.Text = usd.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
