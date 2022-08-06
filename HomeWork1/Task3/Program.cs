// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка). 4 -> Четное

int number(string message)
{
    System.Console.Write(message); 
    string readValue = Console.ReadLine(); 
    int result = int.Parse(readValue); 
    return result; 
}


int number1; 
number1 = number("Введите целое число ");  
if(number1 % 2 == 0) 
{ 
    Console.WriteLine($"Число {number1} - четное");
}
else
{
    Console.WriteLine($"Число {number1} - нечетное");
}
