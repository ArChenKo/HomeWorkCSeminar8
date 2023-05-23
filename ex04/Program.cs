// Задача 61: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

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
int[,] CreateArray(string message)
{
    Console.WriteLine(message);
    int rows = Parametr("Введите количество строк: ");
    int colomns = Parametr("Введите количество столбцов: ");
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
void PrintArray(int[,] array) // метод вывода на экран выровненного массива
{
    Console.WriteLine("______________________________________________________________");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            string value = array[i, j].ToString();
            Console.Write(value.PadLeft(6));
        }
        Console.WriteLine();
    }
}
int[,] MultiArrays(int[,] firstArray, int[,] secondArray)
{
    int n = firstArray.GetLength(1);
    int a = firstArray.GetLength(0);
    int b = secondArray.GetLength(1);
    int[,] array = new int[a, b];
    if (n != secondArray.GetLength(0))
    {
        Console.WriteLine("Заданные массивы нельзя пермножить.");
        return array;
    }
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int k = 0; k < n; k++)
            {
                array[i, j] += firstArray[i, k] * secondArray[k, j];
            }
        }
    }
    return array;
}
Console.WriteLine("Задайте два массива.");
int[,] firstArray = CreateArray("\n Введите параметры первого массива.");
PrintArray(firstArray);
int[,] secondArray = CreateArray("\n Введите параметры второго массива.\n    Кол-во строк должно совпадать с кол-вом столбов первого массива!");
PrintArray(secondArray);
Console.WriteLine("\n Произведение двух массивов:");
PrintArray(MultiArrays(firstArray, secondArray));