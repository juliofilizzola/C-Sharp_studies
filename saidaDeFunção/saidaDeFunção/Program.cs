using System;

namespace saidaDeFunção {
    class Program {
        static void Main(string[] args) {

            int age = 32;
            double sold = 10.35784;
            string name = "Maria";

            Console.WriteLine("{0} tem {1} anos e tem o saldo igual a {2:F2} reais", name, age, sold);
            // essa saida é o placeholder

            Console.WriteLine($"{name} tem {age} anos e tem o saldo igual a {sold:F2} reais");

            // exemplo de template string

            Console.WriteLine(name + " tem " + age + " anos e tem o saldo igual a " + sold.ToString("F2") + " reais");
        }
    }
}
