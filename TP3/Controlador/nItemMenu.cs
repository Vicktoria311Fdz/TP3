using Libreria2023;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Entidades;

namespace TP3.Controlador
{
    internal class nItemMenu
    {
        public static void Crear()
        {
            Console.Write("Ingrese Nombre de la comida: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese una descripcion: ");
            string descripcion = Console.ReadLine();
            Console.Write("Ingrese el precio: ");
            decimal precio = decimal.Parse(Console.ReadLine());


        }
        public static void Imprimir()
        {
            foreach (ItemMenu item in Program.itemsMenus)
            {
                Console.WriteLine($"{item.Nombre},{item.Descripcion},{item.Precio}", Program.itemsMenus.IndexOf(item) + 1);
            }
        }
        public static int Selecionar()
        {
            Console.WriteLine();
            Imprimir();
            Console.Write("Seleccione una comida: ");
            int s = Herramientas.IngresoEnteros(1, Program.itemsMenus.Count);
            return s - 1;

        }
        public static void Eliminar()
        {
            int i = Selecionar();
            Program.itemsMenus.RemoveAt(i);
        }
        public static void Modificar(int i)
        {
            Console.WriteLine();
            Console.Write($"Ingrese nueva descripcion para: {Program.itemsMenus[i].Nombre}");
            Program.itemsMenus[i].Descripcion = Console.ReadLine();
            Console.WriteLine();
            Console.Write($"Ingrese nuevo precio para: {Program.itemsMenus[i].Nombre}");
            Program.itemsMenus[i].Precio = decimal.Parse( Console.ReadLine());
        }
        public static void Menu()
        {
            string[] op = new string[] { "Crear", "Modificar datos", "ELiminar", "Listar", "Volver" };
            Console.Clear();
            Herramientas.DibujoMenu("Menu", op);
            //--//
            Console.Write("Seleccione una opcion: ");
            int seleccion = Herramientas.IngresoEnteros(1, 5);
            Console.WriteLine();
            switch (seleccion)
            {
                case 1: Crear(); Menu(); break;
                case 2: Modificar(Selecionar()); Menu(); break;
                case 3:
                    if (Program.itemsMenus.Count > 0)
                    {
                        Eliminar();
                    }
                    else
                    {
                        Console.WriteLine("No existen datos"); Console.ReadKey(true);
                    }
                    Menu(); break;
                case 4: Imprimir(); break;
                case 5: break;

            }
        }
    }
}
