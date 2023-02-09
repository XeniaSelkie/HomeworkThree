// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int anyNumber = ReadInt("число");
int index = 1;
Console.WriteLine($"Таблица кубов от 1 до {anyNumber}:");

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

while (index <= anyNumber)
{
    double cubedNumber = Math.Pow(index, 3);
    Console.WriteLine($"{cubedNumber}");
    index ++;
}