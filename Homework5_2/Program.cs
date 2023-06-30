// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// EXAMPLES:    [3, 7, 23, 12] -> 19
//              [-4, -6, 89, 6] -> 0


int[] GenerateArray(int len, int min, int max)
{
    int[] array = new int[len];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
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


int SumOddPositions(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i += 2)   //We start on the first odd index, and +2 to go to the next odd index
    {
        sum += array[i];
    }

    return sum;
}


int[] array = GenerateArray(4, -99, 99);
PrintArray(array);
Console.WriteLine($"Sum of elements in odd positions: {SumOddPositions(array)}");
