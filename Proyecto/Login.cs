using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace Prototipo
{
    public struct Datos
    {
        //struct Datos

        public string rol;
        public string codigo;
        public string nombre;
        public string apellido;
        public string contraseña;
        public string direccion;
        public string telefono;

        //Metodo constructor(Iniciar los campos)

        public Datos(string ro,string cod, string nom, string apell, string contra, string direcc, string tele)
        {
            //Asignando valor de cada dato
            rol = ro;
            codigo = cod;
            nombre = nom;
            apellido = apell;
            contraseña = contra;
            direccion = direcc;
            telefono = tele;
        }

    }

    public struct listapersona
    {
        //arreglo struct personas
        public Datos[] personas;//declarar arreglo
        public int totpersonas;//contador de personas registradas

        public listapersona(int TotPersonas)//metodo constructor
        {
            totpersonas = 0;
            personas = new Datos[50];//maximo de 50 personas registradas
        }

        //crud crear, leer, escribir, borrar
        public void agregarpersona(string ro, string cod, string nom, string apell, string contra, string direcc, string tele)
        {
            personas[totpersonas] = new Datos( ro, cod, nom, apell, contra, direcc, tele);
            totpersonas++;
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
                    personas[totpersonas].rol = lec.ReadLine();
                    personas[totpersonas].codigo = lec.ReadLine();
                    personas[totpersonas].nombre = lec.ReadLine();
                    personas[totpersonas].apellido = lec.ReadLine();
                    personas[totpersonas].contraseña = lec.ReadLine();
                    personas[totpersonas].direccion = lec.ReadLine();
                    personas[totpersonas].telefono = lec.ReadLine();

                    totpersonas++;
                }
                lec.Close();//cerrar lectura
            }
        }

        //ecritura si no existe lo escribe
        public void EscribirhaciaArchivo(string urlarchivo)
        {
            StreamWriter Esc = new StreamWriter(urlarchivo, true);
            for (int i = 0; i < totpersonas; i++)
            {
                Esc.WriteLine(personas[i].rol);
                Esc.WriteLine(personas[i].codigo);
                Esc.WriteLine(personas[i].nombre);
                Esc.WriteLine(personas[i].apellido);
                Esc.WriteLine(personas[i].contraseña);
                Esc.WriteLine(personas[i].direccion);
                Esc.WriteLine(personas[i].telefono);
                
            }
            Esc.Close();
        }

        //login 
        public void Usuarios(string Cod, string con)
        {

            Bienvenida2E DE = new Bienvenida2E();
            Bienvenida2G DG = new Bienvenida2G();

            string Codigo = Cod;
            string Contraseña = con;
            if (totpersonas == 0)
                Console.WriteLine("Aun no hay personas registradas");
            else
            {
                

                for (int i = 0; i < totpersonas; i++)
                {
                    
                    if (personas[i].codigo == Codigo)
                    {
                        if (personas[i].contraseña == Contraseña)
                        {
                            if (personas[i].rol == "Gerente")
                            {
                                //muestra el nombre y apellido del usuario en la siguiente form
                                DG.LG.Text = personas[i].nombre;
                                DG.LG2.Text = personas[i].apellido;
                                DG.TB0.Text = personas[i].codigo;

                                DG.Show();
                                //this.Close();
                            }

                            else if (personas[i].rol == "Empleado")
                            {
                                //muestra el nombre y apellido del usuario en la siguiente form
                                DE.LE.Text = personas[i].nombre;
                                DE.LE2.Text = personas[i].apellido;
                                DE.TB0.Text = personas[i].codigo;
                                //ME.TB0.Text = Codigo;
                                DE.Show();
                                //this.Close();
                            }
                        }
                        else
                        {
                            Error E = new Error();
                            // muestra mensage de error si no ingrese un usuario o contraseña validos
                            E.Show();
                            //this.Close();
                        }

                    }                   

                }
            }
        }
    }


        public partial class Login : Form
    {
                     
        public Login()
        {
            InitializeComponent();

            //variable struct listapersonas
             listapersona xx;
            xx = new listapersona(0);

            //agregar personas al estruct 
            xx.agregarpersona("Gerente", "G12536", "Mario", "suarez", "123456", "apopa", "52362536");
            xx.agregarpersona("Gerente", "G26352", "Carlos", "Hernandez", "123456", "San martin", "75322052");
            xx.agregarpersona("Empleado", "E18957", "Rodrigo", "alvarado", "123456", "Santa tecla", "22903625");
            xx.agregarpersona("Empleado", "E24556", "Josue", "Fuentes", "123456", "Soyapango", "72453292");
                   
            //agragar personas a archivo

           // xx.EscribirhaciaArchivo("registropersonas.txt");

            
        }    

        private void Form2_Load(object sender, EventArgs e)
        {

        }

   

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //evento salir

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Usted quiere salir de la aplicacion?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
            
        }

        private void B1_Click(object sender, EventArgs e)
        {
            //variable struct listapersonas

            listapersona xx;
            xx = new listapersona(0);

            string Codigo, Contraseña;
            // Mini base de datos


           
            
            //datos de los textbox escritos por el usuario
            Codigo = TB1.Text;
            Contraseña = TB2.Text;

              
           

            //objeto del form error
            Error E = new Error();

            xx.LeerDelArchivo("registropersonas.txt");

            //condicional si coincide el codigo y usuario para dar acceso
            xx.Usuarios(Codigo, Contraseña);
            this.Hide();
        }
                
        //Evento si el mause se posiciona arriba del textbox se eliminare el texto que contenga

        private void TB1_Enter(object sender, EventArgs e)
        {
            if(TB1.Text == "COD USUARIO")
            {
                TB1.Text = "";

            }
        }

        //Evento si el mause se posiciona arriba del textbox se eliminare el texto que contenga

        private void TB2_Enter(object sender, EventArgs e)
        {
            if (TB2.Text == "CONTRASEÑA")
            {
                TB2.Text = "";
                TB2.UseSystemPasswordChar = true;

            }
        }


        //evento si el mause se posiciona fuera del textbox el contenido se reescribira con el texto por defecto
        private void TB1_Leave(object sender, EventArgs e)
        {
            if(TB1.Text == "")
            {
                TB1.Text = "COD USUARIO";
            }
        }

        //evento si el mause se posiciona fuera del textbox el contenido se reescribira con el texto por defecto

        private void TB2_Leave(object sender, EventArgs e)
        {
            if(TB2.Text == "")
            {
                TB2.Text = "CONTRASEÑA";
                TB2.UseSystemPasswordChar = false;
            }
        }

        private void TB2_TextChanged(object sender, EventArgs e)
        {

        }

        //hace que se pueda mover la ventana a preferencia

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        //hace que se pueda mover la ventana a preferencia

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //hace que se pueda mover la ventana a preferencia

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB2_Validating(object sender, CancelEventArgs e)
        {
            if (TB2.TextLength < 6)
            {
                //MessageBox.Show("Contraseña muy corta");
                L1.Text = "Contraseña corta";
                L1.Visible = true;
            }
            else
            {
                L1.Visible = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TB1_Validating(object sender, CancelEventArgs e)
        {
            
        }

       

        
    }
}
