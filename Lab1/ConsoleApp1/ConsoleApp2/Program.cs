using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        
        {      
            double firstvalue, secondvalue;
            Console.WriteLine("Введите первое значение:");
            firstvalue = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите одно из действий: +, -, *, /");
            string activity = Console.ReadLine();
            Console.WriteLine("Введите второе значение:");
            secondvalue = double.Parse(Console.ReadLine());
            
            switch (activity)
            {
                case "+":
                    Console.WriteLine("Результат cложения = {0}", firstvalue + secondvalue);
                    break;
                case "-":
                    Console.WriteLine("Результат вычитания = {0}", firstvalue - secondvalue);
                    break;
                case "*":
                    Console.WriteLine("Результат умножения = {0}", firstvalue * secondvalue);
                    break;
                case "/":
                    if (secondvalue == 0)
                        Console.WriteLine("На ноль делить нельзя");
                    else
                        Console.WriteLine("Результат деления = {0}", firstvalue / secondvalue);
                    break;
                default:
                    Console.WriteLine("Неверное действие");
                    break;
            }
        }
    }
}
