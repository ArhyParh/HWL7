// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.Clear();
Random rnd = new Random();
Main();
void Main()
{
    int[,] res = GetArray(5, 5, 0, 10);
    PrintArray(res);
    SortArrayByTheLine(res);
    Console.WriteLine();
    PrintArray(res);
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
int[,] SortArrayByTheLine(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {

        int pick = 0;
        int count = 1;
        Boolean flag = false;
        while (flag != true)
        {
            if (count != 0)
            {
                count = 0;
                for (int j = 1; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j - 1] < arr[i, j])
                    {
                        pick = arr[i, j];
                        arr[i, j] = arr[i, j - 1];
                        arr[i, j - 1] = pick;
                        count++;
                    }
                }
            }
            else { flag = true; }
        }
    }

    return arr;
}
