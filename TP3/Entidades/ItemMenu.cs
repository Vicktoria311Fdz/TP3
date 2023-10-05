using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.Entidades
{
    internal class ItemMenu
    {   
        public string Nombre { get; set; }
        public string Descripcion { get; set; }   
        public decimal Precio { get; set; } 

        public ItemMenu() { }

        public ItemMenu(string nombre, string descripcion, decimal precio)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
        }
    }
}
