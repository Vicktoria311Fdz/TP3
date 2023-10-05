using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria2023;
using TP3.Entidades;

namespace TP3.Controlador
{
    internal class nCliente
    {
        public static Cliente Crear()
        {
            Console.Write("Ingrese un Id para el cliente: ");
            int id = Herramientas.IngresoEnteros();
            Console.Write("Ingrese el Nombre del cliente: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el apellido del cliente: ");
            string apellido = Console.ReadLine();
            Console.Write("Ingrese la direccion del cliente: ");
            string direccion = Console.ReadLine();
            Console.Write("Ingrese el celular: ");
            int telefono;
            while (!int.TryParse(Console.ReadLine(), out telefono))
            {
                Console.WriteLine("Ingrese un número válido para el celular.");
                Console.Write("Ingrese el celular: ");
            }
            return new Cliente(id, nombre, apellido, direccion, telefono);
        }
        public static void Imprimir()
        {
            foreach(Cliente cliente in Program.clientes) 
            {
                Console.WriteLine($"{cliente.Id},{cliente.Nombre},{cliente.Apellido},{cliente.Direccion},{cliente.Telefono}", Program.clientes.IndexOf(cliente) + 1);
            }
        }
        public static int Selecionar() 
        {
            Console.WriteLine();
            Imprimir();
            Console.Write("Seleccione un cliente: ");
            int s = Herramientas.IngresoEnteros(1, Program.clientes.Count);
            return s-1;

        }
        public static void Eliminar() 
        {
            int i = Selecionar();
            Program.clientes.RemoveAt(i);
        }
        public static void Modificar(int i) 
        {
            Console.WriteLine();
            Console.Write($"Ingrese nuevo celular para: {Program.clientes[i].Nombre}");
            Program.clientes[i].Telefono = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write($"Ingrese nueva direccion para: {Program.clientes[i].Nombre}");
            Program.clientes[i].Direccion = Console.ReadLine();
        }
        public static void Menu() 
        {
            string[] op = new string[] { "Crear", "Modificar datos", "ELiminar", "Listar","Volver" };
            Console.Clear();
            Herramientas.DibujoMenu("Clientes", op);
            //--//
            Console.Write("Seleccione una opcion: ");
            int seleccion = Herramientas.IngresoEnteros(1, 5);
            Console.WriteLine();
            switch( seleccion ) 
            {
                case 1: Crear();Menu() ; break;
                case 2: Modificar(Selecionar()); Menu() ; break;
                case 3:
                    if (Program.clientes.Count > 0) {
                        Eliminar(); }
                    else 
                    {
                        Console.WriteLine("No existen datos"); Console.ReadKey(true);
                    }Menu() ; break;
               case 4: Imprimir();break; 
               case 5:break;

            }
        }
        
    }
}
