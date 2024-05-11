using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ProyectoAlgebra
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numerosAleatorios = new int[4];

            
            for (int i = 0; i < 4; i++)
            {
                numerosAleatorios[i] = random.Next(10) + 1;
            }

            string textoGuardado = textBox1.Text;
            textBox1.Select(4, 2);           
            string textoSeleccionado = textBox1.SelectedText;
            string carnetnuevo = "2024"+ textoSeleccionado + numerosAleatorios[0] + numerosAleatorios[1] + numerosAleatorios[2];
         
            labelcarnet.Text = carnetnuevo;


          
            

            
        }
    }
}
