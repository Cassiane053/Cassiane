using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTruck.Negocio
{
    public class DadosGravador
    {
        public List<Cliente> Clientes { get; set; }
        public List<Lanche> Lanches { get; set; }
        public List<Bebida> Bebidas { get; set; }
        public List<Pedido> Pedidos { get; set; }

        public DadosGravador()
        {
            this.Clientes = new List<Cliente>();
            this.Lanches = new List<Lanche>();
            this.Bebidas = new List<Bebida>();
            this.Pedidos = new List<Pedido>();
        }
    }
}
