// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// Example:     [345, 897, 568, 234] -> 2



int[] GenerateArray(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000); // We generates random three-digit numbers
    }

    return array;
}


void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write(item + "\t");
    }
    Console.WriteLine();
}


int CountEvenNumbers(int[] array)
{
    int count = 0;

    foreach (int item in array)
    {
        if (item % 2 == 0) // we checks if the number is even
        {
            count++;
        }
    }

    return count;
}

int[] array = GenerateArray(4);
PrintArray(array);
Console.WriteLine($"Number of even numbers: {CountEvenNumbers(array)}");

