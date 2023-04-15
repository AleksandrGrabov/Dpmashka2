// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите цифру, обозначающую день недели: ");
int number = int.Parse(Console.ReadLine());

if (number > 0 && number <= 5)
{
System.Console.WriteLine("НЕТ");
}
else if (number > 5 && number <= 7)
{
  System.Console.WriteLine("ДА");
}
else
{
  System.Console.WriteLine("Это число не соответствует дню недели");
}