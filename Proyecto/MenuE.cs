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

namespace Prototipo
{
   
    public partial class MenuE : Form
    {


        public MenuE()
        {
            InitializeComponent();
           
        }   

        //Cod para mover ventana

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);


        private void B1_Click(object sender, EventArgs e)
        {
            //evento boton salir
            if (MessageBox.Show("Usted quiere salir de la aplicacion?" , "Advertencia" , MessageBoxButtons.YesNo , MessageBoxIcon.Warning) == DialogResult.Yes)
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void AbrirformularioRV(object RV)
        {
            //cod que hace que un form entre dentro de un panel y tome sus caracteristicas de tamaño
            if (this.PC2.Controls.Count > 0)
            {
                this.PC2.Controls.RemoveAt(0);
            }
            Form h = RV as Form;
            h.TopLevel = false;
            h.Dock = DockStyle.Fill;
            this.PC2.Controls.Add(h);
            this.PC2.Tag = h;
            h.Show();
        }

        private void BRV_Click(object sender, EventArgs e)
        {
            //evento que ejecuta la instancia de abrir form
            AbrirformularioRV(new RV());
        }

        private void PC2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirformularioACD(object ACD)
        {
            if (this.PC2.Controls.Count > 0)
            {
                this.PC2.Controls.RemoveAt(0);
            }
            Form h = ACD as Form;
            h.TopLevel = false;
            h.Dock = DockStyle.Fill;
            this.PC2.Controls.Add(h);
            this.PC2.Tag = h;
            h.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirformularioACD(new ACD());
        }

     

        private void button1_Click(object sender, EventArgs e)
        {          
            if (MessageBox.Show("Usted quiere cerrar sesion?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Login Log = new Login();
                Log.Show();
                this.Close();
            }           
        }

        private void TB0_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Codigo para evitar que se cambie el texto de TB0

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
