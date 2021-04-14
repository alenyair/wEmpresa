using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;


namespace wEmpresa
{
    public partial class frmMenuCargaDatos : Form
    {
        private Stream myStream;
        int counter = 0;
        string line;
        public frmMenuCargaDatos()
        {
            InitializeComponent();
        }

        private void btnCSV_Click(object sender, EventArgs e)
        {
                  
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Cedula";
            col1.Width = 200;
            col1.ReadOnly = true;
            dtgCargaDatos.Columns.Add(col1);

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "nombre";
            col2.Width = 200;
            col2.ReadOnly = true;
            dtgCargaDatos.Columns.Add(col2);

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Apellido";
            col3.Width = 200;
            col3.ReadOnly = true;
            dtgCargaDatos.Columns.Add(col3);


            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "Edad";
            col4.Width = 200;
            col4.ReadOnly = true;
            dtgCargaDatos.Columns.Add(col4);

            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.HeaderText = "Fecha Nacimiento";
            col5.Width = 200;
            col5.ReadOnly = true;
            dtgCargaDatos.Columns.Add(col5);

            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
            col6.HeaderText = "Profesion";
            col6.Width = 200;
            col6.ReadOnly = true;
            dtgCargaDatos.Columns.Add(col6);

            DataGridViewTextBoxColumn col7 = new DataGridViewTextBoxColumn();
            col7.HeaderText = "Estado Civil";
            col7.Width = 200;
            col7.ReadOnly = true;
            dtgCargaDatos.Columns.Add(col7);

            
            char delimitador = ';';
            string[] valores;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Archivos (*.csv) | *.csv*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog1.FileName);

                        while ((line = file.ReadLine()) != null)
                        {
                            if (counter >= 1)
                            {
                                valores = line.Split(delimitador);

                                dtgCargaDatos.Rows.Add(valores.ToArray());
                                counter++;
                            }
                            else
                            {
                                counter++;
                            }
                        }
                        file.Close();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }



        }



        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            dtgCargaDatos.Rows.Clear();
            dtgCargaDatos.Columns.Clear();     
        }

        private void btnXML_Click(object sender, EventArgs e)
        {

            List<clsPersona> p1 = new List<clsPersona>();
            XmlSerializer serial = new XmlSerializer(typeof(List<clsPersona>));
            String ruta = string.Empty;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Archivos (*.xml)|*.xml*";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ruta = @openFileDialog1.FileName;

                if ((myStream = openFileDialog1.OpenFile()) != null)
                {

                    using (FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read))
                    {
                        p1 = serial.Deserialize(fs) as List<clsPersona>;
                    }
                    dtgCargaDatos.DataSource = p1;
                    
                }
            }



        }
    }
    
}
