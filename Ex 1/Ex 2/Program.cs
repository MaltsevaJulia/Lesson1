// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Enter  number1 ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter  number2 ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter  number3 ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = Math.Max(Math.Max(number1, number2), number3);

Console.WriteLine(max);
