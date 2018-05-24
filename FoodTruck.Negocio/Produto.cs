using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTruck.Negocio
{
    public class Produto
    {
        public long Id { get; set; }
        public String Nome { get; set; }
        public Decimal Valor { get; set; }

        public virtual String Descricao()
        {
            return Id + " - " + Nome + " - R$" + Valor;
        }
    }
}
