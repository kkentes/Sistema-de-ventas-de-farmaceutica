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
    //Estruc registro de empleado
    public struct Empleado
    {
        public string cargo;
        public string usuario;
        public string nombre;
        public string apellido;
        public string contraseña;
        public string direccion;
        public string telefono;


        public Empleado(string c, string u, string n, string a, string cñ, string d, string t)
        {
            //Asignando valor de cada dato
            cargo = c;
            usuario = u;
            nombre = n;
            apellido = a;
            contraseña = cñ;
            direccion = d;
            telefono = t;

        }
    }
    public partial class RE : Form
    {
        //Direccion de el archivo txt
        public const string nombreDelArchivo = "registropersonas.txt";
        private List<Empleado> listaDeEmpleados = new List<Empleado>();
        private void leerDelArchivo()
        {
            if (File.Exists(nombreDelArchivo))
            {
                //leer contenido archivo para almacenar datos en vector
                StreamReader lec = new StreamReader(nombreDelArchivo);
                listaDeEmpleados = new List<Empleado>();
                while (lec.EndOfStream == false)
                {
                    Empleado nuevoEmpleado = new Empleado();
                    nuevoEmpleado.cargo = lec.ReadLine();
                    nuevoEmpleado.usuario = lec.ReadLine();
                    nuevoEmpleado.nombre = lec.ReadLine();
                    nuevoEmpleado.apellido = lec.ReadLine();
                    nuevoEmpleado.contraseña = lec.ReadLine();
                    nuevoEmpleado.direccion = lec.ReadLine();
                    nuevoEmpleado.telefono = lec.ReadLine();

                    listaDeEmpleados.Add(nuevoEmpleado);

                }
                lec.Close();//cerrar lectura
            }
            imprimirLista();

        }

        //Imprime datos del struct al grid
        private void imprimirLista()
        {
            registroDeEmpleado.Rows.Clear();
            for (int i = 0; i < listaDeEmpleados.Count; i++)
            {
                i = registroDeEmpleado.Rows.Add();
                registroDeEmpleado.Rows[i].Cells[0].Value = listaDeEmpleados[i].cargo;
                registroDeEmpleado.Rows[i].Cells[1].Value = listaDeEmpleados[i].usuario;
                registroDeEmpleado.Rows[i].Cells[2].Value = listaDeEmpleados[i].nombre;
                registroDeEmpleado.Rows[i].Cells[3].Value = listaDeEmpleados[i].apellido;
                registroDeEmpleado.Rows[i].Cells[4].Value = listaDeEmpleados[i].contraseña;
                registroDeEmpleado.Rows[i].Cells[5].Value = listaDeEmpleados[i].direccion;
                registroDeEmpleado.Rows[i].Cells[6].Value = listaDeEmpleados[i].telefono;

            }
        }

        int n = 0;
        public RE()
            {
                InitializeComponent();
                leerDelArchivo();
            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox2_TextChanged(object sender, EventArgs e)
            {

            }

            private void label2_Click(object sender, EventArgs e)
            {

            }

            private void textBox4_TextChanged(object sender, EventArgs e)
            {

            }

            private void RE_Load(object sender, EventArgs e)
            {

            }

        //Boton reguistar
        private void registrarEmpleadoBoton_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrWhiteSpace(cargoBox.Text) &&
                string.IsNullOrWhiteSpace(nombreDeUsuarioBox.Text) &&
                string.IsNullOrWhiteSpace(primerNombreBox.Text) &&
                string.IsNullOrWhiteSpace(apellidoBox.Text) &&
                string.IsNullOrWhiteSpace(contraseñaBox.Text)&&                
                string.IsNullOrWhiteSpace(direccionBox.Text) &&
                string.IsNullOrWhiteSpace(telefonoBox.Text) 


                )
            {
                MessageBox.Show("Debe de llenar todos los datos para guardar...");
            }
            else
            {
                StreamWriter Esc = new StreamWriter(nombreDelArchivo, true);
                Esc.WriteLine(cargoBox.Text);
                Esc.WriteLine(nombreDeUsuarioBox.Text);
                Esc.WriteLine(primerNombreBox.Text);
                Esc.WriteLine(apellidoBox.Text);
                Esc.WriteLine(contraseñaBox.Text);
                Esc.WriteLine(direccionBox.Text);
                Esc.WriteLine(telefonoBox.Text);
                Esc.Close();
            }


            //Limpiamos txtbox
            cargoBox.Text = "";
            nombreDeUsuarioBox.Text = "";
            primerNombreBox.Text = "";
            apellidoBox.Text = "";
            contraseñaBox.Text = "";
            direccionBox.Text = "";
            telefonoBox.Text = "";

            leerDelArchivo();
        }
        private void registroDeEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //Boton borrar
        private void borrarEmpleadoBoton_Click(object sender, EventArgs e)
        {
            if (n > -1)
            {

                string usuario = (string)registroDeEmpleado.Rows[n].Cells[1].Value;
                Empleado empleadoABorrar = new Empleado();

                for (int i = 0; i < listaDeEmpleados.Count; i++)
                {
                    if (listaDeEmpleados[i].usuario == usuario)
                    {
                        empleadoABorrar = listaDeEmpleados[i];
                    }

                }
                listaDeEmpleados.Remove(empleadoABorrar);
                reescribirArchivo();
                leerDelArchivo();
            }
        }
        private void reescribirArchivo()
        {
            StreamWriter Esc = new StreamWriter(nombreDelArchivo, false);
            foreach (Empleado empleado in listaDeEmpleados)
            {

                Esc.WriteLine(empleado.cargo);
                Esc.WriteLine(empleado.usuario);
                Esc.WriteLine(empleado.nombre);
                Esc.WriteLine(empleado.apellido);
                Esc.WriteLine(empleado.contraseña);
                Esc.WriteLine(empleado.direccion);
                Esc.WriteLine(empleado.telefono);

            }
            Esc.Close();
        }

        private void registroDeEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            if (n != -1)
            {
                label7.Text = (string)registroDeEmpleado.Rows[n].Cells[1].Value;
            }
        }
    }
    }

