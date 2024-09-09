using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaaaa.Models
{
    public abstract class Producto : IComparable
    {
        protected double precioBase;
        protected double largo;
        private int codigo;

        public int Codigo 
        {
            get 
            {
                return codigo;
            }
            set 
            {
                codigo = value;
            }
        }
        public Producto(double precio, double largo)
        {
            precioBase = precio;
            this.largo = largo;
        }
        abstract public double Peso();
        abstract public double Precio();

        public int CompareTo(object obj)
        {
            if (obj != null && obj is Producto)
            {
                return Codigo.CompareTo(((Producto)obj).Codigo);
            }
            return 1;
        }

    }
}
