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

namespace Prototipo
{
    //stuct mostrar venta empleado
    public struct Datos4
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

        public Datos4(string FV, string CodE, string NomC, string CodP, string CV, string D, string TV, string PP, string CodV)
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

    public struct RegDatos4
    {
        public Datos4[] E;
        public int NumTotal;

        public RegDatos4(int numtotal)//metodo constructor
        {
            NumTotal = 0;
            E = new Datos4[50];//maximo de 50 registros
        }

        //recuperar personas registradas hacia el vector
        public void LeerDelArchivo(string urlarchivo)
        {
            if (File.Exists(urlarchivo))
            {
                //leer contenido archivo para almacenar datos en vector
                StreamReader lec = new StreamReader(urlarchivo);
                while (lec.EndOfStream == false)
                {
                    E[NumTotal].FechaVenta = lec.ReadLine();
                    E[NumTotal].CodEmpleado = lec.ReadLine();
                    E[NumTotal].NomCliente = lec.ReadLine();
                    E[NumTotal].CodProducto = lec.ReadLine();
                    E[NumTotal].CantVendida = lec.ReadLine();
                    E[NumTotal].Descuento = lec.ReadLine();
                    E[NumTotal].totVenta = lec.ReadLine();
                    E[NumTotal].PrecioProd = lec.ReadLine();
                    E[NumTotal].CodVenta = lec.ReadLine();

                    NumTotal++;
                }
                lec.Close();//cerrar lectura
            }
        }
    }
    public partial class MVE : Form
    {
        public MVE()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MVE_Load(object sender, EventArgs e)
        {

        }

       //boton buscar
        private void button1_Click(object sender, EventArgs e)
        {
            RegDatos4 x = new RegDatos4(0);
            x.LeerDelArchivo("Ventas.txt");


            for (int i = 0; i < x.NumTotal; i++)
            {
                if (x.E[i].CodEmpleado == textBox1.Text)
                {
                    //Adicionamos nuevo reglon
                    i = dataGridView1.Rows.Add();
                    //Imprime lo que esta guardado en el archivo txt
                    dataGridView1.Rows[i].Cells[0].Value = x.E[i].FechaVenta;
                    dataGridView1.Rows[i].Cells[1].Value = x.E[i].NomCliente;
                    dataGridView1.Rows[i].Cells[2].Value = x.E[i].CodVenta;
                    dataGridView1.Rows[i].Cells[3].Value = x.E[i].CodProducto;
                    dataGridView1.Rows[i].Cells[5].Value = x.E[i].CantVendida;
                    dataGridView1.Rows[i].Cells[4].Value = x.E[i].PrecioProd;
                    dataGridView1.Rows[i].Cells[6].Value = x.E[i].Descuento;
                    dataGridView1.Rows[i].Cells[7].Value = x.E[i].totVenta;

                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
