using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace Creacion_archivo
{
    public class archivo1
    {

        TextWriter archivo;
        String ruta, rutalee;


        public void crearArchivo(TextBox nombreArchivo, RichTextBox texto_del_Archivo, ref String mensaje_ventana)
        {
            if (nombreArchivo.Text != "")
            {
                FolderBrowserDialog fod = new FolderBrowserDialog();
                fod.Description = "Seleccione la ruta para guardar tu archivo ";
                fod.RootFolder = Environment.SpecialFolder.Desktop;
                if (fod.ShowDialog() == DialogResult.OK)
                {
                    ruta = fod.SelectedPath;
                    String mensaje;
                    mensaje = texto_del_Archivo.Text;
                    archivo = new StreamWriter(ruta + "\\" + nombreArchivo.Text + ".txt");
                    archivo.Write(mensaje);
                    archivo.Close();
                    mensaje_ventana = "Correcto";
                }
            }
            else mensaje_ventana = "No has escrito el nombre del archivo, porfavor escribe algo";
        }

        public void leerArchivo(TextBox textBox2, RichTextBox richTextBox2, ref String mensaje)
        {
            richTextBox2.Text = "";
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = " Archivos txt(*.txt)|*.txt";
            open.Title = "Archivos .txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                rutalee = open.FileName;
                textBox2.Text = rutalee;
                StreamReader file = new StreamReader(rutalee);
                while (file.Peek() != -1)
                {
                    richTextBox2.Text += file.ReadLine() + "\n";
                }
                file.Close();
                mensaje = "Archivo cargado correctamente";
            }
            open.Dispose();
        }


        public void editar(RichTextBox richTextBox2, ref String ventana_mensaje)
        {
            //textBox2.Text = rutalee;

            String texto_delArchivo;
            texto_delArchivo = richTextBox2.Text;
            archivo = new StreamWriter(rutalee);
            archivo.Write(texto_delArchivo);
            archivo.Close();
            ventana_mensaje = "Edicion correcta";
        }

        public void cargadeDos(RichTextBox richTextBox3)
        {
            richTextBox3.Text = "";
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = " Archivos txt(*.txt)|*.txt";
            open.Title = "Archivos .txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                rutalee = open.FileName;
                //   textBox2.Text = rutalee;
                StreamReader file = new StreamReader(rutalee);
                while (file.Peek() != -1)
                {
                    richTextBox3.Text += file.ReadLine() + "\n";
                }
                file.Close();
            }
            open.Dispose();

            if (open.ShowDialog() == DialogResult.OK)
            {
                rutalee = open.FileName;
                //   textBox2.Text = rutalee;
                StreamReader file = new StreamReader(rutalee);
                while (file.Peek() != -1)
                {
                    richTextBox3.Text += file.ReadLine() + "\n";
                }
                file.Close();
            }
            open.Dispose();

        }

        public void crearDosen_UNO(TextBox textBox3, RichTextBox richTextBox3, ref String ventana_mensaje)
        {
            if (textBox3.Text != "" && richTextBox3.Text != "")
            {
                FolderBrowserDialog fod = new FolderBrowserDialog();
                fod.Description = "Seleccione la ruta donde desea guardar el documento";
                fod.RootFolder = Environment.SpecialFolder.Desktop;
                if (fod.ShowDialog() == DialogResult.OK)
                {
                    ruta = fod.SelectedPath;
                    String mensaje;
                    mensaje = richTextBox3.Text;
                    archivo = new StreamWriter(ruta + "\\" + textBox3.Text + ".txt");
                    archivo.Write(mensaje);
                    archivo.Close();
                    ventana_mensaje = "Correcto";
                }
            }
            else ventana_mensaje = "No has escrito el nombre del archivo, escribe algo ";
        }
    }
}
