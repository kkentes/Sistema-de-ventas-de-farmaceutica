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

    //Integrantes:

//            - Kevin Rene Fuentes Molina.              FM140272
//            - Kevin Eduardo Castro Aragón.            CA192462
//            - Emerson Omar Portillo Rivas.            PR160956
//            - Francisco Ernesto Bayona Burgos.        BB202225


    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
            
        }

       

        private void Form3_Load(object sender, EventArgs e)
        {
            //comiensa el timer1
            timer1.Start();
        }
        int cont = 0;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //contador si llega a 100 abre el form Login y ocular Bienvenida
            cont += 1;
            if (cont == 130)
            {
                timer1.Stop();
                Login abrir = new Login();               
                abrir.Show();
                this.Hide();
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
