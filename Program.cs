using System;

namespace ITVDN_start
{
    class Program
    {
        static void Main(string[] args)
        {
            Machine_Mathematics_3();
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
