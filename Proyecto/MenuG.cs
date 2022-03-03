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

namespace Prototipo
{
   
    public partial class MenuG : Form  
    {
       
        public MenuG()
        {
            
            InitializeComponent();
            
        }

        private void B1_Click(object sender, EventArgs e)
        {
            //evento boton salida
            if (MessageBox.Show("Usted quiere salir de la aplicacion?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void PM_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PT_Paint(object sender, PaintEventArgs e)
        {

        }


        //Cod para mover ventana

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void PT_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PC_Paint(object sender, PaintEventArgs e)
        {

        }

        //cod que hace que un form entre dentro de un panel y tome sus caracteristicas de tamaño
        private void AbrirformularioRP(object RP)
        {
            if (this.PC.Controls.Count > 0)
            {
                this.PC.Controls.RemoveAt(0);
            }
            Form h = RP as Form;
            h.TopLevel = false;
            h.Dock = DockStyle.Fill;
            this.PC.Controls.Add(h);
            this.PC.Tag = h;
            h.Show();
        }

        //evento que ejecuta la instancia de abrir form
        private void button2_Click(object sender, EventArgs e)
        {
            AbrirformularioRP(new RP());
        }

        //cod que hace que un form entre dentro de un panel y tome sus caracteristicas de tamaño
        private void AbrirformularioRE(object RE)
        {
            if (this.PC.Controls.Count > 0)
            {
                this.PC.Controls.RemoveAt(0);
            }
            Form h = RE as Form;
            h.TopLevel = false;
            h.Dock = DockStyle.Fill;
            this.PC.Controls.Add(h);
            this.PC.Tag = h;
            h.Show();
        }

        //evento que ejecuta la instancia de abrir form
        private void button7_Click(object sender, EventArgs e)
        {
            AbrirformularioRE(new RE());
        }

        //cod que hace que un form entre dentro de un panel y tome sus caracteristicas de tamaño
        private void AbrirformularioMVD(object MVD)
        {
            if (this.PC.Controls.Count > 0)
            {
                this.PC.Controls.RemoveAt(0);
            }
            Form h = MVD as Form;
            h.TopLevel = false;
            h.Dock = DockStyle.Fill;
            this.PC.Controls.Add(h);
            this.PC.Tag = h;
            h.Show();
        }

        //evento que ejecuta la instancia de abrir form
        private void button8_Click(object sender, EventArgs e)
        {
            AbrirformularioMVD(new MVD());
        }

        //cod que hace que un form entre dentro de un panel y tome sus caracteristicas de tamaño

        private void AbrirformularioMVE(object MVE)
        {
            if (this.PC.Controls.Count > 0)
            {
                this.PC.Controls.RemoveAt(0);
            }
            Form h = MVE as Form;
            h.TopLevel = false;
            h.Dock = DockStyle.Fill;
            this.PC.Controls.Add(h);
            this.PC.Tag = h;
            h.Show();
        }

        //evento que ejecuta la instancia de abrir form
        private void button9_Click(object sender, EventArgs e)
        {
            AbrirformularioMVE(new MVE());
        }

        //cod que hace que un form entre dentro de un panel y tome sus caracteristicas de tamaño
        private void AbrirformularioMVC(object MVC)
        {
            if (this.PC.Controls.Count > 0)
            {
                this.PC.Controls.RemoveAt(0);
            }
            Form h = MVC as Form;
            h.TopLevel = false;
            h.Dock = DockStyle.Fill;
            this.PC.Controls.Add(h);
            this.PC.Tag = h;
            h.Show();
        }

        //evento que ejecuta la instancia de abrir form

        private void button10_Click(object sender, EventArgs e)
        {
            AbrirformularioMVC(new MVC());
        }

        private void PC_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void AbrirformularioACD(object ACD)
        {
            if (this.PC.Controls.Count > 0)
            {
                this.PC.Controls.RemoveAt(0);
            }
            Form h = ACD as Form;
            h.TopLevel = false;
            h.Dock = DockStyle.Fill;
            this.PC.Controls.Add(h);
            this.PC.Tag = h;
            h.Show();
        }

        private void button11_Click(object sender, EventArgs e)
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

       

        private void AbrirformularioPerfil(object Perfil)
        {
            if (this.PC.Controls.Count > 0)
            {
                this.PC.Controls.RemoveAt(0);
            }
            Form h = Perfil as Form;
            h.TopLevel = false;
            h.Dock = DockStyle.Fill;
            this.PC.Controls.Add(h);
            this.PC.Tag = h;
            h.Show();
        }

        private void BRV_Click(object sender, EventArgs e)
        {
            //evento que ejecuta la instancia de abrir form
            AbrirformularioRV(new RV());
        }

        private void AbrirformularioRV(object RV)
        {
            //cod que hace que un form entre dentro de un panel y tome sus caracteristicas de tamaño
            if (this.PC.Controls.Count > 0)
            {
                this.PC.Controls.RemoveAt(0);
            }
            Form h = RV as Form;
            h.TopLevel = false;
            h.Dock = DockStyle.Fill;
            this.PC.Controls.Add(h);
            this.PC.Tag = h;
            h.Show();
        }
    }
}
