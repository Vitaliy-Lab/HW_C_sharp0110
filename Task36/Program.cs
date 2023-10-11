// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int min, int max, int size)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}

int SumOddNums(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i % 2 !=0) sum += numbers [i];
    }
    return sum;
}

int[] arrA = CreateArrayRndInt(-50, 100, 4);
Console.Write("[");
PrintArray(arrA);
Console.Write("]");

int sumOddNums = SumOddNums(arrA);
Console.WriteLine($" -> {sumOddNums} ");