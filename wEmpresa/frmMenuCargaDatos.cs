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

        //Definición de variables y objeto clase

        private Stream myStream;
        int counter = 0;
        string line;

        //Condiciones iniciales del formulario

        public frmMenuCargaDatos()
        {
            InitializeComponent();
        }

        #region [.CSV]

        //Método que se encarga de cargar los archivos .csv, llenar los datos de las columnas por código
        //y añadir los datos del archivo en las filas

        private void btnCSV_Click(object sender, EventArgs e)
        {

            btnLimpiar_Click_1(sender, e);

            //Creación y adición de las columnas del DataGridView al formulario

            #region [Columnas DataGridView]

            try
            {
                counter = 0;

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

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);

            }


            #endregion

            #region [Archivo .CSV, llenado/lectura/procesado de los datos]

            try
            {
                //Definición de variable tipo arreglo y el delimitador que separará los datos del archivo

                char delimitador = ';';
                string[] valores;

                //OpenFileDialog que permite buscar el archivo en la computadora 

                OpenFileDialog cargarArchivo = new OpenFileDialog();
                cargarArchivo.InitialDirectory = Application.StartupPath;
                cargarArchivo.Filter = "Archivos (*.csv) | *.csv*";

                //Condicional que procede si se selecciona un archivo 

                if (cargarArchivo.ShowDialog() == DialogResult.OK)
                {
                
                    //Condicional que se ejecuta si el archivo no está vacío

                    if ((myStream = cargarArchivo.OpenFile()) != null)
                    {

                        //Creación e instanciación de StreamReader que se encarga de leer los datos del archivo

                        StreamReader file = new StreamReader(cargarArchivo.FileName);

                        //Bucle que llena los datos de las filas en base al archivo seleccionado

                        while ((line = file.ReadLine()) != null)
                        {

                            if (counter >= 1)
                            {
                                
                                //Divisor de datos con el punto y coma como delimitador
                                valores = line.Split(delimitador);
                                
                                //Carga de datos las filas del DataGridView
                                dtgCargaDatos.Rows.Add(valores.ToArray());

                                counter++;
                                
                            }
                            else
                            {
                                counter++;
                            }
                        }

                        //Cerrado del archivo en caso de que esté vacío o termine de leerlo

                        file.Close();
                        
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            #endregion

        }

        #endregion

        #region [.XML]

        //Método que carga y muestra por pantalla los datos de los archivos .XML

        private void btnXML_Click(object sender, EventArgs e)
        {

            btnLimpiar_Click_1(sender, e);

            //Creación de lista y serializador, instanciación de los mismos

            List<clsPersona> p1 = new List<clsPersona>();
            XmlSerializer serial = new XmlSerializer(typeof(List<clsPersona>));
            
            //Variable de texto donde se almacena la ruta del archivo para posteriormente abrirse

            String ruta = string.Empty;

            //Apertura de archivos .xml

            OpenFileDialog cargarArchivo = new OpenFileDialog();
            cargarArchivo.InitialDirectory = Application.StartupPath;
            cargarArchivo.Filter = "Archivos (*.xml)|*.xml*";
            
            //Condifional donde se verifica si se cargó un archivo y si el archivo no está vacío

            if (cargarArchivo.ShowDialog() == DialogResult.OK)
            {

                //Guardado de la ruta de acceso al archivo para usarlo posteriormente

                ruta = @cargarArchivo.FileName;

                if ((myStream = cargarArchivo.OpenFile()) != null)
                {

                    //Carga de archivo y deserialización del mismo

                    using (FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read))
                    {
                        p1 = serial.Deserialize(fs) as List<clsPersona>;
                    }

                    //Carga de datos al DataGridView

                    dtgCargaDatos.DataSource = p1;
                    
                }
            }
        }

        #endregion

        #region [Limpiar datos]

        //Sección donde se limpian los datos del DataGridView

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            try
            {
                dtgCargaDatos.DataSource = null;
                dtgCargaDatos.Rows.Clear();
                dtgCargaDatos.Columns.Clear();

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);

            }
        }

        #endregion

    }

}
