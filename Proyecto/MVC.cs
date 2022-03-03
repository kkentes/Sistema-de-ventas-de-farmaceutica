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
    //struct mostrar venta c
    public struct Datos2
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

        public Datos2(string FV, string CodE, string NomC, string CodP, string CV, string D, string TV, string PP, string CodV)
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

    public struct RegDatos2
    {
        public Datos2[] C;
        public int NumTotal;

        public RegDatos2(int numtotal)//metodo constructor
        {
            NumTotal = 0;
            C = new Datos2[50];//maximo de 50 registros
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
                    C[NumTotal].FechaVenta = lec.ReadLine();
                    C[NumTotal].CodEmpleado = lec.ReadLine();
                    C[NumTotal].NomCliente = lec.ReadLine();
                    C[NumTotal].CodProducto = lec.ReadLine();
                    C[NumTotal].CantVendida = lec.ReadLine();
                    C[NumTotal].Descuento = lec.ReadLine();
                    C[NumTotal].totVenta = lec.ReadLine();
                    C[NumTotal].PrecioProd = lec.ReadLine();
                    C[NumTotal].CodVenta = lec.ReadLine();

                    NumTotal++;
                }
                lec.Close();//cerrar lectura
            }
        }
    }
        public partial class MVC : Form
    {
        public MVC()
        {
            InitializeComponent();
            RegDatos2 x = new RegDatos2(0);
           ;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        //Boton buscar
        private void button1_Click(object sender, EventArgs e)
        {
            RegDatos2 xx = new RegDatos2(0);
            xx.LeerDelArchivo("Ventas.txt");


                for (int i = 0; i < xx.NumTotal; i++)
                {
                      if (xx.C[i].CodProducto == textBox1.Text)
                      {
                        //Adicionamos nuevo reglon
                        i = dataGridView1.Rows.Add();
                         //Imprime lo que esta guardado en el archivo txt
                         dataGridView1.Rows[i].Cells[0].Value = xx.C[i].CodEmpleado;
                         dataGridView1.Rows[i].Cells[1].Value = xx.C[i].NomCliente;
                         dataGridView1.Rows[i].Cells[2].Value = xx.C[i].CodProducto;
                         dataGridView1.Rows[i].Cells[3].Value = xx.C[i].PrecioProd;
                         dataGridView1.Rows[i].Cells[5].Value = xx.C[i].CodVenta;
                         dataGridView1.Rows[i].Cells[4].Value = xx.C[i].CantVendida;
                         dataGridView1.Rows[i].Cells[6].Value = xx.C[i].Descuento;
                         dataGridView1.Rows[i].Cells[7].Value = xx.C[i].totVenta;

                      }
                   
                }
            
           
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
