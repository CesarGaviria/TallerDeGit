using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSprintUnoPrueba.Entidades
{
    public class ClLoteE
    {
        public int idLote { get; set; }
        public string codigo { get; set; }

        public int idProducto { get; set; }

        public int cantidadLote { get; set; }
        public string unidadMedida { get; set; }

        public int costoLote { get; set; }

        public DateTime fechaFabricacion { get; set; }

        public DateTime fechaVencimiento { get; set; }

        public int idAlmacen {  get; set; }
    }
}
