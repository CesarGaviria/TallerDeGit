using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Data; 
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoSprintUnoPrueba.Logica
{
    public class ClConexion
    {
        private SqlConnection oConexion = null;
        public ClConexion()
        {
            oConexion = new SqlConnection("Data Source = DESKTOP-0K2FE29\\SQLEXPRESS; Initial Catalog = dbProyecto; Integrated Security = True");
        }

        public SqlConnection MtdAbrirConexion()
        {
            oConexion.Open();
            return oConexion;

        }
        public void MtdCerrarConexion()
        {
            oConexion.Close();
            oConexion.Dispose();
        }

    }
}
