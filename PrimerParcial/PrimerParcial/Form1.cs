using Entidades;
using System.Configuration;

namespace Integrador
{
    public partial class FrmCalculadora : Form
    {

        private Calculadora calculadora;




        public FrmCalculadora()
        {
            InitializeComponent();
            this.calculadora = new Calculadora("Nombre y apellido");
        }

        public void SetResultado()
        {

        }

        


        private void buttonOperar_Click(object sender, EventArgs e)
        {
            char operador;
            calculadora.PrimerOperando = this.GetOperador(this.txtPrimerOperando.Text);
            calculadora.SegundoOperando =
            this.GetOperador(this.txtSegundoOperando.Text);
            operador = (char)this.cmbOperacion.SelectedItem;
            this.calculadora.Calcular(operador);
            this.calculadora.ActualizaHistorialDeOperaciones(operador)
            ;
            this.lblResultado.Text = $"Resultado:{this.calculadora.Resultado.Valor}";
            this.MostrarHistorial();


        }

        private void FmrCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperacion.DataSource = new char[] { '+', '-', '*',
'/' };


        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {

        }

        private void rdbDecimalChecked_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void radioBinarioChecked_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}