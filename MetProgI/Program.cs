﻿using System;
using MetProgI.Folder_Coleccionables;
using MetProgI.Folder_Comparables;
using MetProgI.Generador_Random;
using MetProgI.Patron_Iterator;
using MetProgI.Patron_Strategy;

namespace MetProgI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            while (salir.Equals(false))
            {
                Console.WriteLine("---------- Elija la opcion que desea ejecutar ---------");
                Console.WriteLine("1) Comparar Nombre");
                Console.WriteLine("2) Comparar DNI");
                Console.WriteLine("3) Comparar Legajo");
                Console.WriteLine("4) Comparar Promedio");
                Console.WriteLine("5) Informar Personas(E2P2)");
                Console.WriteLine("6) Prueba Patron Iterador(E7P2)");
                Console.WriteLine("7) Imprimir Elementos(E8P2)");
                Console.WriteLine("8) Informar Maximos y Minimos(E10P2)");
                Console.WriteLine("9) Test de la Clase GeneradorDeDatosAleatorios");
                Console.WriteLine("10) Llenar, informar y comparar Comparables (E6P3)");
                Console.WriteLine("11) Llenar, informar y comparar Vendedores (E9P3)");
                Console.WriteLine("12) Patron Observer (E14P3)");
                Console.WriteLine("13) Patron Adapter (E4P4 y E8P4)");
                Console.WriteLine("14) Patron Decorator (E7P4)");
                Console.WriteLine("0) Salir");
                Console.WriteLine();
                Console.Write("Ingrese su opcion: ");
                int eleccion = Convert.ToInt32(Console.ReadLine());

                switch (eleccion)
                {
                    case 1:
                        Patron_Strategy.Main.Run(eleccion);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Patron_Strategy.Main.Run(eleccion);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Patron_Strategy.Main.Run(eleccion);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        Patron_Strategy.Main.Run(eleccion);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Impresiones.Main.Run();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Patron_Iterator.Main.Run();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 7:
                        Impresiones.Main.Run2();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 8:
                        Impresiones.Main.Run3();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 9:
                        Console.Write("\nElija la cantidad de caracteres que desea tener el nombre (mayor a 10): ");
                        int opcion = new LectorDeDatos().numeroPorTeclado();
                        Console.WriteLine("Nombre: " + new GeneradorDeDatosAleatorios().stringAleatorio(opcion));
                        Console.Write("\n\nElija un numero maximo del cual obtener un numero aleatorio: ");
                        opcion = new LectorDeDatos().numeroPorTeclado();
                        Console.WriteLine("Numero: " + new GeneradorDeDatosAleatorios().numeroAleatorio(opcion));
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 10:
                        Impresiones.Main.Run4();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 11:
                        Impresiones.Main.Run5();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 12:
                        Patron_Observer.Main.Run();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 13:
                        Patron_Adapter.Main.Run();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 14:
                        Patron_Decorator.Main.Run();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 0:
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Por favor, elija una opcion correcta.");
                        Console.ReadKey();
                        break;
                }
            }

        
    }
    }
}
