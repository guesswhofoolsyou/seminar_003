/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
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

string NumLine(int numLine, int p)
{
    string outline = "1";
    for (int i = 2; i <= numLine; i++)
    {
        outline = outline + ", " + Math.Pow(i, p);
    }
    return outline;
}

int number = ReadData("Введите число: ");
string line = NumLine(number, 3);
PrintData("", line);