Console.Write("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число, которое хотите найти: ");
int num = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[m, n];
int T = 0;
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
PrintNumber(numbers);
{
if (T > 0)
{
    Console.Write(num + " -> это число встречается в массиве " + T + " раз(а)");
}
else
{
    Console.Write(num + " -> этого числа не существует в массиве");
}
}
void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0,10);
        }
    }
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[  ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
void PrintNumber(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {   
            if (array[i, j] == num)
            T = T + 1;
            }
            
        }
    }