int[] GetArray(int lenght)
{
    int[] array = new int[lenght];
    for(int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(100, 1000);
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

int GetCount(int[] array)
{
    int sum = 0;
    foreach (var item in array)
    {
        if (item % 2 == 0)
        {
            sum++;
        }
    }
    return sum;
}

Console.WriteLine("Select Array Lenght");
int[] array = GetArray(Convert.ToInt32(Console.ReadLine()));
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Even Numbers - {GetCount(array)}");