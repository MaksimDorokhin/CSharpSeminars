// Показать натуральные числа от 1 до N, N задано

// void PrintNumber(int n)
// {
//     n--;
//     if(n == 0) return;
//     PrintNumber(n);
//     Console.Write(n + " ");
// }

// int N = 20;

// PrintNumber(N);

void PrintNumber(int n)
{
    if (n < 1) return;
    PrintNumber(n - 1);
    Console.Write(n + " ");
}
PrintNumber(10);