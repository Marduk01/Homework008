// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк : ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов : ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[rows, columns];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] numbers)
{
    for ( int i = 0; i < numbers.GetLength(0); i++)
    {
        Console.Write("| ");
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + " ");
        }
        Console.Write("|");
    }
}

ModifiedArray(numbers);
PrintArray(numbers);

void ModifiedArray (int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for ( int j = 0; j < numbers.GetLength(1); j++)
        {
            for ( int k = 0; k < numbers.GetLength(1) - 1 ; k++)
            {
                if (numbers[i, k] < numbers[i, k + 1])
                {
                    int modified = numbers[i, k + 1]; numbers[i, k + 1] = numbers[i, k];
                    numbers[i, k] = modified;
                }
            }
        }
    }
}

