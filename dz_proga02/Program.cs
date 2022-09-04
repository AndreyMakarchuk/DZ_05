// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
}
void PrintArray(int[] array)
{
    Console.Write($"Массив из {size} элементов -> [ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");

    }
    Console.Write("] ");
}

FillArray(array);
PrintArray(array);

int sum = 0;
for (int i = 0; i < array.Length; i++)
    if (i % 2 != 0)
        sum = sum + array[i];
Console.WriteLine($"-> {sum} сумма элеменов на нечетных позициях");
