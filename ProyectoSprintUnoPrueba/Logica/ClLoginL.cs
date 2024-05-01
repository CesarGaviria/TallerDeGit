using ProyectoSprintUnoPrueba.Datos;
using ProyectoSprintUnoPrueba.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSprintUnoPrueba.Logica
{
    public class ClLoginL { 

        public ClPersonaE MtdLogin(string usuario, string clave)
        {
        ClPersonaD objClClienteD = new ClPersonaD();
        ClPersonaE objDatos = objClClienteD.MtdLogin(usuario, clave);

        return objDatos;
        }

        public ClPersonaE MtdObtenerPersona(int id)
        {
            ClPersonaD objClClienteD = new ClPersonaD();
            ClPersonaE objDatos = objClClienteD.MtdObtenerPersona(id);

            return objDatos;
        }
    }
}
