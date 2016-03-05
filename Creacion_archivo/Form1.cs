using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Creacion_archivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        archivo1 creacion = new archivo1();
        String mensaje_de_verificacion = "";
        TextWriter archivo;
        String ruta, rutalee;  

        private void button1_Click(object sender, EventArgs e)
        {
            creacion.crearArchivo(textBox1, richTextBox1, ref mensaje_de_verificacion);
            MessageBox.Show(mensaje_de_verificacion);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            creacion.leerArchivo(textBox2, richTextBox2, ref mensaje_de_verificacion);
            MessageBox.Show(mensaje_de_verificacion);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            creacion.cargadeDos(richTextBox3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido :3 ");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            creacion.editar(richTextBox2, ref mensaje_de_verificacion);
            MessageBox.Show(mensaje_de_verificacion);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            creacion.crearDosen_UNO(textBox3, richTextBox3, ref mensaje_de_verificacion);
            MessageBox.Show(mensaje_de_verificacion);
        }
    }
}
