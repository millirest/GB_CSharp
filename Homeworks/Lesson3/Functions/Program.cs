
// Урок 4. Функции

// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

System.Console.Write("Какую задачу выполнить? (от 1 до 3):");
int task = Convert.ToInt32(Console.ReadLine());

int SumDigit(int digit) // Сложение цифр числа
{
    int sum = 0;
    while (digit>9)
    {
        sum += digit %10;
        digit = digit / 10;
    }
    sum += digit %10;
    return sum;
}

if (task==1)
{
    string Text;
    bool Process = true;
    while (Process)
    {
        System.Console.Write("Введите число:");
        Text = Console.ReadLine();
        if (Text=="q")
        {
            System.Console.Write("Было введено q. Пока");
            Process = false;
        }
        if (SumDigit(Convert.ToInt32(Text)) % 2 == 0)
        {
            System.Console.Write("Было введено четное число. Пока");
            Process = false;
        }
    }
}

// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateMassive(int rows, int min, int max) // Создание массива
{
    int[] matrix = new int[rows];
    for (int i = 0; i < rows; i++)
    {
        matrix[i] = new Random().Next(min, max + 1);
    }
    return matrix;
}

void PrintMassive(int[] massive) // Вывод массива
{
    for (int i = 0; i < massive.Length; i++)
    {
        System.Console.Write(massive[i] + " ");
    }
    System.Console.WriteLine(" ");
}

int EvenNumMassive (int[] massive) // Сумма четных элементов в массиве
    {
        int sum = 0;
        foreach (var i in massive)
        {
            if (i % 2 == 0) 
            {
                sum++;
            }
        }
        return sum;
    }

    if (task==2)
    {
        System.Console.Write("Введите количество чисел в массиве: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        int[] massive = CreateMassive(rows,100,999);
        PrintMassive(massive);
        System.Console.Write("Количество четных чисел в массиве: " + EvenNumMassive(massive));
    }

// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

int [] ReverseMassive(int[] massive) // Переворот массива
{
    int temp;
    for (int i = 0; i < massive.Length / 2; i++)
    {
        temp = massive[i];
        massive[i] = massive[massive.Length-i-1];
        massive[massive.Length-i-1] = temp;
    }
    return massive;
}

if (task==3)
{
    System.Console.Write("Введите количество чисел в массиве: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    int[] massive = CreateMassive(rows,1,9);
    PrintMassive(massive);
    ReverseMassive(massive);
    PrintMassive(massive);
}