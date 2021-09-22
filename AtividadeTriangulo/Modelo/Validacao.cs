using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTriangulo.Modelo
{
    class Validacao : absPropriedades
    {
        public Validacao(string lado1, string lado2, string lado3) : base(lado1, lado2, lado3)
        {
            verificar(lado1, lado2, lado3);
        }
        private bool verificar(string lado1, string lado2, string lado3)
        {
            double l1, l2, l3;
            try
            {
                l1 = double.Parse(lado1);
                l2 = double.Parse(lado2);
                l3 = double.Parse(lado3);
                return true;
            }
            catch (Exception)
            {
                this.Mensagem = "Informe um dado válido!";
                return false;
            }
        }
    }
}
