/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

double FindLengh(int firstX, int firstY, int firstZ, int secondX, int secondY, int secondZ)
{
    return Math.Sqrt(Math.Pow(firstX - secondX, 2) + Math.Pow(firstY - secondY, 2) + Math.Pow(firstZ - secondZ, 2));
}

int firstX = ReadData("Введите первый X =");
int firstY = ReadData("Введите первый Y =");
int firstZ = ReadData("Введите первый Z =");

int secondX = ReadData("Введите второй X =");
int secondY = ReadData("Введите второй Y =");
int secondZ = ReadData("Введите второй Z =");

double lengh = FindLengh(firstX, firstY, firstZ, secondX, secondY, secondZ);
lengh = Math.Round(lengh,2);

PrintData("Расстоияние между заданными точками =",lengh.ToString());