// Задача 58: Заполните спирально массив 4 на 4 числами от 1 до 16.

int Parametr(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine()!);
    return value;
}
int[,] SpiralFillArray(int arrows, int arrcolumns)
{
    int[,] array = new int[arrows, arrcolumns];
    int rows = arrows - 1;
    int columns = arrcolumns - 1;
    int value = 1;
    int maxvalue = array.GetLength(0) * array.GetLength(1);
    for (int x = 0; value <= maxvalue; x++)
    {
        for (int j = x; j < columns - x; j++)
        {
            if (array[x, j] == 0)
                array[x, j] = value++;
        }
        for (int i = x; i <= rows - x; i++)
        {
            if (array[i, columns - x] == 0)
                array[i, columns - x] = value++;
        }
        for (int k = columns - x; k >= x; k--)
        {
            if (array[rows - x, k] == 0)
                array[rows - x, k] = value++;
        }
        for (int l = rows - x; l >= x; l--)
        {
            if (array[l, x] == 0)
                array[l, x] = value++;
        }
    }
    return array;
}
void Printarray(int[,] array)
{
    int maxvalue = array.GetLength(0) * array.GetLength(1);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j].ToString().PadLeft(maxvalue.ToString().Length + 2)}");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

int arrows = Parametr("Введите количество строк: ");
int arrcolumns = Parametr("Введите количество столбцов: ");
int[,] array = SpiralFillArray(arrows,arrcolumns);
Printarray(array);