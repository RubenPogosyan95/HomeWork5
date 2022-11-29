// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] array = GetArray(4);
PrintArray(array);

Console.WriteLine();
Console.WriteLine($"Sum of Numbers = {GetSum(array)}");

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

int GetSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}