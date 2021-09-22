using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTriangulo
{
    public class absPropriedades
    {
        public double L1 { get; set; }
        public double L2 { get; set; }
        public double L3 { get; set; }
        public string Lado1 { get; set; }
        public string Lado2 { get; set; }
        public string Lado3 { get; set; }
        public string Mensagem { get; set; }
        public string Resposta { get; set; }

        protected double l1;

        protected double l2;

        protected double l3;

        protected string lado1;

        protected string lado2;

        protected string lado3;

        protected string mensagem;

        protected string resposta;

        public absPropriedades(double l1, double l2, double l3)
        {
            this.L1 = l1;
            this.L2 = l2;
            this.L3 = l3;
        }
        public absPropriedades(string lado1, string lado2, string lado3)
        {
            this.Lado1 = lado1;
            this.Lado2 = lado2;
            this.Lado3 = lado3;
        }
        public absPropriedades()
        {

        }
    }
}
