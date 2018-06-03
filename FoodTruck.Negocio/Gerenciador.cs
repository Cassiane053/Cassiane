using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTruck.Negocio
{
    public class Gerenciador
    {
        private Gravador Gravador { get; set; }
        private List<Cliente> Clientes { get; set; }
        private List<Lanche> Lanches { get; set; }
        private List<Bebida> Bebidas { get; set; }
        private List<Pedido> Pedidos { get; set; }

        public Gerenciador()
        {
            this.Clientes = new List<Cliente>();
            this.Lanches = new List<Lanche>();
            this.Bebidas = new List<Bebida>();
            this.Pedidos = new List<Pedido>();


            this.Gravador = new Gravador();
            this.Carregar();
        }

        public void Carregar()
        {
            DadosGravador dados = this.Gravador.Carregar();
            this.Clientes = dados.Clientes;
            this.Bebidas = dados.Bebidas;
            this.Lanches = dados.Lanches;
            this.Pedidos = dados.Pedidos;
        }

        public void Salvar()
        {
            this.Gravador.Salvar(this.Clientes,
                                 this.Bebidas,
                                 this.Lanches,
                                 this.Pedidos);
        }

        public List<Pedido> PedidosCadastrados()
        {
            return this.Pedidos.ToList();
        }

        public List<Cliente> ClientesCadastrados()
        {
            return this.Clientes.ToList();
        }

        public List<Bebida> BebidasCadastradas()
        {
            return this.Bebidas.ToList();
        }

        public List<Lanche> LanchesCadastrados()
        {
            return this.Lanches.ToList();
        }

        public Bebida BuscarBebidaPorCodigo(long codigoBebida)
        {
            return this.Bebidas
                       .Where(bebida => bebida.Id == codigoBebida)
                       .FirstOrDefault();
        }

        public void RemoverBebidaPorCodigo(long codigoBebida)
        {
            this.Bebidas.Remove(this.Bebidas
                       .Where(bebida => bebida.Id == codigoBebida)
                       .FirstOrDefault());
            Salvar();
        }

        public Lanche BuscarLanchePorCodigo(long codigoLanche)
        {
            return this.Lanches
                       .Where(lanche => lanche.Id == codigoLanche)
                       .FirstOrDefault();
        }

        public void RemoverLanchePorCodigo(long codigoLanche)
        {
            this.Lanches.Remove(this.Lanches
                       .Where(lanche => lanche.Id == codigoLanche)
                       .FirstOrDefault());
            Salvar();
        }

        public Cliente BuscarClientePorCPF(String cpf)
        {
            return this.Clientes.Where(cliente => cliente.CPF.Equals(cpf)).FirstOrDefault();
        }

        public Pedido BuscarPedidoPorCodigo(long codigoPedido)
        {
            return this.Pedidos.Where(pedido => pedido.Id == codigoPedido).FirstOrDefault();
        }

        public void AdicionarCliente(Cliente cliente)
        {
            if (cliente == null)
                throw new Exception("O cliente não pode ser nulo");

            if (String.IsNullOrEmpty(cliente.CPF))
                throw new Exception("O cliente precisa ter o CPF");

            if (String.IsNullOrEmpty(cliente.Nome))
                throw new Exception("O cliente precisa ter um nome");

            if (String.IsNullOrEmpty(cliente.Email))
                throw new Exception("O cliente precisa ter um email");

            this.Clientes.Add(cliente);
            this.Salvar();
        }


        public void AdicionarLanche(Lanche lanche)
        {
            if (lanche == null)
                throw new Exception("O lanche não pode ser nulo");

            if (String.IsNullOrEmpty(lanche.Nome))
                throw new Exception("Informe o nome do lanche");

            this.Lanches.Add(lanche);
            this.Salvar();
        }

        //informar tamanho, valor, etc.
        public void AdicionarBebida(Bebida bebida)
        {
            if (bebida == null)
                throw new Exception("A bebida não pode ser nula/vazia.");

            if (String.IsNullOrEmpty(bebida.Nome))
                throw new Exception("Informe o nome da bebida: ");

            if (bebida.Valor < 0)
                throw new Exception("O valor não pode ser negativo!");

            if (bebida.Tamanho <= 0)
                throw new Exception("Informe o tamanho da bebida: ");

            this.Bebidas.Add(bebida);
            this.Salvar();
        }

        public void AdicionarPedido(Pedido pedido)
        {
            if (pedido == null)
                throw new Exception("O pedido não pode ser nulo");

            if (pedido.Cliente == null)
                throw new Exception("Informe o cliente do pedido");

            if (pedido.Data == null || pedido.Data == DateTime.MinValue)
                throw new Exception("Informe a data do pedido");

            this.Pedidos.Add(pedido);
            this.Salvar();
        }

        public void AdicionarBebidaAoPedido(Pedido pedido, Bebida bebida)
        {
            pedido.AdicionarBebida(bebida);
            this.Salvar();
        }

        public void AdicionarLancheAoPedido(Pedido pedido, Lanche lanche)
        {
            pedido.AdicionarLanche(lanche);
            this.Salvar();
        }

        public void RemoverBebidaDoPedido(Pedido pedido, long idBebida)
        {
            pedido.Bebidas.Remove(pedido.Bebidas.FirstOrDefault(e => e.Id.Equals(idBebida)));
            Salvar();
        }

        public void RemoverLancheDoPedido(Pedido pedido, long idLanche)
        {
            pedido.Lanches.Remove(pedido.Lanches.FirstOrDefault(e => e.Id.Equals(idLanche)));
            Salvar();
        }

        //remover cliente
        public void RemoverCliente(string CPF)
        {
            this.Clientes.Remove(this.Clientes.Where(cliente => (cliente.CPF) == CPF).FirstOrDefault());
        }

        public String GerarRelatorioGeral()
        {
            String relatorio = "";
            relatorio += "=========== RELATÓRIO ===========" + Environment.NewLine;
            foreach(var cliente in this.Clientes)
            {
                relatorio += "Nome: " + cliente.Nome + Environment.NewLine;
                List<Pedido> pedidosCliente = this.Pedidos
                                                  .Where(pedido => pedido.Cliente.CPF == cliente.CPF)
                                                  //.Where(pedido => pedido.Encerrado == true)
                                                  .ToList();

                if(pedidosCliente.Count == 0)
                {
                    relatorio += "Este cliente não tem nenhum pedido" + Environment.NewLine;
                    continue;
                }

                Int32 quantidadeLanches = 0;
                Decimal totalGeral = 0;
                foreach(var pedido in pedidosCliente)
                {
                    quantidadeLanches += pedido.Lanches.Count;
                    totalGeral += pedido.Total;
                }

                relatorio += quantidadeLanches + " lanches totalizando R$" + totalGeral + Environment.NewLine;
            
                relatorio += "----------------------------------------" + Environment.NewLine;

            }

            return relatorio;
        }


    }
}
