int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

// void Find(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 matrix[i, j] = matrix[i, j] * matrix[i, j];
//             }
//         }
//     }
// }

int Sum(int[,] matrix)
{
    int sum=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += matrix[i, j];
            }
        }
    }
    return sum;
}

System.Console.WriteLine("Input num of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input num of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateMatrix(rows, columns, min, max);
PrintMatrix(array);
System.Console.WriteLine();
PrintMatrix(array);
int sum = Sum(array);
System.Console.WriteLine(sum);