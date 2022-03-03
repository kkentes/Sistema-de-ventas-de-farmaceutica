using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo
{
    //struct registro productos
    public struct Producto
    {
        public string codigoProducto;
        public string nombreProdcuto;
        public string clasificacion;
        public string precio;
        public string descuento;
        

        public Producto(string cp, string np, string c, string p, string d)
        {
            //Asignando valor de cada dato
            codigoProducto = cp;
            nombreProdcuto = np;
            clasificacion = c;
            precio = p;
            descuento = d;

               
        }
    }
    public partial class RP : Form
    {
        //ubicacion del archivo
        public const string nombreDelArchivo = "RegistroDeProducto.txt";
        private List<Producto> listaDeProductos = new List<Producto>();

        //Busca datos en archivo de txt
        private void leerDelArchivo()
        {
            if (File.Exists(nombreDelArchivo))
            {
                //leer contenido archivo para almacenar datos en vector
                StreamReader lec = new StreamReader(nombreDelArchivo);
                listaDeProductos = new List<Producto>();
                while (lec.EndOfStream == false)
                {
                    Producto nuevoProducto = new Producto();
                    nuevoProducto.codigoProducto = lec.ReadLine();
                    nuevoProducto.nombreProdcuto = lec.ReadLine();
                    nuevoProducto.clasificacion = lec.ReadLine();
                    nuevoProducto.precio = lec.ReadLine();
                    nuevoProducto.descuento = lec.ReadLine();
                    listaDeProductos.Add(nuevoProducto);
                    
                }
                lec.Close();//cerrar lectura
            }
            imprimirLista();

        }


        //Inprime datos al grid
        private void imprimirLista()
        {
            registroDeProducto.Rows.Clear();
            for(int i = 0; i < listaDeProductos.Count; i++)
            {
                i = registroDeProducto.Rows.Add();
                registroDeProducto.Rows[i].Cells[0].Value = listaDeProductos[i].codigoProducto;
                registroDeProducto.Rows[i].Cells[1].Value = listaDeProductos[i].nombreProdcuto;
                registroDeProducto.Rows[i].Cells[2].Value = listaDeProductos[i].clasificacion;
                registroDeProducto.Rows[i].Cells[3].Value = listaDeProductos[i].precio;
                registroDeProducto.Rows[i].Cells[4].Value = listaDeProductos[i].descuento;
            }
        }

        //Configuracion Incial
        int n = 0;

        public RP()
        {
            InitializeComponent();
            leerDelArchivo();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        //Boton aggregar datos 
        private void button1_Click(object sender, EventArgs e)
        {
            //condicional if que verifica que no esten vacios los textbox
            if (
                string.IsNullOrWhiteSpace(codigoProductoBox.Text) &&
                string.IsNullOrWhiteSpace(nombreProductoBox.Text) &&
                string.IsNullOrWhiteSpace(clasificacionBox.Text) &&
                string.IsNullOrWhiteSpace(precioBox.Text) &&
                string.IsNullOrWhiteSpace(descuentoBox.Text)

                )
            {
                MessageBox.Show("Debe de llenar todos los datos para guardar...");
            }
            else
            {
                StreamWriter Esc = new StreamWriter(nombreDelArchivo, true);
                Esc.WriteLine(codigoProductoBox.Text);
                Esc.WriteLine(nombreProductoBox.Text);
                Esc.WriteLine(clasificacionBox.Text);
                Esc.WriteLine(precioBox.Text);
                Esc.WriteLine(descuentoBox.Text);
                Esc.Close();
            }
            

            //Limpiamos txtbox
            codigoProductoBox.Text = "";
            nombreProductoBox.Text = "";
            clasificacionBox.Text = "";
            precioBox.Text = "";
            descuentoBox.Text = "";

            leerDelArchivo();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            if (n != -1)
            {
                label6.Text = (string)registroDeProducto.Rows[n].Cells[1].Value;
            }
        }

        //Boton borrar 
        private void button2_Click(object sender, EventArgs e)
        {
            if (n > -1)
            {
                
                string codigoProducto = (string)registroDeProducto.Rows[n].Cells[0].Value;
                Producto productoABorrar = new Producto();

                for (int i = 0; i < listaDeProductos.Count; i++)
                {
                    if (listaDeProductos[i].codigoProducto == codigoProducto)
                    {
                        productoABorrar = listaDeProductos[i];
                    }

                }
                listaDeProductos.Remove(productoABorrar);
                reescribirArchivo();
                leerDelArchivo();
            }

           
            
        }
        private void reescribirArchivo()
        {
            StreamWriter Esc = new StreamWriter(nombreDelArchivo, false);
            foreach (Producto producto in listaDeProductos)
            {

                Esc.WriteLine(producto.codigoProducto);
                Esc.WriteLine(producto.nombreProdcuto);
                Esc.WriteLine(producto.clasificacion);
                Esc.WriteLine(producto.precio);
                Esc.WriteLine(producto.descuento);
                
            }
            Esc.Close();
        }

        private void RP_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
