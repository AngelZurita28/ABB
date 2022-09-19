using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _EDD_Tarea3
{
    public partial class Form1 : Form
    {
        ABB arbol;

        public Form1()
        {
            InitializeComponent();
            arbol = new ABB();
        } 

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbInsertar.Text) == false)
            {
                arbol.Insertar(tbInsertar.Text);

                tbInorden.Text = arbol.Inorden();
                tbPreorden.Text = arbol.Preorden();
                tbPostorden.Text = arbol.Postorden();

                string ruta = arbol.Graficar();

                System.Threading.Thread.Sleep(1000);

                FileStream file = new FileStream(ruta, FileMode.Open);
                Image img = Image.FromStream(file);
                pictureBox1.Image = img;
                file.Close();
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            arbol.limpiar();

            tbInorden.Text = arbol.Inorden();
            tbPreorden.Text = arbol.Preorden();
            tbPostorden.Text = arbol.Postorden();

            string ruta = arbol.Graficar();

            System.Threading.Thread.Sleep(1000);

            FileStream file = new FileStream(ruta, FileMode.Open);
            Image img = Image.FromStream(file);
            pictureBox1.Image = img;
            file.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbInsertar.Text) == false)
            {
                arbol.Eliminar(tbInsertar.Text);

                tbInorden.Text = arbol.Inorden();
                tbPreorden.Text = arbol.Preorden();
                tbPostorden.Text = arbol.Postorden();

                string ruta = arbol.Graficar();

                System.Threading.Thread.Sleep(1000);

                FileStream file = new FileStream(ruta, FileMode.Open);
                Image img = Image.FromStream(file);
                pictureBox1.Image = img;
                file.Close();
            }
        }
    }
}
