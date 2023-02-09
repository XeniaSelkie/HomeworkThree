// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

int fiveDigitNumb = ReadInt("пятизначное число");

int ReadInt(string argument)
{
	Console.Write($"Введите {argument}: ");
	int number;

	while (!int.TryParse(Console.ReadLine(), out number))
	{
		Console.WriteLine("Ошибка ввода, пожалуйста, введите число");
	}

	return number;
}

if (fiveDigitNumb > 9999 && fiveDigitNumb < 100000)
{
    string palindtromeDigit = fiveDigitNumb.ToString();
    if (palindtromeDigit[0] == palindtromeDigit[4] && palindtromeDigit[1] == palindtromeDigit[3])
    {
        Console.WriteLine($"{fiveDigitNumb} является палиндромом");
    }
    else Console.WriteLine($"{fiveDigitNumb} НЕ является палиндромом");
}
else
{
    Console.WriteLine("Ошибка ввода, пожалуйста, введите пятизначное число");
}
