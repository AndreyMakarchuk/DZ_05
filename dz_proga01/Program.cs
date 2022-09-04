//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(99, 1000);
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

int count = 0;
for (int z = 0; z < array.Length; z++)
    if (array[z] % 2 == 0)
        count++;
Console.WriteLine($"-> {count} чётные");