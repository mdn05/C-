//// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введи свое первое число - ");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("Введи свое второе число - ");
// int b = int.Parse(Console.ReadLine());

// bool A = a > b;

// bool B = a < b;

// if (A)
// {
//     Console.WriteLine($"{a} больше чем {b}");
// }
// else if (B)
// {
//     Console.WriteLine($"{a} меньше чем {b}");
// }


//Задача 4: Напишите программу, которая принимает на вход три числа и 
//          выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
// Console.WriteLine("введите 1 число -");
// int a1 = int.Parse(Console.ReadLine());
// Console.WriteLine("введите 2 число -");
// int b1 = int.Parse(Console.ReadLine());
// Console.WriteLine("введите 3 число -");
// int c1 = int.Parse(Console.ReadLine());
// int max = a1;
// if (b1 > max) max = b1;
// if (c1 > max) max = c1;
// Console.WriteLine(max);


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//          является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

// Console.WriteLine("введите число -");
// int i = int.Parse(Console.ReadLine());
// if (i % 2 == 0)
// {
//     Console.WriteLine("введенное число четное");
//     Console.ReadLine();
// }
// else
// {
//     Console.WriteLine("введенное число нечетное");
//     Console.ReadLine();
// }


//Задача 8: Напишите программу, которая на вход принимает число (N), 
//          а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

//Console.WriteLine("Введите число -");
//int n = Convert.ToInt32(Console.ReadLine());
//for (int i=1;i<=n;i++)
//{
//if (i % 2 == 0)
//System.Console.Write(i + " ,");
//}