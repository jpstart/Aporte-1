using System;

namespace Cine
{
    class Menu
    {
        static void Main(string[] args)
        {
            Console.WriteLine("///////////////////Bienvenido Al Cine Uleam\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ \n" +
                "Por favor eliga un numero acorde a la pelicula que le gustaria ver, gracias\n" +
                "\n1.-John Wick 3\n" +
                "\n2.-Aladdin\n" +
                "\n3.-Avengers\n" +
                "\n4.-Pikachu\n" +
                "\n5.- Otra\n" +
                "\n6.- Salir\n");

            String s1 = null;
                s1 = Console.ReadLine();
            switch (s1)
            {
                case "1":
                    Console.WriteLine("Ha elegido Jhoh Wick ");

                    break;
                case "2":
                    Console.WriteLine("Ha elegido Aladdin");
                    break;

                case "3":
                    Console.WriteLine("Ha elegido Avengers");
                    break;

                case "4":
                    Console.WriteLine("Ha elegido Pikachu");
                    break;

                case "5":
                    Console.WriteLine("Ha elegido Otra");
                    break;

                case "6":
                    Console.WriteLine("Gracias, regrese pronto");
                    break;
                default:
                    Console.WriteLine("No se ha seleccionado ninguna opción");
                    break;
            }
            Console.ReadKey();
        }
    }
}
