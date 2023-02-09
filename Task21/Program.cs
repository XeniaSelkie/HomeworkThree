// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

Task21();

void Task21()
{
    int x1 = ReadInt("для первой точки координату X");
    int x2 = ReadInt("для первой точки координату Y");
    int y1 = ReadInt("для второй точки координату X");
    int y2 = ReadInt("для второй точки координату Y");
    int z1 = ReadInt("для третьей точки координату X");
    int z2 = ReadInt("для третьей точки координату Y");

    CalculateInterval3D(x1, x2, y1, y2, z1, z2);
}

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
void CalculateInterval3D(int CoordOne, int CoordTwo, int CoordThree, int CoordFor, int CoordFive, int CoordSix)
{
    double interval3D = Math.Sqrt(Math.Pow((CoordOne - CoordTwo),2) + Math.Pow((CoordThree - CoordFor),2) + Math.Pow((CoordFive - CoordSix),2));
    Console.WriteLine($"Расстояние между указанными точками в трёхмерном пространстве равняется {interval3D}");
}