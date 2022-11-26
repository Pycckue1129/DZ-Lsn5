// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

var array = FillArray(5);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(GetDiffMinMaxNum(array));


double GetDiffMinMaxNum(double[] array)
{
    double maxNum = array[0];
    double minNum = array[0];
    double diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNum)
        {
            maxNum = array[i];
        }
        if (array[i] < minNum)
        {
            minNum = array[i];
        }
    }
    diff = maxNum - minNum;
    return Math.Round(diff,2);
}

double[] FillArray(int length)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(30, 200) / 10.00;
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} | ");
    }
}