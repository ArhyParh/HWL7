// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.Clear();
Random rnd = new Random();
Main();
void Main()
{
    int[,] one = GetArray(4, 4, 0, 10);
    PrintArray(one);
    int first = GetNumberOfLineBack(one);
    Console.WriteLine();
    Console.WriteLine(first);


}
int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] back = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            back[i, j] = rnd.Next(minValue, maxValue);

        }
    }
    return back;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} |");

        }
        Console.WriteLine();
    }
}
int GetNumberOfLineBack(int[,] arr)

{
    int res = 0;
    int res1 = 0;
    int count = 0;
    int count1 = 100;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            count += arr[i, j];
        }
        res++;
        if (count1 > count)
        {
            count1 = count;
            res1 = res;
            count = 0;
        }
        count = 0;

    }
    return res1;
}
