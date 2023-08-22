using System;
using System.Globalization;
using PrimeiroExercicio;

namespace PrimeiroExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // EX01
            Person firstPerson = new Person();
            Person secondPerson = new Person();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            firstPerson.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            firstPerson.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da Segunda pessoa:");
            Console.Write("Nome: ");
            secondPerson.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            secondPerson.Idade = int.Parse(Console.ReadLine());

            if(firstPerson.Idade > secondPerson.Idade){
                Console.WriteLine("Pessoa mais velha: " + firstPerson.Nome);
            }
            else{
                Console.WriteLine("Pessoa mais velha: " + secondPerson.Nome);
            }

            //EX02

            Person firstPerson = new Person();
            Person secondPerson = new Person();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            firstPerson.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            firstPerson.salary = double.Parse(Console.ReadLine() ,CultureInfo.InvariantCulture);

            Console.WriteLine("Dados da Segunda pessoa:");
            Console.Write("Nome: ");
            secondPerson.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            secondPerson.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salary = (firstPerson.salary + secondPerson.salary) / 2;

            Console.Write("Salário médio = " + salary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
