Console.Write("Введите число N ");
string readNumber = Console.ReadLine();
int number = int.Parse(readNumber);
for (int i = -number; i <= number; i++)
{
    Console.Write($" {i} ");
}
