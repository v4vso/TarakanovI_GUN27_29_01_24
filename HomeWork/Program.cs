using System;


namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#1 Fibonacci sequence

            int a = 0;
            int b = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(a);
                int temp = a;
                a = b;
                b = temp + b;
            }
            Console.WriteLine();
            //#2 2 to 20

            for (int i = 2; i <= 20; i += 2)
                {
                Console.WriteLine(i);
                }
            Console.WriteLine();
            //#3 Multiplication table

            for (int i = 1; i <= 5; i++)
               {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(i * j + "\t");
                }
                Console.WriteLine();
               }
            Console.WriteLine();
            //#4 Input password "qwerty"

            string password = "qwerty"; 
            string input = string.Empty;  

            do 
            {
                Console.Write("Введите пароль: ");  
                input = Console.ReadLine(); 
            } while (input != password); 

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Вы успешно вошли в систему!");

            //

            
        }
    }
}