// Урок 4. Функции
// Задача 25: Напишите метод, который принимает на вход 
//два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("napishite 1 chislo");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("napishite 2 chislo");
int numB = int.Parse(Console.ReadLine());

int value = numA;
for (int power =0; power <=numB; power++)
    Console.WriteLine($"{value}^{power} = {(long)Math.Pow(value, power):N0} (0x{(long)Math.Pow(value, power):X})");


// Задача 27: Напишите программу, которая принимает на входе
// число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using System;
 
class GFG {
    static int getSum(int n)    
    {
        int sum;
        for (sum = 0; n > 0; sum += n % 10, n /= 10)
            ;
        return sum;
    }
    public static void Main()
    {
        int n = 82;
        Console.Write(getSum(n));
    }

}
// Задача 29: Напишите программу, которая задаёт массив из
// 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] a = Enumerable.Range(1, 8).Select(x => 17 % x).ToArray(); 
foreach (int i in a)
  Console.WriteLine(i);
