// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:

// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:

//18 20
//15 18

int rows = ReadInt("Введите количество строк : ");
int columns = ReadInt("Введите количество столбцов : ");

int[,] firstArray = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
int[,] multiArray = new int[rows, columns];

FillArrayRandom(firstArray);
PrintArray(firstArray);
Console.WriteLine();

FillArrayRandom(secondArray);
PrintArray(secondArray);
Console.WriteLine();

if(firstArray.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine("Нельзя умножить ");
    return;
}

void FillArrayRandom(int[,] firstArray)
{
    for(int i = 0; i < firstArray.GetLength(0); i++)
    {
        for(int j = 0; j < firstArray.GetLength(1); j++)
        {
            firstArray[i, j] = new Random().Next(1,10);
        }
    }
}

for(int i = 0; i < firstArray.GetLength(0); i++)
{
    for(int j = 0; j < secondArray.GetLength(1); j++)
    {
        multiArray[i, j] = 0;
        for(int k= 0; k < firstArray.GetLength(1); k++)
        {
            multiArray[i, j] += firstArray[i, k] * secondArray[k, j];
        }
    }
}

PrintArray(multiArray);

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] firstArray)
{
    for(int i = 0; i < firstArray.GetLength(0); i++)
    {
        for(int j = 0; j < firstArray.GetLength(1); j++)
        {
            Console.Write($"{firstArray[i, j]}");
        }
        Console.WriteLine();
    }
}