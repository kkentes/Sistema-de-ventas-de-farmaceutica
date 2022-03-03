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
using System.Security.Cryptography;
using Microsoft.Win32;

namespace Prototipo
{
    //struct de datos de venta
    public struct Ventas
    {
        public string FechaVenta;
        public string CodEmpleado;
        public string NomCliente;
        public string CodProducto;
        public string CantVendida;
        public string Descuento;
        public string totVenta;
        public string PrecioProd;
        public string CodVenta;

        public Ventas(string FV, string CodE, string NomC, string CodP, string CV, string D, string TV, string PP, string CodV)
        {
            //Asignando valor de cada dato
            FechaVenta = FV;
            CodEmpleado = CodE;
            NomCliente = NomC;
            CodProducto = CodP;
            CantVendida = CV;
            Descuento = D;
            totVenta = TV;
            PrecioProd = PP;
            CodVenta = CodV;
        }
    }

   



    public partial class RV : Form
    {
        public const string nombreDelArchivo = "Ventas.txt";
        private List<Ventas> listaDeVentas = new List<Ventas>();
        private void leerDelArchivo()
        {
            if (File.Exists(nombreDelArchivo))
            {
                //leer contenido archivo para almacenar datos en vector
                StreamReader lec = new StreamReader(nombreDelArchivo);
                listaDeVentas = new List<Ventas>();
                while (lec.EndOfStream == false)
                {
                    Ventas nuevaVenta = new Ventas();
                    nuevaVenta.FechaVenta = lec.ReadLine();
                    nuevaVenta.CodEmpleado = lec.ReadLine();
                    nuevaVenta.NomCliente = lec.ReadLine();
                    nuevaVenta.CodProducto = lec.ReadLine();
                    nuevaVenta.PrecioProd = lec.ReadLine();
                    nuevaVenta.CodVenta = lec.ReadLine();
                    nuevaVenta.CantVendida = lec.ReadLine();
                    nuevaVenta.Descuento = lec.ReadLine();
                    nuevaVenta.totVenta = lec.ReadLine();
                    
                   
                    listaDeVentas.Add(nuevaVenta);

                }
                lec.Close();//cerrar lectura
            }
            imprimirLista();

        }


        //Metodo imprimir lista
        private void imprimirLista()
        {
            registroDeVentas.Rows.Clear();
            for (int i = 0; i < listaDeVentas.Count; i++)
            {
                i = registroDeVentas.Rows.Add();
                
                registroDeVentas.Rows[i].Cells[0].Value = listaDeVentas[i].CodEmpleado;
                registroDeVentas.Rows[i].Cells[1].Value = listaDeVentas[i].NomCliente;
                registroDeVentas.Rows[i].Cells[2].Value = listaDeVentas[i].CodProducto;
                registroDeVentas.Rows[i].Cells[3].Value = listaDeVentas[i].PrecioProd;
                registroDeVentas.Rows[i].Cells[4].Value = listaDeVentas[i].CodVenta;
                registroDeVentas.Rows[i].Cells[5].Value = listaDeVentas[i].CantVendida;
                registroDeVentas.Rows[i].Cells[6].Value = listaDeVentas[i].Descuento;
                registroDeVentas.Rows[i].Cells[7].Value = listaDeVentas[i].totVenta;
            }
        }
        int n = 0;

       

        public RV()
        {
            InitializeComponent();
            leerDelArchivo();
            

            
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
         
        }

        private void RV_Load(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //condicional que verifica si estan vacios los txt muestre mensage


            if (
                string.IsNullOrWhiteSpace(CE.Text) &&
                string.IsNullOrWhiteSpace(NC.Text) &&
                string.IsNullOrWhiteSpace(CP.Text) &&
                string.IsNullOrWhiteSpace(PP.Text) &&
                string.IsNullOrWhiteSpace(CV.Text) &&
                string.IsNullOrWhiteSpace(CAV.Text) &&
                string.IsNullOrWhiteSpace(D.Text) &&
                string.IsNullOrWhiteSpace(TV.Text)

                )
            {
                MessageBox.Show("Debe de llenar todos los datos para guardar...");
            }
            else
            {
                StreamWriter Esc = new StreamWriter(nombreDelArchivo, true);
                Esc.WriteLine(T.Text);
                Esc.WriteLine(CE.Text);
                Esc.WriteLine(NC.Text);
                Esc.WriteLine(CP.Text);
                Esc.WriteLine(PP.Text);
                Esc.WriteLine(CV.Text);
                Esc.WriteLine(CAV.Text);
                Esc.WriteLine(D.Text);
                Esc.WriteLine(TV.Text);
                Esc.Close();
            }



            //Limpiamos txtbox
            CE.Text = "";
            NC.Text = "";
            CP.Text = "";
            PP.Text = "";
            CV.Text = "";
            CAV.Text="";
            D.Text = "";
            TV.Text = "";

            leerDelArchivo();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Borrar dato seleccionado en grid 
            if (n > -1)
            {

                string codigoVenta = (string)registroDeVentas.Rows[n].Cells[4].Value;
                Ventas ventaABorrar = new Ventas();

                for (int i = 0; i < listaDeVentas.Count; i++)
                {
                    if (listaDeVentas[i].CodVenta == codigoVenta)
                    {
                        ventaABorrar = listaDeVentas[i];
                    }

                }
                listaDeVentas.Remove(ventaABorrar);
                reescribirArchivo();
                leerDelArchivo();
            }
        }
        private void reescribirArchivo()
        {
            StreamWriter Esc = new StreamWriter(nombreDelArchivo, false);
            foreach (Ventas venta in listaDeVentas)
            {

                Esc.WriteLine(venta.FechaVenta);
                Esc.WriteLine(venta.CodEmpleado);
                Esc.WriteLine(venta.NomCliente);
                Esc.WriteLine(venta.CodProducto);
                Esc.WriteLine(venta.PrecioProd);
                Esc.WriteLine(venta.CodVenta);
                Esc.WriteLine(venta.CantVendida);
                Esc.WriteLine(venta.Descuento);
                Esc.WriteLine(venta.totVenta);

            }
            Esc.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void registroDeVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            if (n != -1)
            {
                label1.Text = (string)registroDeVentas.Rows[n].Cells[4].Value;
            }
        }
    }
}
