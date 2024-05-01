namespace Lab01
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

                if (opcion.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("\nMayúsculas: " + inputTexto.ToUpper());
                }
                else if (opcion.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("\nMinúsculas: " + inputTexto.ToLower());
                }
                else if (opcion.Key == ConsoleKey.D3)
                {
                    Console.WriteLine("\nCantidad de caracteres: " + inputTexto.Length);
                }
                else
                {
                    Console.WriteLine("\nNo se ha ingresado una opción válida");
                }

            } 
            else
            {
                Console.WriteLine("\nNo se ha ingresado texto");
            }
        }
    }
}
