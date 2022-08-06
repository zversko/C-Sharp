Console.Write("Введите число - ");
string readNumber = Console.ReadLine();
int number = int.Parse(readNumber);
if (number < 0) 
{
    int result = number * (-1);
    Console.WriteLine($"|{number}| равен {result}");
}
else
{
    Console.WriteLine($"|{number}| равен {number}");
}