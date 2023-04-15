//  Напишите программу, которая принимает на вход трёхзначное число и на выходе
//   показывает вторую цифру этого числа.

System.Console.WriteLine("Введите число i: ");
 int number = int.Parse(Console.ReadLine());

int i = number % 100;
int a = i / 10;

System.Console.WriteLine($"Вторая цифра {a}");