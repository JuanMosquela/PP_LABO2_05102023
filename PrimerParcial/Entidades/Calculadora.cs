using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        private string nombreAlumno;
        private List<string> operaciones;
        private Numeracion primerOperando;
        private Numeracion segundoOperando;
        private static ESistema sistema;
        private Numeracion resultado;

        static Calculadora()
        {
            Calculadora.sistema = ESistema.Decimal;
        }
        public Calculadora()
        {
            this.operaciones = new List<string>();
        }          
        
        public Calculadora (string nombreAlumno):this()
        {
            this.nombreAlumno = nombreAlumno;
        }

        public string NombreAlumno { get { return this.nombreAlumno;  } }
        public List<string> Operaciones { get { return this.operaciones; } }
        public Numeracion PrimerOperando { get { return this.primerOperando; } }
        public Numeracion SegundoOperando { get { return this.segundoOperando; } }  
        public ESistema Sistema { get { return sistema; } }

        public Numeracion Resultado { get { return resultado; } }   

       

        public Numeracion Mapear(double valor)
        {
            return Calculadora.sistema == ESistema.Decimal ? new SistemaDecimal(valor.ToString()) : new SistemaBinario(valor.ToString());  

        }

        public void Calcular()
        {          
            
            if(this.primerOperando is SistemaDecimal && this.segundoOperando is SistemaDecimal)
            {
                double resultado = this.primerOperando.ValorNumerico + this.segundoOperando.ValorNumerico;
                this.resultado = Mapear(resultado);
            }   
            
        }

        public void ActualizaHistorialDeOperaciones()
        {
            StringBuilder historial = new StringBuilder();
            historial.AppendLine($"Sistema de la calculadora: {sistema}");
            historial.AppendLine($"Operando 1: {primerOperando.Valor}");
            historial.AppendLine($"Operando 2: {segundoOperando.Valor}");
            historial.AppendLine($"Resultado: {resultado.Valor}");
            operaciones.Add(historial.ToString());
        }

        public void EliminarHistorialDeOperaciones()
        {
            operaciones.Clear();
        }

        public void Calcular(char operador)
        {

        }
    }
}
