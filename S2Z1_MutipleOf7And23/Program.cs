//Дано число. Проверить кратно ли оно 7 и 23
Console.WriteLine("Insert ur number");
int number = int.Parse(Console.ReadLine());
if(number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"{number} is multiple of 7 and 23");
}
else
{
    Console.WriteLine($"{number} isnt multiple of 7 and 23");
}