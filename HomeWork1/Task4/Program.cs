// Задача 4: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N. 5 -> 2, 4

int number(string message)
{
    System.Console.Write(message); 
    string readValue = Console.ReadLine(); 
    int result = int.Parse(readValue); 
    return result; 
}


int number1; 
number1 = number("Введите целое число ");  
if(number1 > 0) 
{ 
    int i = 2;
    while(i < number1)
    {
        Console.WriteLine($"Число {i} - четное");
        i = i + 2;
    }
}
else
{
    int i = 0;
    while(i > number1)
    {
        Console.WriteLine($"Число {i} - четное");
        i = i - 2;
    }
}