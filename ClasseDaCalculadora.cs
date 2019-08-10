using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp150
{
    class Calculadora
    {
        private double num1;
        private double num2;

        public double Soma { get; private set; }
        public double Subtracao { get; private set; }
        public double Multiplicacao { get; private set; }
        public double Divisao { get; private set; }
        public Calculadora(double soma, double subtracao, double multiplicacao, double divisao)
        {
            Soma = soma;
            Subtracao = subtracao;
            Multiplicacao = multiplicacao;
            Divisao = divisao;
        }

        public Calculadora()
        {

        }

        public double Somando(double a, double b)
        {
            return Soma = a + b;
        }
        public double Subtraindo(double a, double b)
        {
            return Subtracao = a - b;
        }
        public double Multiplicando(double a, double b)
        {
            return Multiplicacao = a * b;
        }
        public double Dividindo(double a, double b)
        {
            return Divisao = a / b;
        }
    }
}
