// Найти сумму цифр числа
int RecSum(int num)
{
    if (num == 0)
        return num;
    return num % 10 + RecSum(num / 10);
}
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Сумма цифр числа = {RecSum(Math.Abs(num))}");

// С исп. тернарного оператора:

// uint SumDigits(uint n) => n<10 ? n : n%10 + SumDigits(n/10);
// Console.Write("Enter your number: ");
// uint n = uint.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine($"Sum of digits {SumDigits(n)}");