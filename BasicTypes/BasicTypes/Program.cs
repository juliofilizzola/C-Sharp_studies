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
            char c = '\u0041';
            string s = "X referece a sbyte e y se refere a char";
            bool thisIsBool = false;
            string thisIsString = "This is string";
            // a variavel que for cria como string, deve conter ela com aspas duplas
            Console.WriteLine(thisIsBool);
            Console.WriteLine(thisIsString);
            Console.WriteLine(c);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(s);
        }
    }
}
