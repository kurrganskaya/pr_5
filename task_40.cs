// Задача 40: В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами.
int [] array = new int [10];
Console.Clear();
void FillArray (int [] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv [i] = new Random().Next(-10,10);
    }
}
FillArray(array);

void PrintArray(int [] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.Write($"{massiv[i]}  ");
    }
}
PrintArray(array); 

static int Max(int[]array)
{
    int max = array[0];
    for (int i = 0; i < array.Count(); i++)
    {
        if (max < array[i]) max = array[i];
    }
    return max;
}
Max(array);

static int Min(int[]array)
{
    int min = array[0];
    for (int i = 0; i < array.Count(); i++)
    {
        if (min > array[i]) min = array[i];
    }
    return min;
}
Min(array); 

Console.WriteLine($"\nРазница между максимальным и минимальным элементами массива равна {Max(array) - Min(array)}.");
