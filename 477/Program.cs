// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9
int[] array = new int[10];
int count =0;
int [] GetArray(int[] array)
{
    for (int i=1; i <array.Length; i++)
    {
        array[i]=new Random().Next(99,1000);
        if (array[i]%2==0)
        {
            count++;
        }
    }
    return array;
}
GetArray(array);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine("Кол-во четных чисел "+count);