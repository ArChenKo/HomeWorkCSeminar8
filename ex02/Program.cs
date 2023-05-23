// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int Parametr(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()!;
    if (int.TryParse(value, out int val))
    {
        return val;
    }
    else
    {
        Console.WriteLine("Пустые строки и символы отличные от цифр вводить нельзя!");
        val = Parametr("Введите значение еще раз:");
        return val;
    }
}
int[,] CreateArray()
{
    int rows = Parametr("Введите количество строк: ");
    int colomns = rows + 2;
    int minvalue = Parametr("Введите нижний порог значений: ");
    int maxvalue = Parametr("Введите верхний порог значений: ");
    int[,] array = new int[rows, colomns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minvalue, maxvalue);
        }
    }
    return array;
}
void PrintTable(int[,] array, int[] sumrows, string[] minvalue) // метод вывода на экран выровненного массива
{
    Console.WriteLine("______________________________________________________________");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            string value = array[i, j].ToString();
            Console.Write("{0,-6}", value.PadLeft(4));
        }
        Console.Write($"  |{sumrows[i].ToString().PadLeft(4)}");
        Console.WriteLine($"  -> {minvalue[i]}");
    }
}
int[] SumRowsArray(int[,] array) // метод вычисления сумм значений строк массива
{
    int[] rowSumArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSumArray[i] += array[i, j];
        }
    }
    return rowSumArray;
}
string[] MinSumRow(int[] array) // метод нахождения минимальной значения массива
{
    string[] indexMinRow = new string[array.Length];
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    for (int i = 0; i < indexMinRow.Length; i++)
    {
        if (array[i] == min) indexMinRow[i] = "min";
        else indexMinRow[i] = "";
    }
    return indexMinRow;
}

int[,] matrix = CreateArray();
int[] sumRowsMatrix = SumRowsArray(matrix);
string[] minSum = MinSumRow(sumRowsMatrix);
PrintTable(matrix, sumRowsMatrix, minSum);
