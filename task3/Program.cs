// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Random rnd = new Random();
Main();
void Main()
{
    Console.WriteLine("Введите количество строк и столбцов 1 массива, через пробел..");
    int [] first = Array.ConvertAll(Console.ReadLine()!.Split()!, int.Parse);
    Console.WriteLine("Введите количество строк и столбцов 2 массива, через пробел..");
    int [] second = Array.ConvertAll(Console.ReadLine()!.Split()!, int.Parse);
    int [,] res1 = GetArray(first[0],first[1],1,10);
    int [,] res2 = GetArray(second[0],second[1],1,10);
    Console.WriteLine();
    PrintArray(res1);
    Console.WriteLine();
    PrintArray(res2);
    Console.WriteLine();
    if(CanWeMulti(res1,res2)==true){PrintArray(MultiplicationArray(res1,res2));}
    else{Console.Write("Данные матрицы не подлежат перемножению.");}


}
int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] back = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            back[i, j] = rnd.Next(minValue, maxValue + 1);

        }
    }
    return back;

}
void PrintArray(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} |");
        }
        Console.WriteLine();
    }
}
Boolean CanWeMulti(int[,] first, int [,] second)
{
    if(first.GetLength(1)==second.GetLength(0)) {return true;}
    else return false;
}
int[,] MultiplicationArray(int[,] first, int[,] second)
{
    int[,] back =new int [first.GetLength(0),second.GetLength(1)];
    {
        for (int i = 0; i < back.GetLength(0); i++)
    {
        for (int j = 0; j < back.GetLength(1); j++)
        {
            for (int n = 0; n < first.GetLength(1); n++)
            {
                back[i,j] += first[i,n]*second[n,j];
            }
            
        }
    }

    }
    return back;

}