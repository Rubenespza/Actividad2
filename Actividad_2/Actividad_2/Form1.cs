using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_2
{
    public partial class Form1 : Form
    {
        int i = 0;
        int tam = 0;
        Alumnos[] arreglo;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tam = int.Parse(txtAgregar.Text);
            arreglo = new Alumnos[tam];
            txtAgregar.Clear();
            groupBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i < tam)
            {
                arreglo[i].Nombre = txtNombre.Text;
                arreglo[i].Id = txtId.Text;
                txtNombre.Clear();
                txtId.Clear();
                txtNombre.Focus();
                i++;
            }
            else
            {
                for (int x = 0; x < tam; x++)
                {
                    listBox1.Items.Add(arreglo[i]);
                }
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            txtAgregar.Clear();
            txtNombre.Clear();
            txtId.Clear();
            txtAgregar.Focus();
            listBox1.Items.Clear();
            i = 0;
            tam = 0;
        }
    }
}
