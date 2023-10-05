using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.Entidades
{
    internal class Pedido
    {
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemMenu> Items { get; set; }
        public EstadoPedido Estado { get; set; }

        public Pedido()
        {
            Items = new List<ItemMenu>();
        }

        public Pedido(DateTime fecha, Cliente cliente, List<ItemMenu> items, EstadoPedido estado)
        {
            Fecha = fecha;
            Cliente = cliente;
            Items = items;
            Estado = estado;
        }
    }
}

