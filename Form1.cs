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
        List<Cuotas> listaCuotas = new List<Cuotas>();
 
        

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

        private void mostrar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaCuotas;
            dataGridView1.Refresh();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            leer();
            // después de leer se llena la propiedad contador, que se la que sirve para
            // llevar cuenta de todas las propiedades que poseen y a la vez llena los datos
           // de la lista que se mostrará en el gridview
            for(int x=0; x<listaPropietarios.Count; x++)
            {
                for(int y=0; y<listaPropiedades.Count; y++)
                {
                    if (listaPropiedades[y].Dpi == listaPropietarios[x].Dpi)
                    {
                        listaPropietarios[x].Contador++;
                        Cuotas c = new Cuotas();
                        c.Nombre = listaPropietarios[x].Nombre;
                        c.Apellido = listaPropietarios[x].Apellido;
                        c.No_CAsa = listaPropiedades[y].No_Casa;
                        c.Cuota_Mantenimientos = listaPropiedades[y].Cuota_Mantenimiento;

                        listaCuotas.Add(c);
                    }
                    
                }
            }


            mostrar();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listaCuotas = listaCuotas.OrderByDescending(c => c.Cuota_Mantenimientos).ToList();
            mostrar();
        }

        private void CuotaAscendente_CheckedChanged(object sender, EventArgs e)
        {
            listaCuotas = listaCuotas.OrderBy(c => c.Cuota_Mantenimientos).ToList();
            mostrar();

          //  dueño = dueño.OrderBy(cuota => cuota.Cuota_mantenimiento).ToList();
           // mostrar();
        }

        private void propiedades_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            List<Cuotas> tresmasaltasybajas = new List<Cuotas>();

            listaCuotas = listaCuotas.OrderByDescending(c => c.Cuota_Mantenimientos).ToList();
            for (int x = 0; x < 3; x++)
            {
                tresmasaltasybajas.Add(listaCuotas[x]);
            }

            listaCuotas = listaCuotas.OrderBy(c => c.Cuota_Mantenimientos).ToList();

            for (int x = 0; x < 3; x++)
            {
                tresmasaltasybajas.Add(listaCuotas[x]);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tresmasaltasybajas;
            dataGridView1.Refresh();
        }
    }
}
