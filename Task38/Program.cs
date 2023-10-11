// Задача 38: 
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }

    return arr;
}

void PrintArrayDouble(double[] array)
{
    //Console.WriteLine("[");
    for (int i = 0; i < array.Length; i++)
    {
        //double nRound = Math.Round(arr[i], 1);
        if (i < array.Length - 1) Console.Write($"{array[i]:F2}, ");
        else Console.Write($"{array[i]:F2}");
    }
    //Console.WriteLine("]");
}

double DiffMaxMinElements(double[] array)
{
    double min = array[0];
    double max = array[0];
    
    for(int i = 0; i < array.Length;)
    {
        if (array[i] > max) max = array[i];

        if (array[i] < min) min = array[i];

        i = i + 1;
    }
    Console.Write($" => {max:F2} - {min:F2} =");
    return max - min;
}

double[] arrA = CreateArrayRndDouble(6, 5, 49);
Console.Write("[");
PrintArrayDouble(arrA);
Console.Write("]");

double diffMaxMinElements = DiffMaxMinElements(arrA);
Console.Write($" {diffMaxMinElements:F2} ");