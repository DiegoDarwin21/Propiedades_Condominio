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
        int cuota_Mantenimientos;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int No_CAsa { get => no_CAsa; set => no_CAsa = value; }
        public int Cuota_Mantenimientos { get => cuota_Mantenimientos; set => cuota_Mantenimientos = value; }
    }
}
