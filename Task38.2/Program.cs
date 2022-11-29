// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = GetArray(10);
PrdoubleArray(array);

Console.WriteLine();
Console.WriteLine($"{GetMax(array) + GetMin(array)}");

double[] GetArray(int length)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble() + new Random().Next(-99, 100);
    }
    return array;
}

void PrdoubleArray(double[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item}, ");
    }
}

double GetMax(double[] array)
{
    double MaxNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (MaxNumber < array[i])
        {
            MaxNumber = array[i];
        }

    }
    return MaxNumber;
}

double GetMin(double[] array)
{
    double MinNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (MinNumber > array[i])
        {
            MinNumber = array[i];
        }

    }
    return MinNumber;
}