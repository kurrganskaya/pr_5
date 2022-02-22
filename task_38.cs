// Задача 38: Найти сумму чисел одномерного массива, стоящих на нечётной позиции.
int [] array = new int [10];
Console.Clear();
void FillArray (int [] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv [i] = new Random().Next(1,10);
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
int number = 0;
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
   if (i % 2 == 0) sum = sum + array[i++];
}
 Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях в массиве, равна {sum}.");
