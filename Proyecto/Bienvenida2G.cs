using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo
{
    public partial class Bienvenida2G : Form
    {
        public Bienvenida2G()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //inicia contador1
            this.Opacity = 0.0;
            timer1.Start();
            
        }

        int cont = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            //crea efecto de opacidad a iniciar

            if (this.Opacity < 1) this.Opacity += 0.05;
            cont += 1;
            if (cont == 110)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //Luego que el temporizador termine se comenzara a opacar el form hasta esconderlo y mostrar el siguiente form
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                

                MenuG abrir = new MenuG();
                abrir.Show();
                abrir.TB0.Text = TB0.Text;
                timer2.Stop();
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
