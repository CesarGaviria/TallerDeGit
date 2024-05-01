using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSprintUnoPrueba.Entidades
{
    public class ClProductoE
    {
        public int idProducto { get; set; }
        public string codigo { get; set; }
        public int idCategoria { get; set; }
        public string producto { get; set; }
        public int valorUnitario { get; set; }
        public int stock { get; set; }
        public string estadoProducto { get; set; }
        public string descripcion { get; set; }
    }
}
