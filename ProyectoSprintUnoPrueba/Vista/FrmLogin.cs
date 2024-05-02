using ProyectoSprintUnoPrueba.Entidades;
using ProyectoSprintUnoPrueba.Logica;
using ProyectoSprintUnoPrueba.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSprintUnoPrueba
{
    public partial class FrmLogin : Form
    {

        private int id;
        public FrmLogin()
        {
            InitializeComponent();
        }

 
        private void LkLblRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           FrmRegistro frmRegistro = new FrmRegistro();
            frmRegistro.Show();
        }

        public int MtdObtenerId() {      
          return id;   
        }
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string Usuario = TxtUsuario.Text;
            string Clave = TxtClave.Text;

            ClLoginL objClLogica = new ClLoginL();
            ClPersonaE objDatos = objClLogica.MtdLogin(Usuario, Clave);
            

            
            if (objDatos != null)
            {
                MessageBox.Show(objDatos.rol);
                if (objDatos.rol == "Admin")
                {
                    FrmMenuAdmin frmMenuAdmin = new FrmMenuAdmin();
                    frmMenuAdmin.id = objDatos.id;
                    frmMenuAdmin.Show();
                    
                }
                else if (objDatos.rol == "Cliente") {
                    frmMenuCliente frmMenuCliente = new frmMenuCliente();
                    frmMenuCliente.id = objDatos.id;
                    frmMenuCliente.Show();
                }


            }
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

            MessageBox.Show("Hola github este es mi primer commit and push");
        }
    }
}
