using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTruck.Negocio
{
    public class Cliente
    {
        public String CPF { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }

        //mostra na tela as informações do cliente
        public override string ToString()
        {
            return this.CPF + " - " + this.Nome;
        }
    }
}
