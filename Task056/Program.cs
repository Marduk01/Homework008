// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

int[,] randomArray = GetFillArray(10, 10);
PrintArray(randomArray);

int[] sumArraysElements = sumRowsElements(randomArray);
PrintRowPlusElemetArray(sumArraysElements);

PrintResult(sumArraysElements, randomArray);


int[,] GetFillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random randomElement = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = randomElement.Next(10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
        }
    }
}

void PrintRowPlusElemetArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"В строке {i + 1} сумма элементов = {array[i]}");
    }
}

int[] sumRowsElements(int[,] array)
{
    int[] sumElements = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        sumElements[i] = sum;
    }
    return sumElements;
}

void PrintResult(int[] arr, int[,] array)
{
    int rowIndex = 0; int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
            rowIndex = i;
        }
    }
    Console.Write($"Наименьшая сумма элементов в строке : ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[rowIndex, j]}");
    }
}
