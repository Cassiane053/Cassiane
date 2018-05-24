
using FoodTruck.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodTruck.Grafico
{
    public class Util
    {
        public static Gerenciador Gerenciador = new Gerenciador();

        public static object GetCellValueFromColumnHeader(DataGridViewCellCollection CellCollection, string propertyName)
        {
            return CellCollection.Cast<DataGridViewCell>().First(c => c.OwningColumn.DataPropertyName == propertyName).Value;
        }
    }
}
