using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace wEmpresa
{
    public partial class frmMenuPrincipal : Form
    {

        //Creación de clase objeto 
        private frmMenuCargaDatos cargarDatos;


        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        #region [Inicialización de formulario secundario]

        //Creación del formulario secundario de carga de datos

        private void tsmiNuevo_Click(object sender, EventArgs e)
        {

            //Condicional que se encarga de instanciar el objeto del formulario secundario en caso de que esté vacío

            if (cargarDatos == null)
            {
                cargarDatos = new frmMenuCargaDatos();
                cargarDatos.FormClosed += new FormClosedEventHandler(CerrarForma);
                cargarDatos.Show();
            }
            else
            {
                //En caso de que el formulario tenga datos, lo que hará será solamente enseñarlo

                cargarDatos.Activate();
            }
        }

        //Botón que llama a la creación del formulario secundario

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tsmiNuevo_Click(sender, e);
        }

        #endregion

        #region [Cerrado de formulario]

        //Método que envía un mensaje de salida antes de cerrar el programa (mensaje de confirmación)

        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Mensaje de salida de confirmación antes de cerrar

            DialogResult resultado = MessageBox.Show("Realmente desea salir?", "Confirmacion",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (resultado == DialogResult.No);
        }


        //Método que borra los datos del formulario

        void CerrarForma(object sender, FormClosedEventArgs e)
        {
            //Vaciado del formulario

            cargarDatos = null;
        }

        //Método que se encarga de cerrar el formulario
        private void tsmiSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Método que llama al cerrado de los 
        private void btnSalir_Click(object sender, EventArgs e)
        {
            tsmiSalir_Click(sender, e);
        }

        #endregion


    }
}
