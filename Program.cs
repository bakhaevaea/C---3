
using System;

class MyNewClass
{
    static void Main()
    {

        Console.WriteLine("Введите координаты 1 точки (x, y, z)");
        int x1= Convert.ToInt32(Console.ReadLine());
        int y1= Convert.ToInt32(Console.ReadLine());
        int z1= Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Введите координаты 2 точки (x, y, z)");
        int x2= Convert.ToInt32(Console.ReadLine());
        int y2= Convert.ToInt32(Console.ReadLine());
        int z2= Convert.ToInt32(Console.ReadLine());
        
        task21(x1, y1, z1, x2, y2, z2);
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
    
    
    // Напишите программу, которая принимает на
//вход координаты двух точек и находит расстояние между
//ними в 3D пространстве.

    public static void task21(int x1, int y1, int z1, int x2, int y2, int z2)
    {
        double AB = Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2) + Math.Pow((z1-z2), 2));
        Console.WriteLine($"AB = {AB}");
    }
}