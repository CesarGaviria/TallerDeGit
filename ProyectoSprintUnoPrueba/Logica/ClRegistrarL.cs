using ProyectoSprintUnoPrueba.Datos;
using ProyectoSprintUnoPrueba.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSprintUnoPrueba.Logica
{
    public class ClRegistrarL
    {
        public int  MtdRegistrar(ClPersonaE Persona)
        {
            int filasAfectadas;
            ClPersonaD clPersonaD = new ClPersonaD();
            if (!clPersonaD.MtdVerificarExistencia(Persona.documento))
            {
                 filasAfectadas = clPersonaD.MtdRegistrar(Persona);
            }
            else { filasAfectadas = -1;
            }
            return filasAfectadas;
        }

    }
}
