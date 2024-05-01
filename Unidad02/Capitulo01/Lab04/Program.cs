namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            Ej9();
        }

        static void Ej1()
        {
            int numero_uno, numero_dos;
            Console.Write("Ingrese dos números\n1: ");
            numero_uno = Convert.ToInt32(Console.ReadLine());
            Console.Write("2: ");
            numero_dos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El restultado de la suma de " + numero_uno + " y " + numero_dos + " es " + (numero_uno + numero_dos));
        }

        static void Ej2()
        {
            int año;
            Console.WriteLine("Ingrese un año: ");
            año = Convert.ToInt32(Console.ReadLine());
            if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
            {
                Console.WriteLine("El año " + año + " es bisiesto");
            }
            else
            {
                Console.WriteLine("El año " + año + " no es bisiesto");
            }
        }

        static void Ej3()
        {
            Console.WriteLine("- Serie de Fibonacci -");
            Console.Write("Ingrese la cantidad de números que quiere generar: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                int c = a;
                a = b;
                b = b + c;
                Console.WriteLine("F(" + i + ") = " + c);
            }
        }

        static void Ej4()
        {
            Console.WriteLine("- Numeros pares entre 1 y 100 -");
            for (int i = 2; i < 100; i += 2)
            {
                Console.Write(i + " ");
            }
        }

        static void Ej5()
        {
            Console.WriteLine("Ingrese el nombre de un mes");
            string? mes = Console.ReadLine();
            if (mes != null) switch (mes.ToLower())
                {
                    case "enero":
                        Console.WriteLine("Enero + 1");
                        break;
                    case "febrero":
                        Console.WriteLine("Febrero + 2");
                        break;
                    case "marzo":
                        Console.WriteLine("Marzo + 3");
                        break;
                    case "abril":
                        Console.WriteLine("Abril + 4");
                        break;
                    case "mayo":
                        Console.WriteLine("Mayo + 5");
                        break;
                    case "junio":
                        Console.WriteLine("Junio + 6");
                        break;
                    case "julio":
                        Console.WriteLine("Julio + 7");
                        break;
                    case "agosto":
                        Console.WriteLine("Agosto + 8");
                        break;
                    case "septiembre":
                        Console.WriteLine("Septiembre + 9");
                        break;
                    case "octubre":
                        Console.WriteLine("Octubre + 10");
                        break;
                    case "noviembre":
                        Console.WriteLine("Noviembre + 11");
                        break;
                    case "diciembre":
                        Console.WriteLine("Diciembre + 12");
                        break;
                    default:
                        Console.WriteLine("Mes invalido");
                        break;
                }
        }

        static void Ej6()
        {
            Console.WriteLine("Ingrese un numero entero:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0 && num < 4000)
            {
                Console.WriteLine(num.ToString("0000"));
                string[] unidades = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
                string[] decenas = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
                string[] centenas = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
                string[] unidades_de_mil = { "", "M", "MM", "MMM" };
                string string_num = num.ToString("0000");
                int m = Convert.ToInt32(string_num[0].ToString());
                int c = Convert.ToInt32(string_num[1].ToString());
                int d = Convert.ToInt32(string_num[2].ToString());
                int u = Convert.ToInt32(string_num[3].ToString());
                string roman_num = unidades_de_mil[m] + centenas[c] + decenas[d] + unidades[u];
                Console.WriteLine("Numero en decimal: " + num);
                Console.WriteLine("Numero en romano: " + roman_num);
            }
            else if (num == 0)
            {
                Console.WriteLine("Numero en decimal: " + num);
                Console.WriteLine("Numero en romano: N");
            }
        }

        static void Ej7()
        {
            return;
        }

        static void Ej8()
        {
            int intentos = 0;
            while (intentos < 4)
            {
                intentos++;
                Console.Write("Introduzca su clave: ");
                string? clave = Console.ReadLine();
                if (clave == "pass1234")
                {
                    Console.WriteLine("Clave correcta");
                    break;
                }
                else
                {
                    Console.WriteLine("Clave incorrecta");
                }
            }
        } 

        static void Ej9()
        {
            Console.Write("- Triángulo -\nIntroduzca la cantidad de filas: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i =  0; i < n; i++)
            {
                Console.WriteLine(new string(' ', n - 1 - i) + new string('*', 2 * i + 1));
            }
        }
    }
}