// В массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] arr = new double[10];
for (int i = 0; i < arr.Length; i++)
{
  arr[i] = new Random().NextDouble()*10;
  arr[i] = Math.Round(arr[i],2); //  Округление вещественного числа до 2-х знаков
  Console.WriteLine($"{arr[i]} ");  
}
double max = arr[0];
double min = arr[0];

for (int i = 1; i < arr.Length; i++)
{
  if(arr[i] < min) min = arr[i];
  if(arr[i] > max) max = arr[i];
}
Console.WriteLine($"max = {max}");
Console.WriteLine($"min = {min}");

Console.WriteLine($"Разница = {Math.Round((max-min),2)}");