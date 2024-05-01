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
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            ClRegistrarL clRegistrarL = new ClRegistrarL();
            ClPersonaE clPersonaE = new ClPersonaE();
            clPersonaE.documento = TxtDocumento.Text;
            clPersonaE.nombres = TxtNombres.Text;
            clPersonaE.apellidos = TxtApellidos.Text;
            clPersonaE.telefono = TxtTelefono.Text;
            clPersonaE.correo = TxtMail.Text;
            clPersonaE.clave = TxtClave.Text;
            int filasAfectadas = clRegistrarL.MtdRegistrar(clPersonaE);
            if (filasAfectadas >= 1)
            {
                MessageBox.Show("Usuario Registrado");
            }
            else if (filasAfectadas == -1)
            {
                MessageBox.Show("Usuario con documento " + TxtDocumento.Text + " ya registrado");
            }
            else {
                MessageBox.Show("Algo salió mal");
            }
        }
    }
}
