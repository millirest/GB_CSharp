System.Console.Write("Какую задачу выполнить? (от 1 до 4):");
int task = Convert.ToInt32(Console.ReadLine());
Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");


// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

char[,] CreateArrayChar(int x, int y) // Заполнение массива
{
    char[,] Array = new char[x, y];
    System.Console.WriteLine("Ввод массива:");
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            Array[i, j] = Console.ReadLine()[0];
        }
    }
    return Array;
}

string CharsToString(char[,] Array)
{
    string String = "";
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            String += Array[i, j];
        }
    }
    return String;
}

if (task == 1)
{
    char[,] charArray = new char[,] { { 'A', 'B' }, { 'C', 'D' } };
    string result = CharsToString(charArray);
    Console.WriteLine(result);
    // Ввод своего массива
    System.Console.WriteLine("Размер массива: x/y : ");
    System.Console.Write("x: ");
    int x = Convert.ToInt32(System.Console.ReadLine());
    System.Console.Write("y: ");
    int y = Convert.ToInt32(System.Console.ReadLine());
    char[,] Array = CreateArrayChar(x, y);
    System.Console.WriteLine(CharsToString(Array));
}


// Не стал удалять, вдруг понадобится не рабочий код :)
// string AToa (string Label)
// {
//     string NewString = Label;
//     char[] StringUP = 'Q', 'W', 'E', 'R',
//     char[] StringDown = "qwertyuiopasdfghjklzxcvbnm";
//     for (int i = 0; i < Label.Length; i++)
//     {
//         for (int j = 0; j < StringUP.Length; j++)
//         {
//             if (Label[i] == StringUP[j])
//             {
//                 NewString[i] = StringDown[j];
//             }
//         }
//     }
//     return NewString;
// }

// void ConvertToDownRegister(ref string str)
// {

// }

// char[] AllDownRegister()  // Создание массива для проверки нижнего регистра
// {
//     char[] DownArray = new char[26];
//     DownArray[0] = 'a';
//     for (int i = 1; DownArray[i] >= 'a' && DownArray[i] <= 'z'; i++)
//     {
//         DownArray[i]= DownArray[i-1];
//     }
//     return DownArray;
// }
//   if(str[i] >= 'a' && str[i] <= 'z' && "aeiou".IndexOf(str[i]) == -1)


// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

if (task == 2)
{
    // Не получилось так
    // string StringBoth = System.Console.ReadLine();
    // string NewString =  AToa(StringBoth);
    // System.Console.WriteLine(NewString);
    // System.Console.WriteLine(AllDownRegister());
    Console.Write("Введите строку: ");
    string input = "" + Console.ReadLine();
    Console.WriteLine("Новая строка:");
    string result = input.ToLower();
    Console.WriteLine(result);
}

// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

bool CheckPolindrom(string str)
{
    int Length = str.Length;
    string normalized = str.ToLower();
    for (int i = 0; i < Length / 2; i++)
    {
        if (str[i] != str[Length - i - 1])
        {
            return false;
        }
    }
    return true;
}

if (task == 3)
{
    System.Console.Write("Введите строку: ");
    string Label = "" + Console.ReadLine();
    Console.WriteLine(CheckPolindrom(Label) ? "Является" : "Не является");
}

// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

if (task == 4)
{
    System.Console.Write("Введите строку: ");
    string MyText = Console.ReadLine();
    System.Console.WriteLine(ReverseTextToWords(MyText));
    // Заготовленный текст
    string text = "И поэтому ничего не получается";
    string ReverseTextToWords(string str)
    {
        string[] words = str.Split(" ");
        string text = "";
        for (int i = 0; i < words.Length; i++)
        {
            text += words[words.Length - i - 1] + " ";
        }
        return text;
    }
    System.Console.Write(ReverseTextToWords(text));
}

