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
        private Producto Busqueda(int codigo)
        {
            Producto buscar = new Banco(0, 0);
            buscar.Codigo = codigo;
            listaProductos.Sort();
            int orden = listaProductos.BinarySearch(buscar);
            if (orden >= 0)
            {
                return listaProductos[orden] as Producto;
            }
            else
            {
                return null;
            }

        }
        public void AgregarProducto(Producto unProducto)
        {
            if (unProducto != null)
            {
                listaProductos.Add(unProducto);
            }
        }
        public bool QuitarProducto(int codigo)
        {
            Producto b = Busqueda(codigo);
            if (b != null)
            {
                listaProductos.Remove(b);
                return true;
            }
            return false;
        }
        public string[] Resumen()
        {
            Producto p;
            string[] r = new string[listaProductos.Count];
            for (int i = 0; i< r.Length;i++)
            {
                p = (Producto)listaProductos[i];
                r[i] = p.Codigo + ";" + p.Precio();
            }
            return r;
        }
    }
}
