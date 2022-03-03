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
    //struct mostrar venta dia
    public struct Datos3
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

        public Datos3(string FV, string CodE, string NomC, string CodP, string CV, string D, string TV, string PP, string CodV)
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

    public struct RegDatos3
    {
        public Datos3[] D;
        public int NumTotal;

        public RegDatos3(int numtotal)//metodo constructor
        {
            NumTotal = 0;
            D = new Datos3[50];//maximo de 50 registros
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
                    D[NumTotal].FechaVenta = lec.ReadLine();
                    D[NumTotal].CodEmpleado = lec.ReadLine();
                    D[NumTotal].NomCliente = lec.ReadLine();
                    D[NumTotal].CodProducto = lec.ReadLine();
                    D[NumTotal].CantVendida = lec.ReadLine();
                    D[NumTotal].Descuento = lec.ReadLine();
                    D[NumTotal].totVenta = lec.ReadLine();
                    D[NumTotal].PrecioProd = lec.ReadLine();
                    D[NumTotal].CodVenta = lec.ReadLine();

                    NumTotal++;
                }
                lec.Close();//cerrar lectura
            }
        }
    }
    public partial class MVD : Form
    {
        public MVD()
        {
            InitializeComponent();
        }

        private void MVD_Load(object sender, EventArgs e)
        {

        }

        //boton Buscar
        private void button1_Click(object sender, EventArgs e)
        {
            RegDatos3 x = new RegDatos3(0);
            x.LeerDelArchivo("Ventas.txt");


            for (int i = 0; i < x.NumTotal; i++)
            {
                if (x.D[i].FechaVenta == dateTimePicker1.Text)
                {
                    //Adicionamos nuevo reglon
                    i = dataGridView1.Rows.Add();
                    //Imprime lo que esta guardado en el archivo txt
                    dataGridView1.Rows[i].Cells[0].Value = x.D[i].FechaVenta;
                    dataGridView1.Rows[i].Cells[1].Value = x.D[i].NomCliente;
                    dataGridView1.Rows[i].Cells[2].Value = x.D[i].CodVenta;
                    dataGridView1.Rows[i].Cells[3].Value = x.D[i].CodProducto;
                    dataGridView1.Rows[i].Cells[5].Value = x.D[i].CantVendida;
                    dataGridView1.Rows[i].Cells[4].Value = x.D[i].PrecioProd;
                    dataGridView1.Rows[i].Cells[6].Value = x.D[i].Descuento;
                    dataGridView1.Rows[i].Cells[7].Value = x.D[i].totVenta;

                }

            }
        }
    }
}
