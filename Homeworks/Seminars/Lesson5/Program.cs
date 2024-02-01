int FindSum(int num)//456
{
    if(num > 0)
    {
        return num % 10 + FindSum(num / 10);
    }
    return 0;
}
System.Console.WriteLine(FindSum(46498));


// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.


void OneToN(int n)
{
    if(n>0)
    {
        OneToN(n-1);
        System.Console.Write(n + " ");
    }
}
OneToN(5);

// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// string str = System.Console.ReadLine();
// char[] letter = ('a', 'e', 'y', 'u', 'i', 'o');
// void WriteStr(string str[], int i)
// {
//     if (str[i] == "a" || str == "e" || str || )
//     if (currentChar >= 'a' && currentChar <= 'z' && "aeiou".IndexOf(currentChar) == -1)
//     {}
// }

void Sogl(string str, int i)
{
  if(i == str.Length)
    return;
  if(str[i] >= 'a' && str[i] <= 'z' && "aeiou".IndexOf(str[i]) == -1)
  {
    Console.Write(str[i]);
  }
  Sogl(str, i + 1);
}

string str = Console.ReadLine();
Sogl(str, 0);

// 
