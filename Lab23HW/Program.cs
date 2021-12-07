using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab23HW
{
    class Program
    {
        static void Factorial()
        {
            
            int R = 1;
            for (int i = 1; i <= 9; i++)
            { 
            R *= i;
            }
            Thread.Sleep(1000);
            Console.WriteLine($"Фактариал 9! = {R}");
            
        }
        static async void FactorialAsync()
        {
            Console.WriteLine("FactorialAsync начал работу");
            await Task.Run(()=>Factorial());
            Console.WriteLine("FactorialAsync закончил работу");
        }


        static void Main(string[] args)
        {
            FactorialAsync();
            Console.WriteLine("Введите число: ");
            int n = Int32.Parse(Console.ReadLine());
            int S = 0;
            for (int j = 0; j <= n; j++)
            {
               S += j;
            }
            Console.WriteLine($"Сумма чисел {S}");
            Console.WriteLine("Main закончил работу");
            Console.ReadKey();
        }
    }
}


//Разработать асинхронный метод для вычисления факториала числа. В методе Main выполнить проверку работы метода.