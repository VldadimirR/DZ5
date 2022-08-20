/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int[] arr = new int[10];

void RandomArray(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Random rnd = new Random();
        int value = rnd.Next(100, 999);
        arr[i] = value;
        Console.Write($"{arr[i]} ");
    }
}

void ThreeNumberEven(int[] array)
{
    int numberExist = 0;
    for (int i = 0; i < arr.Length; i++)
    {
       if (arr[i]%2==0 )
       {
        numberExist++;
       }
    
    }
    if (numberExist > 0)
    {
        Console.Write($"Количество четных чисел - {numberExist}");
    }
    else
    {
        Console.Write($"Четных чисел нет - {numberExist}");
    }
}
RandomArray(arr);
ThreeNumberEven(arr);
