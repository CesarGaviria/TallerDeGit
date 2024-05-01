using ProyectoSprintUnoPrueba.Entidades;
using ProyectoSprintUnoPrueba.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSprintUnoPrueba.Vista
{
    public partial class frmMenuCliente : Form
    {
        public int id { get; set; }
        public frmMenuCliente()
        {
            InitializeComponent();
        }

        private void Documento_Click(object sender, EventArgs e)
        {

        }

        private void frmMenuCliente_Load(object sender, EventArgs e)
        {
            
            ClLoginL objClLogica = new ClLoginL();
            ClPersonaE objDatos = objClLogica.MtdObtenerPersona(id);
            TxtDocumento.Text = objDatos.documento;
            TxtNombres.Text = objDatos.nombres;
            TxtApellidos.Text = objDatos.apellidos;
            TxtTelefono.Text = objDatos.telefono;
            TxtMail.Text = objDatos.correo;
            TxtEdad.Text = objDatos.edad;
            TxtGenero.Text = objDatos.genero;
            TxtDireccion.Text = objDatos.direccion;
            
        }

       
    }
}
