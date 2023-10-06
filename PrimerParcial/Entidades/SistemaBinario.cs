using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaBinario : Numeracion
    {
        public SistemaBinario(string valor) : base(valor) { }

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

       

        private bool EsSistemaBinarioValido(string valor)
        {
            foreach (char c in valor)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }
        private SistemaBinario BinarioADecimal()
        {
            return new SistemaBinario(this.Valor);
        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            return BinarioADecimal();
        }

        protected override bool EsNumeracionValida(string valor)
        {
            return base.EsNumeracionValida(valor) && EsSistemaBinarioValido(valor);
        }

        public static implicit operator SistemaBinario(string valor)
        {
            return new SistemaBinario(valor);
        }




    }
}
