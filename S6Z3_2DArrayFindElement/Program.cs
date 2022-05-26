// В двумерном массиве показать позицию числа, заданного пользователем или указать, что такого элемента нет
void PrintArray(int[,] matr)
{
    for (int i =0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();    
    }
} 
void FillArray(int[,] matr)
{
    for (int i =0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); 
        }  
    }
} 
void FindElement(int[,] matr, int find)
{
    bool check = false;
    for (int i =0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i,j] == find) 
            {
                Console.WriteLine($"В массиве найден элемент {find}, строка {i+1}, столбец {j+1}!");
                check = true;
            }
        }  
    }
    if (check == false) Console.WriteLine($"В массиве не найден элемент {find}!");
}
Console.Clear();
Console.WriteLine("Введите кол-во строк: ");
int n = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите кол-во столбцов: ");
int k = int.Parse(Console.ReadLine()??"0");

int[,] matrix = new int [n,k];

Console.WriteLine("Введите число для поиска в массиве: ");
int num = int.Parse(Console.ReadLine()??"0");

FillArray(matrix);
Console.WriteLine("Начальный массив: ");
PrintArray(matrix);
FindElement(matrix, num);

// Вариант от Олега Голенищева

// void PrintMatrix(int[,] matrix)
// {
//     for(int i=0;i<matrix.GetLength(0);i++)
//     {
//         for(int j=0;j<matrix.GetLength(1);j++)
//             Console.Write($"{matrix[i,j]} ");
//         Console.WriteLine();
//     }
    
// }
// int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] matrix = new int[rows,columns];
//     var random = new Random();
//     for(int i=0;i<rows;i++)
//         for(int j=0;j<columns;j++)
//             matrix[i,j] = random.Next(minValue,maxValue);
//     return matrix;
// }
// (int,int)? IndexOf(int[,] matrix, int value)
// {
//     for(int i=0;i<matrix.GetLength(0);i++)
//         for(int j=0;j<matrix.GetLength(1);j++)
//             if(matrix[i,j]==value)
//                 return (i,j);
//     return null;
// }
// Console.Write("Enter amout of matrix rows: ");
// int rows = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Enter amount of matrix columns: ");
// int columns = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Enter left side of matrix elements: ");
// int start = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Enter right side of matrix elements: ");
// int finish = int.Parse(Console.ReadLine() ?? "0");
// int[,] matrix = CreateMatrix(rows,columns,start,finish);
// Console.WriteLine("Your matrix:");
// PrintMatrix(matrix);
// Console.Write("Enter value to find in matrix: ");
// int value = int.Parse(Console.ReadLine() ?? "0");
// (int,int)? position = IndexOf(matrix,value);
// if(position==null)
//     Console.WriteLine("There is no value in matrix");
// else
//     Console.WriteLine($"Position of element: {position.Value.Item1} {position.Value.Item2}");

//Вариант строк 99 - 101 с использованием тернарного оператора

// Console.WriteLine(position != null 
//     ? $"Position of element: {position.Value.Item1} {position.Value.Item2}" 
//     : "There is no value in matrix");