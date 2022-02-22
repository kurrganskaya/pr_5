// Задача 34: Написать программу для замены элементов массива на противоположные.

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

void Change(int [] massiv)
    {
      for (int i = 0; i < massiv.Length; i++)
        {
            massiv[i] = -massiv[i];
        }
    }
 
Change(array);
Console.WriteLine();
PrintArray(array);
