System.Console.Write("Какую задачу выполнить? (от 1 до 3): ");
int task = Convert.ToInt32(Console.ReadLine());
Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");


// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

if (task==1)
{
    System.Console.WriteLine("Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.");
    System.Console.WriteLine("Использовать рекурсию, не использовать циклы.");
    System.Console.WriteLine("Введите числа M и N:");
    System.Console.Write("Введите число M: ");
    int M = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите число N: ");
    int N = Convert.ToInt32(Console.ReadLine());

    void WriteResult (int M, int N)
    {
        if (M <= N)
        {   
            if (M>0) System.Console.Write(M+" ");
            WriteResult(M+1,N);
        }
    }

    WriteResult(M,N);
}


// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

if (task==2)
{
    System.Console.WriteLine("Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.");
    System.Console.WriteLine("Даны два неотрицательных числа m и n.");
    System.Console.WriteLine("Введите числа m и n:");
    System.Console.Write("Введите число m: ");
    byte m = Convert.ToByte(Console.ReadLine());
    System.Console.Write("Введите число n: ");
    byte n = Convert.ToByte(Console.ReadLine());
    ulong ackerman = Ackerman(m,n);
    System.Console.WriteLine($"Для числел m - {m} и n - {n} Функция Аккермана - {Ackerman(m,n)}");

}

ulong Ackerman(ulong m, ulong n)
            {
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return Ackerman(m - 1, 1);
    else
      return Ackerman(m - 1, Ackerman(m, n - 1));
            }

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

if (task==3)
{
    System.Console.WriteLine("Задача 3. Задайте произвольный массив. Выведете его элементы, начиная с конца.");
    System.Console.WriteLine("Использовать рекурсию, не использовать циклы.");
    int[] Array = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
    System.Console.WriteLine("Заданный массив: ");
    PrintArray(Array, Array.Length);
    System.Console.WriteLine("Массив с конца: ");
    ReversePrintArray(Array, Array.Length);
    void PrintArray (int[] Array, int i)
    {
        if (i>1)
        {
            System.Console.Write(Array[Array.Length-i] + ",");
            PrintArray(Array,i-1);
        }
        else System.Console.WriteLine(Array[Array.Length-i]);
    }

    void ReversePrintArray (int[] Array, int i)
    {
        if (i>1)
        {
            System.Console.Write(Array[i-1] + ",");
            ReversePrintArray(Array,i-1);
        }
        else System.Console.WriteLine(Array[i-1]);
    }
    
}