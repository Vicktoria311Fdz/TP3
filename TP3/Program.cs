using Libreria2023;
using TP3.Controlador;
using TP3.Entidades;

namespace TP3
{
    internal class Program
    {
        public static List<Cliente> clientes;
        public static List<ItemMenu> itemsMenus;
        public static List<EstadoPedido> estados;
        public static List<Pedido> pedidos;
        static void Main(string[] args)
        {
            clientes = new List<Cliente>();
            itemsMenus = new List<ItemMenu>();
            estados = new List<EstadoPedido>();
            pedidos = new List<Pedido>();

            DatosIniciales();
        }
        public static void DatosIniciales() 
        {
            //Agregar Clientes
            clientes.Add(new Cliente { Id = 1,Nombre="Maria", Apellido = "Gomez",Direccion ="Calle 2 Mzna 1", Telefono = 123456789 });
            clientes.Add(new Cliente { Id = 1, Nombre = "Jose", Apellido = "Lopez", Direccion = "Calle 4 Mzna 3", Telefono = 31247 });

            //Agregar elemmentos al Menu
            itemsMenus.Add(new ItemMenu { Nombre = "Pizza", Descripcion = "De muzzarella", Precio = 1560.0m });
            itemsMenus.Add(new ItemMenu { Nombre = "Hamburguesa", Descripcion = "Completa", Precio = 1500m });

            //Agregar algunos pedidos
            Pedido pedido1 = new Pedido
            {
                Fecha = DateTime.Now.AddDays(-2),
                Cliente = clientes[0],
                Estado = EstadoPedido.Ingresado
            };
            pedido1.Items.Add(itemsMenus[0]);
            pedido1.Items.Add(itemsMenus[1]);


        }

        public static void Menu() 
        {
            Console.Clear();
            string[] op = new string[] { "Clientes", "Menu", "Pedidos","Salir" };
            Herramientas.DibujoMenu("Delivery", op);

            Console.Write("Seleccione una opcion: ");
            int seleccionar = Herramientas.IngresoEnteros(1, 5);
            switch(seleccionar) 
            {
                case 1: nCliente.Menu(); Menu(); break;
                case 2: nItemMenu.Menu(); Menu(); break;
                //case 3: nPedidos.Menu(); Menu(); break;
                case 4: break;
            }

        }
    }
}