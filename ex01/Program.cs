// Задача 54. Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int Parametr(string message)
{
    Console.Write(message);
    int value= int.Parse(Console.ReadLine()!);
    return value;
}
double[,] CreateArray()
{
    int rows=Parametr("Введите количество строк: ");
    int colomns=Parametr("Введите количество столбцов: ");
    int minvalue=Parametr("Введите нижний порог значений: ");
    int maxvalue=Parametr("Введите верхний порог значений: ");
    double[,] array = new double[rows, colomns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minvalue,maxvalue);
        }
    }
    return array;
}
void PrintArray(double[,] array) // метод вывода на экран выровненного массива
{
    Console.WriteLine("______________________________________________________________");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            string value = array[i,j].ToString();
            Console.Write(value.PadLeft(6));
        }
        Console.WriteLine();
    }
}
double [,] SortArray(double[,] array) // метод обратной сортировки строк в двумерном массиве
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            for (int k = j+1; k < array.GetLength(1); k++)
            {
                if(array[i,j]<array[i,k])
                {
                    double temp = array[i,j];
                    array[i,j]=array[i,k];
                    array[i,k]=temp;
                }
            }
        }
    }
    return array;
}
double[,] matrix = CreateArray();
PrintArray(matrix);
PrintArray(SortArray(matrix));