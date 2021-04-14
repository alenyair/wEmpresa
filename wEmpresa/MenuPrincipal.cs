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

        private MenuCargaDatos forma;
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (forma == null)
            {
                forma = new MenuCargaDatos();
             //   forma.MdiParent = this;
                forma.FormClosed += new FormClosedEventHandler(CerrarForma);
                forma.Show();
            }

            else
            {
                forma.Activate();
            }
        }

        void CerrarForma(object sender, FormClosedEventArgs e)
        {
            forma = null;
        }

        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Realmente desea salir?", "Confirmacion",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (resultado == DialogResult.No);
        }

       
    }
}
