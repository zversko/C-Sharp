﻿int number(string message)
{
    System.Console.Write(message); 
    string readValue = Console.ReadLine(); 
    int result = int.Parse(readValue); 
    return result; 
}
int number1, number2; 
number1 = number("Введите первое число ");  
number2 = number1 % 10;
Console.WriteLine($"Число {number2}"); 
