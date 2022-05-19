// Программа проверяет пятизначное число на палиндромом.
/*Console.WriteLine("Введите число: ");
string sNum = Console.ReadLine();
if (sNum[0] == sNum[4] && sNum[1] == sNum [3])
    Console.WriteLine("Введенное число является палиндромом");
else
   Console.WriteLine("Введенное число не является палиндромом");
*/
Console.WriteLine("Введите число: ");
int sNum = int.Parse(Console.ReadLine());
if (sNum / 10000 == sNum % 10 && sNum / 1000 % 10 == sNum / 10 % 10)
Console.WriteLine("Введенное число является палиндромом");
else
   Console.WriteLine("Введенное число не является палиндромом");