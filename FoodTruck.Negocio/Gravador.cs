using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FoodTruck.Negocio
{
    public class Gravador
    {

        private String NomeArquivo = "dados.xml";

        public void Salvar(List<Cliente> clientes,
                           List<Bebida> bebidas,
                           List<Lanche> lanches,
                           List<Pedido> pedidos)
        {
            DadosGravador dados = new DadosGravador();
            dados.Clientes = clientes;
            dados.Bebidas = bebidas;
            dados.Lanches = lanches;
            dados.Pedidos = pedidos;

            StreamWriter arquivo = new StreamWriter(NomeArquivo);
            XmlSerializer serializer = new XmlSerializer(typeof(DadosGravador));
            serializer.Serialize(arquivo, dados);
            arquivo.Close();
        }

        public DadosGravador Carregar()
        {
            DadosGravador dados = new DadosGravador();

            if (File.Exists(NomeArquivo))
            {
                StreamReader arquivo = new StreamReader(NomeArquivo);
                XmlSerializer serializer = new XmlSerializer(typeof(DadosGravador));
                dados = serializer.Deserialize(arquivo) as DadosGravador;
                arquivo.Close();
            }
            return dados;

        }
    }
}
