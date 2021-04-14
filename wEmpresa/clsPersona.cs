using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wEmpresa
{
    public class clsPersona
    {

        //Getters y setters que almacena los datos de entrada del archivo XML

        public double Cedula { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public int Edad { get; set; }
        public String FechaNacimiento { get; set; }
        public String Profesion { get; set; }
        public String EstadoCivil { get; set; }

    }
}
