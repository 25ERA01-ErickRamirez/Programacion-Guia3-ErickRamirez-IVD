using System;

namespace InventarioTienda
{
    internal class Program
    {
        static string[,] productos = new string[10, 3];

        static void Main(string[] args)

        {
            int opcion;

            do
            {
                Console.Clear();

                Console.WriteLine("===== MENU PRINCIPAL =====");
                Console.WriteLine("1- Registrar producto");
                Console.WriteLine("2- Mostrar productos");
                Console.WriteLine("3- Actualizar producto");
                Console.WriteLine("4- Eliminar producto");
                Console.WriteLine("5- Salir");
                Console.Write("Digite una opción: ");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("=== Registrar Productos ===");
                        RegistrarProducto();
                        Pausa();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("=== Mostrar Productos ===");
                        MostrarProductos();
                        Pausa();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("=== ACTUALIZAR PRODUCTO ===");
                        ActualizarProducto();
                        Pausa();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("=== ELIMINAR PRODUCTO ===");
                        EliminarProducto();
                        Pausa();
                        break;

                    case 5:
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        Pausa();
                        break;
                }

            } while (opcion != 5);
        }

        //Registrar
        static void RegistrarProducto()
        {
            bool registrado = false;
            for (int i = 0; i < 10; i++)
            {
                if (string.IsNullOrEmpty(productos[i, 0]))
                {
                    Console.Write("Código del producto: ");
                    productos[i, 0] = Console.ReadLine();

                    Console.Write("Nombre del producto: ");
                    productos[i, 1] = Console.ReadLine();

                    Console.Write("Cantidad en existencia: ");
                    productos[i, 2] = Console.ReadLine();

                    Console.WriteLine("\nProductos Registrados con Éxito!!!");
                    registrado = true;
                    break;
                }
            }
            if (!registrado)
            {
                Console.WriteLine("\nLa matriz está llena.");
            }
        }
        //Mostrar
        static void MostrarProductos()
        {
            Console.WriteLine("\nCODIGO\tNOMBRE\t\tCANTIDAD");
            Console.WriteLine("------------------------------------------");

            for (int i = 0; i < 10; i++)
            {
                if (!string.IsNullOrEmpty(productos[i, 0]))
                {
                    Console.WriteLine(
                        productos[i, 0] + "\t" +
                        productos[i, 1] + "\t\t" +
                        productos[i, 2]);
                }
            }
        }

        //Actualizar
        static void ActualizarProducto()
        {
            bool encontrado = false;

            Console.Write("Código a buscar: ");
            string codigo = Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                if (productos[i, 0] == codigo)
                {
                    Console.Write("Nuevo nombre: ");
                    productos[i, 1] = Console.ReadLine();

                    Console.Write("Nueva cantidad: ");
                    productos[i, 2] = Console.ReadLine();

                    Console.WriteLine("\nProducto actualizado.");

                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("\nCódigo no encontrado.");
            }
        }

        //Eliminar
        static void EliminarProducto()
        {
            bool encontrado = false;

            Console.Write("Código a eliminar: ");
            string codigo = Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                if (productos[i, 0] == codigo)
                {
                    productos[i, 0] = "";
                    productos[i, 1] = "";
                    productos[i, 2] = "";

                    Console.WriteLine("\nProducto eliminado.");

                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("\nCódigo no encontrado.");
            }
        }

        //Pausa
        static void Pausa()
        {
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
