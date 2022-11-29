// Задача 38: Задайте массив целыми числами. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = GetArray(10);
PrintArray(array);

Console.WriteLine();
Console.WriteLine($"{GetMax(array) + GetMin(array)}");

int[] GetArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item}, ");
    }
}

int GetMax(int[] array)
{
    int MaxNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (MaxNumber < array[i])
        {
            MaxNumber = array[i];
        }

    }
    return MaxNumber;
}

int GetMin(int[] array)
{
    int MinNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (MinNumber > array[i])
        {
            MinNumber = array[i];
        }

    }
    return MinNumber;
}
