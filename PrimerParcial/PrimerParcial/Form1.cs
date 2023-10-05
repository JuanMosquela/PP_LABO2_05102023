using Entidades;

namespace Integrador
{
    public partial class FrmCalculadora : Form
    {
        private Operacion calculadora;
        private Numeracion primerOperando;
        private Numeracion segundoOperando;
        private Numeracion resultado;
        private ESistema sistema;


        public FrmCalculadora()
        {
            InitializeComponent();
        }

        public void SetResultado()
        {
            
        }


        private void buttonOperar_Click(object sender, EventArgs e)
        {

            
        }

        private void FmrCalculadora_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textPrimerOperador.Clear();
            textSegundoOperador.Clear();
            lblResult.Text = "";
            this.resultado = null;
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