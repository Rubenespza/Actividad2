using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    class Alumnos
    {
        string nombre;
        string id;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
            
        }
        public override string ToString()
        {
            return id + " " + nombre;
        }
    }
}
