﻿// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int Parametr(string message)
{
    Console.Write(message);
    int value= int.Parse(Console.ReadLine()!);
    return value;
}
int[,] CreateArray()
{
    int rows=Parametr("Введите количество строк: ");
    int colomns=rows+2;
    int minvalue=Parametr("Введите нижний порог значений: ");
    int maxvalue=Parametr("Введите верхний порог значений: ");
    int[,] array = new int[rows, colomns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minvalue,maxvalue);
        }
    }
    return array;
}
void PrintTable(int[,] array, int[] sumrows) // метод вывода на экран выровненного массива
{
    Console.WriteLine("______________________________________________________________");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            string value = array[i,j].ToString();
            Console.Write("{0,-6}", value.PadLeft(4));
        }
        Console.WriteLine($"  |{sumrows[i].ToString().PadLeft(4)}");
    }
}
int[] SumRowsArray(int[,]array)
{
    int[] rowSumArray = new int [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSumArray[i]+=array[i,j];
        }
    }
    return rowSumArray;
}
// void MinSumRow (int[] array)
// {
//     string[] indexMinRow= new string[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         //if(array[i])
//     }
// }

int[,] matrix = CreateArray();
int[] sumRowsMatrix = SumRowsArray(matrix);
PrintTable(matrix, sumRowsMatrix);
