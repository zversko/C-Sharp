int number(string message)
{
    System.Console.Write(message); 
    string readValue = Console.ReadLine(); 
    int result = int.Parse(readValue); 
    return result; 
}
int num1, num2, num3; 
num1 = new Random().Next(10, 10000);
Console.WriteLine($"Случайное число {num1}");
int max = 0;

while(num1 > 0 )
{
    int a = num1 % 10;
    if (max < a) max = a;
    num1 = num1 / 10;
}

Console.WriteLine($"Число {max}");


