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

namespace aaaaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            Producto selec;
            if (rbBanco.Checked)
            {
                double precio = Convert.ToDouble(tbPrecio.Text);
                double largo = Convert.ToDouble(tbLargo.Text);
                int codigo = Convert.ToInt32(tbCodigo.Text);
                selec = new Banco(precio, largo);
                selec.Codigo = codigo;
                
            }
            else if (rbBanco.Checked)
            {
                double precio = Convert.ToDouble(tbPrecio.Text);
                double largo = Convert.ToDouble(tbLargo.Text);
                double ancho = Convert.ToDouble(tbAncho.Text);
                double grosor = Convert.ToDouble(tbGrosor.Text);

                int codigo = Convert.ToInt32(tbCodigo.Text);
                selec = new Mesa(precio, largo, ancho, grosor);
                selec.Codigo = codigo;
            }
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string direccion = tbDireccion.Text;
            Presupuesto nuevo = new Presupuesto(nombre, direccion);
        }
    }
}
