// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся
// (HARD - случайных уникальных) двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[] FillArray(int x, int y, int z)
{
    int size = x*y*z;
    int[] Arr = new int[size];
    int i = 0;
    int j = 1;
    int Save = 0;
    Arr[i] = new Random().Next(10, 100);
    while (j < size)
    {
        Arr[j] = new Random().Next(10, 100);
        Save = Arr[j];
        for (i = 0; i < j;)
        {
            while (Arr[i] == Arr[j])
            {
        Arr[j] = new Random().Next(10, 100);
            }
            if (Save != Arr[j])
            {
                i = 0;
                Save = Arr[j];
            }
            else
                i++;
        }
        j++;
    }
    return Arr;
}
int [,,] FromOneTo3DArray (int[] arr, int x,int y, int z)
{
    int [,,] Arr= new int [x,y,z];
    int l=0;
    for (int k = 0; k < z; k++)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++,l++)
            {
                Arr[i, j, k] = arr[l];
            }
        }
    }
    return Arr;
}
void PrintArray(int[,,] arr)
{
    for (int k = 0; k < arr.GetLength(2); k++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j, k]} ({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}
try
{
    Console.WriteLine("Введите длину массива");
    int length = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите ширину массива");
    int width = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите высоту массива");
    int height = Convert.ToInt32(Console.ReadLine());
    PrintArray(FromOneTo3DArray(FillArray(length,width,height),length,width,height));
}
catch
{
    Console.WriteLine("Проверьте правильность введенных данных");
}
