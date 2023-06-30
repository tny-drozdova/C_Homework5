// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// EXAMPLE:     [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] GenerateArray(int length) //The variable 'length' will define a number of elements in array
{
    double[] array = new double[length];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * 10; // by *10 we will generate an array in the range from 0.0 to 10.0.
    }

    return array;
}

void PrintArray(double[] array)
{
    foreach (double item in array)
    {
        Console.Write(item + "\t");  
    }
    Console.WriteLine();
}

double FindDifference(double[] array)
{
    double min = array[0];
    double max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
        else if (array[i] > max)
            max = array[i];
    }

    return max - min;
}


double[] array = GenerateArray(5); // The array length is 5 elements
PrintArray(array);
double difference = FindDifference(array); //defining a variable 'difference' to store our result
Console.WriteLine($"Difference between max and min elements: {difference}");


