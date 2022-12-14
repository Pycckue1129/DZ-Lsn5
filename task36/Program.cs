// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


var array = FillArray(5);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(GetSumOddIndex(array));


int GetSumOddIndex(int[] array)
{
    int sumOdd = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sumOdd = sumOdd + array[i];
        }
    }
    return sumOdd;
}

int[] FillArray (int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0,10);
    }
    return array;
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
}