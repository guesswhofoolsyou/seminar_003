/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

string ReadData(string line)
{
    Console.WriteLine(line);
    string inputNumber = Console.ReadLine() ?? "";
    return inputNumber;
}

int LengthNumber(int number)
{
    int lengthNumber = (int)Math.Log10(number);
    return lengthNumber;
}

string number = ReadData("Введите число: ");
int numberInt = int.Parse(number);
int lengthNumber = LengthNumber(numberInt);
int lengthHalfNumber = lengthNumber / 2;
char[] simbols = number.ToCharArray();
bool pal = false;
for (int i = 0; i < lengthNumber; i++)
{
    if (simbols[i] == simbols[lengthNumber - i])
    {
        pal = true;
    }
    else
    {
        pal  = false;
        break;
    }
}
if ( pal == true )
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}