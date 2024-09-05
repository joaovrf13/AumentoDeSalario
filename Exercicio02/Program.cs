using System;
using System.Globalization;

namespace Exercicio02 {
    class Program {
        static void Main(string[] args) {

            Funcionario F = new Funcionario();

            Console.WriteLine("Nome: ");
            F.Nome = Console.ReadLine();
            Console.WriteLine("Salário bruto: ");
            F.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Imposto");
            F.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + F);

            Console.WriteLine("Digite a porcentage, para aumentar o salário: ");
            double aumento = double.Parse (Console.ReadLine());
            F.AumentoSalario(aumento);

            Console.WriteLine("Dados atualizados: " +F);




        }
    }
}