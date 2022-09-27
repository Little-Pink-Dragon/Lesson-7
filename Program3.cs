Console.Write("Введите количество строк в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
Console.Write("Среднее арифметическое число каждого столбца: ");
for (int j = 0; j < numbers.GetLength(1); j++)
{   
    double arithmetic = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        arithmetic = (arithmetic + numbers[i, j]);
    }
    arithmetic = Math.Round (arithmetic / n, 1);
    Console.Write(arithmetic + "; ");
}
Console.WriteLine();
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}