using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaDecimal : Numeracion
    {

        public SistemaDecimal(string valor) : base(valor) { }

        internal override double ValorNumerico
        {
            get
            {
                if (double.TryParse(valor, out double result))
                {
                    return result;
                }
                else
                {
                    return 0.0;
                }
            }
        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            SistemaDecimal sistemaDecimal = sistema.ToString();
            return sistemaDecimal;
        }

       

        protected override bool EsNumeracionValida(string valor)
        {
            return base.EsNumeracionValida(valor) && EsSistemaDecimalValido(valor);
        }      

        

        private bool EsSistemaDecimalValido(string valor)
        {
            return double.TryParse(valor, out double result);             
            
        }

        public static implicit operator SistemaDecimal(double valor)
        {
            return new SistemaDecimal(valor.ToString());
        }

        public static implicit operator SistemaDecimal(string valor)
        {
            return new SistemaDecimal(valor);
        }


    }
}
