using System;

namespace ConsoleApp150
{
    class CodigoDaCalculadora
    {
        static void Menu()
        {

            Console.Clear();
            Console.WriteLine("Calculadora");
            Console.WriteLine("\n1. soma");
            Console.WriteLine("2. subtração");
            Console.WriteLine("3. multiplicacao");
            Console.WriteLine("4. divisão");
            Console.Write("\nDigite Sua Opção: ");
        }
        static void Main(string[] args)
        {
            int decisao = 0;
            int j;
            j = args.Length;
            char sair = ' ';

            do
            {
                Menu();
                decisao = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o primeiro número ");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número");
                double num2 = double.Parse(Console.ReadLine());
                Calculadora Valor = new Calculadora();
                if (decisao == 1)
                {
                    Console.WriteLine("Resultado da soma: {0}", Valor.Somando(num1, num2));
                }
                else if (decisao == 2)
                {
                    Console.WriteLine("Resultado da soma: {0}", Valor.Subtraindo(num1, num2));
                }
                else if (decisao == 3)
                {
                    Console.WriteLine("Resultado da soma: {0}", Valor.Multiplicando(num1, num2));
                }
                else if (decisao == 4)
                {
                    Console.WriteLine("Resultado da soma: {0}", Valor.Dividindo(num1, num2));
                }
                else if (decisao > 4)
                {
                    Console.WriteLine("Entrada invalida");
                }
                Console.WriteLine("Digite S para sair ou C para continuar ");
                sair = char.Parse(Console.ReadLine().ToUpper());
                if (sair == 'S')
                {
                    Console.WriteLine("Obrigado por utilizar a minha calculadora: by Nabaia");
                }
            } while (sair != 'S');
            Console.WriteLine("Olá mundo");
        }
    }
}
