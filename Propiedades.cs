using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades_Condominio
{
    class Propiedades
    {
        int no_Casa;
        string dpi;
        int cuota_Mantenimiento;

        public int No_Casa { get => no_Casa; set => no_Casa = value; }
        public string Dpi { get => dpi; set => dpi = value; }
        public int Cuota_Mantenimiento { get => cuota_Mantenimiento; set => cuota_Mantenimiento = value; }
    }
}
