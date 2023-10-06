using System.Runtime.CompilerServices;

namespace Entidades
{
    public abstract class Numeracion
    {
       
        
        protected static string msgError;
        protected string valor;
        protected private ESistema sistema;

        private Numeracion()
        {
            Numeracion.msgError = "Numero invalido";
        }

        protected Numeracion(string valor)
        {            
            this.InicializaValor(valor);
        }

        private void InicializaValor(string valor)
        {
            if (EsNumeracionValida(valor))
            {
                this.valor = valor;
            }
        }

        public string Valor { get { return this.valor; } }

        public ESistema Sistema { get { return this.sistema; }  }

        internal abstract double ValorNumerico { get; }

         public abstract Numeracion CambiarSistemaDeNumeracion(ESistema sistema);

        protected virtual bool EsNumeracionValida(string valor)
        {
            return string.IsNullOrEmpty(valor);          
        }

       

        public static bool operator == (Numeracion n1, Numeracion n2)
        {
            return n1.sistema == n2.sistema;
        }

        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return !(n1 == n2);
        }

        public static explicit operator double (Numeracion numeracion)
        {
            return numeracion.ValorNumerico;
        } 


    }

    public enum ESistema { Binario, Decimal }
}