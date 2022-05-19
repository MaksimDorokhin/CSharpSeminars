// Написать программу замену элементов массива на противоположные
Console.Clear();
//int[] arr = {-3, 5, 2, 1211, 323, -23, -23, 4, -6};
int[] arr = new int[8];
for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(-100, 100);
for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]} ");
Console.WriteLine();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = -arr[i];
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();
