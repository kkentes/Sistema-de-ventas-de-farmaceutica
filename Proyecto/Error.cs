﻿using System;
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
    public partial class Error : Form
    {
        public Error()
        {
            InitializeComponent();
        }
        int cont = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //si el contador llega a 100 abre form Login y cierra este form
            cont += 1;
            if (cont == 100)
            {
              
               Login abrir = new Login();
               abrir.Show();
               this.Close();
                
            }
        }

        private void Error_Load(object sender, EventArgs e)
        {
            //inicia contador1
            timer1.Start();
        }
    }
}
