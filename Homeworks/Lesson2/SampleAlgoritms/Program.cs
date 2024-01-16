// Реализовано выполнение одной из 4 задач, не комитя их отдельно
System.Console.Write("Какую задачу выполнить? (от 1 до 4):");
int task = Convert.ToInt32(Console.ReadLine());

// Задача 1: Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
if (task==1)
{
	System.Console.Write("Введите число:");
	Task1(Convert.ToInt32(Console.ReadLine()));
}

void Task1 (int num) 
{
if (num % 7 == 0 && num % 23 == 0)
{
    System.Console.Write($"{num} кратно и 7 и 23");
}
else System.Console.Write($"{num} не кратно и 7 и 23");
}

// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

int DigitOS (int x, int y)
{
	int digit=0;
	if (x>0)
	{
		if (y>0)
		{
			digit = 1;
		}else digit = 4;
	}
	else
	{
		if (y>0)
		{digit =2;} 
		else digit = 3;
	}
	return digit;
}

if (task==2)
{
	System.Console.WriteLine("Введите X и Y:");
	System.Console.Write("X:");
	int x = Convert.ToInt32(System.Console.ReadLine());
	System.Console.Write("Y:");
	int y = Convert.ToInt32(System.Console.ReadLine());
	if (x*y==0)
	{
		System.Console.Write("X или Y равен 0. Нельзя так!");
	}else 	System.Console.WriteLine("Номер координатной четверти плоскости:" + DigitOS(x,y));
}


// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

if (task == 3)
{
	int num = new Random().Next(10, 99 + 1);
	System.Console.WriteLine("Целое число из отрезка:"+num);
	int num1 = num / 10;
	int num2 = num % 10;
	if (num1>num2)
	{
		System.Console.WriteLine("Наибольшая цифра:"+num1);
	}
	else	System.Console.WriteLine("Наибольшая цифра:"+num2);
}

// Задача 4: Напишите программу, которая на вход принимает натуральное число N,
// а на выходе показывает его цифры через запятую.

if (task==4)
{
	System.Console.Write("Введите натуральное число N:");
	int num = Convert.ToInt32(System.Console.ReadLine());
	var Stack = new Stack<int>();
	System.Console.Write("Цифры через запятую:");

	if (num < 10) {System.Console.Write(num);}
	else
	{
		while (num > 0)
		{
			int digit = num % 10;
			Stack.Push(digit);
			num /= 10;
			if (num>0)
			{
				System.Console.Write(digit+",");
			}
			else 
			{
				System.Console.WriteLine(digit);
				System.Console.Write("Вывод нормальным порядком:");
				while (Stack.Count>0)
				{
					System.Console.Write(Stack.Pop()+",");
					if (Stack.Count==1)
					{
						System.Console.Write(Stack.Pop());
					}
				}
			}
		}
	}
}
