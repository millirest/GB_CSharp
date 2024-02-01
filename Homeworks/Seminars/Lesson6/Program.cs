// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

// string CharsToString(char[] chars)
// {
//     string str = "";
//     for (int i = 0; i < chars.Length; i++)
//     {
//         str += chars[i];
//     }
//     return str;
// }

// char[] chars = {'a', 'b', 'c', 'd'};
// string str = new string(chars);
// System.Console.WriteLine(str);

// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ] 

// char[] StringToChars(string str)
// {
//     char[] chars = new char[str.Length];
//     for (int i = 0; i < str.Length; i++)
//     {
//         chars[i] = str[i];
//     }
//     return chars;
// }

// void PrintChars(char[] chars)
// {   
//     System.Console.Write("[");
//     for (int i = 0; i < chars.Length - 1; i++)
//     {
//         System.Console.Write($"'{chars[i]}', ");
//     }
//     System.Console.WriteLine($"'{chars[chars.Length - 1]}' ]");
// }

// string str = "Hello!";
// System.Console.WriteLine(str.ToCharArray());




// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

string CharsToString(char[] chars)
{
    string str = "";
    for (int i = 0; i < chars.Length; i++)
    {
        str += chars[i];
    }
    return str;
}

char[] dictionary = {'a', 'o', 'y', 'e', 'u', 'i'}; // Словарь
int Check (string str)
{
    // string dict = CharsToString(dictionary);
    int sum =0;
    for (int i = 0; i < str.Length; i++)
    {
        foreach (char e in dictionary)
        {
            if (str[i]==e)
            {
                sum++;
            }
        }
        // for (int j = 0; j < dict.Length; j++)
        // {
        //     if (str[i]==dict[j])
        //     {
        //         sum++;
        //     }
        // }
    }
    return sum;
}

void Result ()
{
    System.Console.Write("Напишите текст:");
    string str = Console.ReadLine();
    System.Console.Write("Колличество гласных в тексте: ");
    System.Console.Write(Check(str));
}

Result();

// Split разбивает строку на массив строк