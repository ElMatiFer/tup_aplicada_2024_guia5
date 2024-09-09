using aaaaa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace aaaaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBox2.Enabled = false;
            rbBanco.Checked = true;
            btCerrar.Enabled = false;
        }

        Presupuesto nuevo;

        private void btAgregar_Click(object sender, EventArgs e)
        {
            Producto p;
            if (rbBanco.Checked)
            {
                double precio = Convert.ToDouble(tbPrecio.Text);
                double largo = Convert.ToDouble(tbLargo.Text);
                int codigo = Convert.ToInt32(tbCodigo.Text);

                p = new Banco(precio, largo);
                p.Codigo = codigo;

                cbCodigos.Items.Add(codigo);
                nuevo.AgregarProducto(p);
            }
            else if (rbMesa.Checked)
            {
                double precio = Convert.ToDouble(tbPrecio.Text);
                double largo = Convert.ToDouble(tbLargo.Text);
                double ancho = Convert.ToDouble(tbAncho.Text);
                double grosor = Convert.ToDouble(tbGrosor.Text);
                int codigo = Convert.ToInt32(tbCodigo.Text);

                p = new Mesa(precio, largo, ancho, grosor);
                p.Codigo = codigo;

                cbCodigos.Items.Add(codigo);
                nuevo.AgregarProducto(p);
            }
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string direccion = tbDireccion.Text;

            nuevo = new Presupuesto(nombre, direccion);
            groupBox2.Enabled = true;

            btCerrar.Enabled = true;
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(cbCodigos.SelectedItem.ToString());

            if(nuevo.QuitarProducto(codigo))
            {
                cbCodigos.Text = "";
                cbCodigos.Items.Remove(codigo);
            }
            else
            {
                MessageBox.Show("No se encontro el producto", "Busqueda");
            }
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            fVer v = new fVer();
            string[] resumen = nuevo.Resumen();
            for (int i = 0; i < resumen.Length; i++)
            {
                v.lbResumen.Items.Add(resumen[i]);
            }
            v.ShowDialog();
        }

        private void rbBanco_CheckedChanged(object sender, EventArgs e)
        {
            tbGrosor.Enabled = false;
            tbAncho.Enabled = false;
        }

        private void rbMesa_CheckedChanged(object sender, EventArgs e)
        {
            tbGrosor.Enabled = true;
            tbAncho.Enabled = true;
        }
    }
}
