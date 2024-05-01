using ProyectoSprintUnoPrueba.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSprintUnoPrueba.Datos
{
    public class ClPersonaD
    {
        public bool MtdVerificarExistencia(string doc)
        {
           string consulta = $"SELECT * FROM usuario WHERE documento = '{doc}'";
           ClAdminSQL objAdmin = new ClAdminSQL();
            DataTable tblDatos = objAdmin.MtdSelect(consulta);
           return tblDatos.Rows.Count > 0;
        }
        
        public ClPersonaE MtdLogin(string doc, string clave)
        {
            string consulta = $"select * from Usuario where documento = {doc} and clave = {clave}";
            ClAdminSQL objAdmin = new ClAdminSQL();
            DataTable tblDatos = objAdmin.MtdSelect(consulta);

            ClPersonaE objDatos = null;
            if (tblDatos.Rows.Count > 0)
            {
                objDatos = new ClPersonaE();
                objDatos.id = int.Parse(tblDatos.Rows[0]["idUsuario"].ToString());
                objDatos.nombres = tblDatos.Rows[0]["nombre"].ToString();
                objDatos.apellidos = tblDatos.Rows[0]["apellido"].ToString();
                objDatos.documento = tblDatos.Rows[0]["documento"].ToString();
                objDatos.telefono = tblDatos.Rows[0]["numeroContacto"].ToString();
                objDatos.rol = tblDatos.Rows[0]["rol"].ToString();
            }
            else {
                MessageBox.Show("Algo anda mal");
            }
            return objDatos;
        }

        public ClPersonaE MtdObtenerPersona(int id)
        {
            string consulta = $"select * from Usuario where idUsuario = {id}";
            ClAdminSQL objAdmin = new ClAdminSQL();
            DataTable tblDatos = objAdmin.MtdSelect(consulta);
            ClPersonaE objDatos = null;
            if (tblDatos.Rows.Count > 0)
            {
                objDatos = new ClPersonaE();
                objDatos.id = int.Parse(tblDatos.Rows[0]["idUsuario"].ToString());
                objDatos.nombres = tblDatos.Rows[0]["nombre"].ToString();
                objDatos.apellidos = tblDatos.Rows[0]["apellido"].ToString();
                objDatos.documento = tblDatos.Rows[0]["documento"].ToString();
                objDatos.telefono = tblDatos.Rows[0]["numeroContacto"].ToString();
                objDatos.edad = tblDatos.Rows[0]["edad"].ToString();
                objDatos.genero = tblDatos.Rows[0]["genero"].ToString();
                objDatos.correo = tblDatos.Rows[0]["correoPersonal"].ToString();
                objDatos.direccion = tblDatos.Rows[0]["direccion"].ToString();
                objDatos.rol = tblDatos.Rows[0]["rol"].ToString();
            }
            else
            {
                MessageBox.Show("Algo anda mal");
            }
            return objDatos;
        }
        public int MtdRegistrar(ClPersonaE persona) {
            ClAdminSQL clAdminSQL = new ClAdminSQL();
            string consulta = $"insert into usuario (rol,documento,nombre,apellido,numeroContacto,clave) " +
                $"values('Cliente','{persona.documento}','{persona.nombres}','{persona.apellidos}','{persona.telefono}','{persona.clave}')";
            int filasAfectadas = clAdminSQL.MtdInsertDeleteUpdate(consulta);
            return filasAfectadas;
        }
    }
}
