// Определить количество цифр в числе
Console.WriteLine("Введите число: ");
int count =  int.Parse(Console.ReadLine() ?? "0");
int index = 0;
while ( count > 0)
{
    count = count / 10;
    index++;
}
Console.WriteLine($"Кол-во цифр в числе: {index}");