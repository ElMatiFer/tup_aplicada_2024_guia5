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
            int idx = listaProductos.BinarySearch(buscar);
            if (idx >= 0)
            {
                return listaProductos[idx] as Producto;
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
            Producto p = Busqueda(codigo);
            if (p != null)
            {
                listaProductos.Remove(p);
                return true;
            }
            else
            {
                return false;
            }
 
        }
        public string[] Resumen()
        {
            Producto p;

            string[] resumen = new string[listaProductos.Count+1];

            for (int i = 0; i< resumen.Length-1; i++)
            {
                p = (Producto)listaProductos[i];
                resumen[i] = $"Codigo: {p.Codigo} | Precio: {p.Precio()}";
            }

            resumen[listaProductos.Count] = $"Total: {Precio}";

            return resumen;
        }
    }
}
