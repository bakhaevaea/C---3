
using System;

class MyNewClass
{
    static void Main()
    {

        Console.WriteLine("Введите пятизначное число");
        int number= Convert.ToInt32(Console.ReadLine());
        task19(number);
    }

// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
    public static void task19(int num)
    {
        if(num.ToString().Length == 5)
        {
            if((num.ToString()[0] == num.ToString()[4]) && (num.ToString()[1] == num.ToString()[3]))
            {
                System.Console.WriteLine("Палиндром");
            }
            else
            {
                System.Console.WriteLine("Не палиндром");
            }
        }
        else   Console.WriteLine("Число не пятизначное");
    }
}