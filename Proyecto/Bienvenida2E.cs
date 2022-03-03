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
    public partial class Bienvenida2E : Form
    {
        public Bienvenida2E()
        {


            InitializeComponent();
        }

        private void Bienvenida2E_Load(object sender, EventArgs e)
        {
            //inicia contador1
            this.Opacity = 0.0;
            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //crea efecto de opacidad a iniciar
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {

                MenuE abrir = new MenuE();
                abrir.Show();
                abrir.TB0.Text = TB0.Text;               
                timer2.Stop();
                this.Close();
            }
        }
        int cont = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //Luego que el temporizador termine se comenzara a opacar el form hasta esconderlo y mostrar el siguiente form
            if (this.Opacity < 1) this.Opacity += 0.05;
            cont += 1;
            if (cont == 110)
            {
                
                timer1.Stop();
                timer2.Start();
            }
        }
    }
}
