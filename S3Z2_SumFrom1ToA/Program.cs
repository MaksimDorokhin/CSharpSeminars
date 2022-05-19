// Найти сумму чисел от 1 до А
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine() ?? "0");
int sum = 0;
for (int i = 1; i <= a; i++)
{
    sum = sum + i;
}
Console.WriteLine($"Сумма числел от 1 до {a} = {sum}");