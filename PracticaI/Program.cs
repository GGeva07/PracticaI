
using System;

namespace PracticaI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool parar = true;

            while (parar)
            {
                Console.WriteLine("Calculadora menu: " +
                "\n1. Sumar" +
                "\n2. Restar" +
                "\n3. Multiplicar" +
                "\n4. Dividir" +
                "\n5. Salir");
                string opcion = Console.ReadLine();
                int numeros = 0, num1 = 0, num2 = 0, num = 0;
                

                switch (opcion)
                {
                    case "1":
                        LimpiarConssola();
                        Console.WriteLine("Ingrese los numeros que va a sumar e ingrese 0 para parar la suma");
                        do
                        {
                            numeros = Convert.ToInt32(Console.ReadLine());
                            num += numeros;
                        } while (numeros != 0);
                        Console.WriteLine($"La suma es: {num}");
                        break;

                    case "2":
                        LimpiarConssola();
                        Console.WriteLine("Ingrese 2 numeros para restarlos");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"La resta es {num1 - num2}");
                        break;

                    case "3":
                        LimpiarConssola();
                        Console.WriteLine("Ingrese 2 numeros para multiplicarlos");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"La multiplicacion es {num1 * num2}");
                        break;

                    case "4":
                        LimpiarConssola();
                        Console.WriteLine("Ingrese 2 numeros para dividirlos");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"La division es {num1 / num2}");
                        break;

                    case "5":
                        parar = false;
                        break;

                    default:
                        Console.WriteLine("Ingrese una opcion valida por favor");
                        break;
                }
            }
        }

        public static void LimpiarConssola()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}
