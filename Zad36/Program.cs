/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях(по индексу считаем).
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int[] arr = new int[4];

void RandomArray(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Random rnd = new Random();
        int value = rnd.Next(50);
        arr[i] = value;
        Console.Write($"{arr[i]} ");
    }
}

void SumUnevenElements(int[] array)
{
    int sumNumber = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
        {
            sumNumber += arr[i];
        }

    }
    Console.Write($"Сумма  нечетных  чисел: {sumNumber}");
}
RandomArray(arr);
SumUnevenElements(arr);

