using System;

namespace BasicTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            sbyte x = 127;
            x++; // como o sByte já está no máximo permitido, ele vai para o oposto.
            char y = 'a';
            string s = "X referece a sbyte e y se refere a char";
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(s);


        }
    }
}
