// Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/*

int[,] FillArrayWitnRandomNumbers(int row, int column)
{
    int[,] array = new int[row,column];
    Random rnd = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
    {
       for(int j = 0; j < array.GetLength(1); j++)
       {
        array[i,j] = rnd.Next(0,20);
       }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
       for(int j = 0; j < array.GetLength(1); j++)
       {
        Console.Write($"{array[i,j]}  \t");
       }
    Console.WriteLine();
    }
}

void SortArrayFromMaxToMin(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}


Console.WriteLine("Input the number of rows in matrix:  ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number of columns in matrix:  ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillArrayWitnRandomNumbers(row, column);
PrintMatrix(matrix);

SortArrayFromMaxToMin(matrix);
Console.WriteLine();
PrintMatrix(matrix);



// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] FillArrayWitnRandomNumbers(int row)
{
    int[,] array = new int[row,row];
    Random rnd = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
    {
       for(int j = 0; j < array.GetLength(1); j++)
       {
        array[i,j] = rnd.Next(0,20);
       }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
       for(int j = 0; j < array.GetLength(1); j++)
       {
        Console.Write($"{array[i,j]}  \t");
       }
    Console.WriteLine();
    }
}

void RowWithMinSumOfElements(int[,] array)
{
    int minRow = 0;
    int minSum = 0;
    int sumRow = 0;

    for(int j = 0; j < array.GetLength(1); j++)
        {
        minSum += array[0,j];
        }
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        sumRow += array[i, j];
        if (sumRow < minSum)
        {
            minSum = sumRow;
            minRow = i;
        }
        sumRow = 0;
    }
    Console.WriteLine($"The number of the row with the minimal sum of the elements is: {minRow + 1}");
}



Console.WriteLine("Input the number of rows in matrix:  ");
int row = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillArrayWitnRandomNumbers(row);
PrintMatrix(matrix);
RowWithMinSumOfElements(matrix);




// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



int[,,] FillArrayWitnRandomNumbers(int row, int column, int z)
{
    int[,,] array = new int[row, column, z];
    int number = 9;
    for(int i = 0; i < array.GetLength(0); i++)
    {
       for(int j = 0; j < array.GetLength(1); j++)
       {
        for(int k = 0; k < array.GetLength(2); k++)
        {
            array[i,j,k] = number + 1;
            number ++;
        }
       }
    }
    return array;
}

void PrintMatrix(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
       for(int j = 0; j < array.GetLength(1); j++)
       {
        for(int k = 0; k < array.GetLength(2); k++)
        {
        Console.Write($"{array[i,j,k]} ({i},{j},{k})  \t");
        }
    Console.WriteLine();
    }
    }
}

Console.WriteLine("Input the number of rows in matrix:  ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number of columns in matrix:  ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number of sheets in matrix:  ");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] matrix = FillArrayWitnRandomNumbers(row, column, z);
PrintMatrix(matrix);

*/