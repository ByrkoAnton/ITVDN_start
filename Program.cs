using System;

namespace ITVDN_start
{
    class Program
    {
      const double PI = 3.141592653;  
        static void Main(string[] args)
        {
            Variables_additional();
        }

        static void Variables_1()
        {
            int x = 10, y = 12, z = 3;
            x += y - x++ * z;
            z = --x - y * 5;
            y /= x + 5 % z;
            z = x++ + y * 5;
            x = y - x++ * z;

            Console.WriteLine($"x= {x}");
            Console.WriteLine($"y= {y}");
            Console.WriteLine($"z= {z}");
        }

        static void Variables_2()
        {
            int x = 5, y = 6, z = 11;

            double averege =(x + y + z) / 3d;

            Console.WriteLine($"averege {x} + {y} + {z} = {averege}");
        }

        static void Variables_3()
        {
            Console.Write("Enter radius ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"circle area = {PI*Math.Pow(r,2)}");
        }

        static void Variables_4()
        {
            Console.Write("Enter radius ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height ");
            double h = Convert.ToDouble(Console.ReadLine());

            double volume = PI * Math.Pow(r, 2) * h;
            double area = 2 * PI * r * (r + h);

            Console.WriteLine($"cilinder voume = {volume}");
            Console.WriteLine($"cilinder area = {area}");
        }

        static void Variables_additional()
        {
            Console.Write("Enter fisrs variable (a) ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second variable (b) ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(
                $"a + b = {a + b}\n" +
                $"a - b = {a - b}\n" +
                $"a * b = {a * b}\n" +
                $"a / b = {(double)a / b}\n" +
                $"a % b = {a % b}");
        }

        static void Machine_Mathematics_2()
        {
            double pi = 3.141592653;
            decimal e = 2.7182818284590452M;
            Console.WriteLine($"PI = {pi} \nEL = {e}");
        }
        static void Machine_Mathematics_3()
        {
            string s1 = "\nмоя строка 1"; //new line
            string s2 = "\tмоя строка 2"; // tab    
            string s3 = "\aмоя строка 3"; // allert
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
        }

    }
}
