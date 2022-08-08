int number(string message)
{
    System.Console.Write(message); 
    string readValue = Console.ReadLine(); 
    int result = int.Parse(readValue); 
    return result; 
}
int number1, number2, number3; 
number1 = number("Введите число ");  
number2 = number1 % 10;
number3 = number1 / 10;

if(number3 > number2)
{
    Console.WriteLine($"Число {number3} больше, чем {number2}");
}
else
{
    Console.WriteLine($"Число {number2} больше, чем {number3}");
}

int number4 = new Random().Next(10, 100);

Console.WriteLine($"Число {number4}"); 