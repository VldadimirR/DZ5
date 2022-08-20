/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */
int[] arr = new int[5];

void RandomArray(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Random rnd = new Random();
        int value = rnd.Next(-50, 50);
        arr[i] = value;
        Console.Write($"{arr[i]} ");
    }
}

void DifferenceMinMax(int[] array)
{
    int min = arr[0];
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
        }
        if (max < arr[i])
        {
            max = arr[i];
        }

    }
    Console.WriteLine();
    Console.Write($"Разница между максимальным и минимальным элементом равна: {max - min}");
}

RandomArray(arr);
DifferenceMinMax(arr);