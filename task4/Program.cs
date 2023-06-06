// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.Clear();
Random rnd = new Random();
Main();
void Main()
{
    Console.WriteLine("Введите x,y,z массива через пробел...");
    int [] arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    int [] temp = FillFullArr();
    if(arr[0]*arr[1]*arr[2]<=90) 
    {int [,,] res = GetArray(arr[0],arr[1],arr[2],temp);
    PrintArray(res);}
    else Console.WriteLine("Для данной задачи размерность слишком велика");
    
}
void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i,j,k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}
int [,,] GetArray(int x, int y, int z, int [] one)
{
    int [,,] back = new int[x,y,z];
    for (int i = 0; i < back.GetLength(0); i++)
    {
        for (int j = 0; j < back.GetLength(1); j++)
        {
            for (int k = 0; k < back.GetLength(2); k++)
            {
                back[i,j,k] = ChangePos(one);
            }
        }
    }
    return back;
}
Boolean CanWeDoThis(int[] arr, int num)
{
    if(arr[num]!=0){return true;}
    else return false;
}
int [] FillFullArr()
{
    int [] one = new int[90];
    for (int i = 0; i <90; i++)
    {
        one[i] =10+i;
    }
    
    return one;
}
int ChangePos(int [] arr)
{
    int p = rnd.Next(0,90);

 if(CanWeDoThis(arr,p)==true)
 {
   arr[p]=0;
   return p; 
 }
 else return ChangePos(arr);
 
}