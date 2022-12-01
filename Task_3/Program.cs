// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

using static System.Console;

void FillArray(int[] n)
{
    int i = 0;
    while (i < n.Length)
    {
        n[i] = new Random().Next(1, 1000000); //Зададим до миллиона
        i++;
    }
}

void PrintArray(int[] n)
{
    for (int i = 0; i < n.Length; i++)
    {
        Write($"{n[i]} ");
    }
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);
