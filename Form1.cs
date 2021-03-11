﻿using System;
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
        private void Form1_Load(object sender, EventArgs e)
        {
            leer();
        }
    }
}
