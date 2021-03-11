using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Propiedades_Condominio
{
    public partial class Form1 : Form
    {
        List<Propiedades> listaPropiedades = new List<Propiedades>();
        List<Propietarios> listaPropietarios = new List<Propietarios>();

        public Form1()
        {
            InitializeComponent();
        }
        private void leer()
        {
            FileStream stream = new FileStream("Propietarios.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Propietarios Temp = new Propietarios();

                Temp.Dpi = reader.ReadLine();
                Temp.Nombre= reader.ReadLine();
                Temp.Apellido = reader.ReadLine();
                

                listaPropietarios.Add(Temp);

            }
            //Cerrar el archivo, esta linea es importante porque sino despues de correr varias veces el programa daría error de que el archivo quedó abierto muchas veces. Entonces es necesario cerrarlo despues de terminar de leerlo.
            reader.Close();

            FileStream stream2 = new FileStream("Propiedades.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader2 = new StreamReader(stream2);

            while (reader2.Peek() > -1)
            {
                Propiedades Temp = new Propiedades();

                Temp.No_Casa = Convert.ToInt16(reader2.ReadLine());
                Temp.Dpi = reader2.ReadLine();
                Temp.Cuota_Mantenimiento = Convert.ToInt16(reader2.ReadLine());
       

                listaPropiedades.Add(Temp);

            }
            //Cerrar el archivo, esta linea es importante porque sino despues de correr varias veces el programa daría error de que el archivo quedó abierto muchas veces. Entonces es necesario cerrarlo despues de terminar de leerlo.
            reader2.Close();
        }

        private void Guardar()
        {
            //Abrir el archivo: Write sobreescribe el archivo, Append agrega los datos al final del archivo
            FileStream stream = new FileStream("Propietarios.txt", FileMode.Create, FileAccess.Write);
            //Crear un objeto para escribir el archivo
            StreamWriter writer = new StreamWriter(stream);
            //Usar el objeto para escribir al archivo, WriteLine, escribe linea por linea
            //Write escribe todo en la misma linea. En este ejemplo se hará un dato por cada línea
            foreach (var p in listaPropietarios)
            {
                writer.WriteLine(p.Dpi);
                writer.WriteLine(p.Nombre);
                writer.WriteLine(p.Apellido);
            }
            //Cerrar el archivo
            writer.Close();

            FileStream stream2 = new FileStream("Propiedades.txt", FileMode.Create, FileAccess.Write);
            //Crear un objeto para escribir el archivo
            StreamWriter writer2 = new StreamWriter(stream2);
            //Usar el objeto para escribir al archivo, WriteLine, escribe linea por linea
            //Write escribe todo en la misma linea. En este ejemplo se hará un dato por cada línea
            foreach (var p in listaPropiedades)
            {
                writer2.WriteLine(p.No_Casa);
                writer2.WriteLine(p.Dpi);
                writer2.WriteLine(p.Cuota_Mantenimiento);
            }
            //Cerrar el archivo
            writer2.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            leer();
        }
    }
}
