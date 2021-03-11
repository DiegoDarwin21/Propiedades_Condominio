using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades_Condominio
{
    class Cuotas
    {
        string nombre;
        string apellido;
        int no_CAsa;
        int cuto_Mantenimientos;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int No_CAsa { get => no_CAsa; set => no_CAsa = value; }
        public int Cuto_Mantenimientos { get => cuto_Mantenimientos; set => cuto_Mantenimientos = value; }
    }
}
