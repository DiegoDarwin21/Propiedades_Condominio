using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades_Condominio
{
    class Cuota_total
    {
        string nombre;
        string apellido;
        int cantidad_Propiedades;
        int cuota_Total;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Cantidad_Propiedades { get => cantidad_Propiedades; set => cantidad_Propiedades = value; }
        public int Cuota_Total { get => cuota_Total; set => cuota_Total = value; }
    }
}
