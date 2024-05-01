namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Ingrese un texto\n");
            string? inputTexto = Console.ReadLine();
            if (inputTexto != null)
            {
                Console.WriteLine("Opciones:\n1 - Mostrar texto en mayúsculas\n2 - Mostrar texto en minúsculas\n3 - Mostrar cantidad de caracteres del texto\n");
                ConsoleKeyInfo opcion = Console.ReadKey();

                switch (opcion.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("\nMayúsculas: " + inputTexto.ToUpper());
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("\nMinúsculas: " + inputTexto.ToLower());
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("\nCantidad de caracteres: " + inputTexto.Length);
                        break;
                    default:
                        Console.WriteLine("\nNo se ha ingresado una opción válida");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nNo se ha ingresado texto");
            }

        }
    }
}
