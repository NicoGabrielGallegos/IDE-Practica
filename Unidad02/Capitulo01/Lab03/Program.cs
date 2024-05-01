namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantIteraciones = 5;
            string?[] strings = new string?[cantIteraciones];
            Console.WriteLine("Ingrese " + cantIteraciones + " strings");
            for (int i = 0; i < cantIteraciones; i++)
            {
                Console.Write(i + ": ");
                strings[i] = Console.ReadLine();
            }
            Console.WriteLine();
            for (int i = cantIteraciones - 1; i >= 0; i--)
            {
                Console.WriteLine(i + ": " + strings[i]);
            }
        }
    }
}