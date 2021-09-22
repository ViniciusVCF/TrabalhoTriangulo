using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTriangulo.Modelo
{
    public class Controle : absPropriedades
    {

        public Controle(string lado1, string lado2, string lado3): base(lado1, lado2, lado3)
        {
            verificar();
        }
        private void verificar()
        {
            Validacao validacao = new Validacao(this.lado1, this.lado2, this.lado3);
        }
    }
}
