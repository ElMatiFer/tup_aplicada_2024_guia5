using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaaaa.Models
{
    internal class Presupuesto
    {
        ArrayList listaProductos = new ArrayList();
        Cliente solicitante;
        public double Precio
        {
            get
            {
                double acum = 0;
                foreach (Producto a in listaProductos)
                {
                    acum += a.Precio();
                }
                return acum;
            }
        }

        public Presupuesto(string nombre, string direccion)
        {
            solicitante = new Cliente(nombre,direccion);
        }
        public Producto Busqueda(int codigo)
        {
            int med=0, izq = 0, der = listaProductos.Count -1;
            bool encontrado = false;

            while (izq <= der && !encontrado)
            {
                med = (izq + der) / 2;
                
                if (((Producto)listaProductos[med]).Codigo == codigo)
                {
                    encontrado = true;
                    med = codigo;
                }
                else if (((Producto)listaProductos[med]).Codigo < codigo)
                {
                    med = der - 1;
                }
                else
                {
                    med = izq + 1;
                }
            }
            return ((Producto)listaProductos[med]);

        }
        public void AgregarProducto(Producto unProducto)
        {
            if (unProducto != null)
            {
                listaProductos.Add(unProducto);
            }
        }
    }
}
