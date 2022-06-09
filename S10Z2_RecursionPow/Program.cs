// Написать программу возведения числа А в целую стень B

int RecPow (int a, int b) => b == 0? 1 : a * RecPow(a, b - 1);

Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите степень B: ");
int b = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Число {a} в степени {b} = {RecPow(a, b)}");