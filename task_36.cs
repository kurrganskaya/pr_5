// Задача 36: Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечётных/чётных чисел.
int [] array = new int [10];
Console.Clear();
void FillArray (int [] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv [i] = new Random().Next(100,999);
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

Console.WriteLine();
int evenNumbers = 0;
int unevenNumbers = 0;
for (int i = 0; i < array.Length; i++)
{
   if (array[i] % 2 == 0) evenNumbers += 1;
   else unevenNumbers +=1;
}
Console.WriteLine($"Количество четных чисел в массиве равно {evenNumbers}, количество нечетных равно {unevenNumbers}.");
