// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее. a = 5; b = 7 -> max = 7, min = 5

int number(string message)
{
    System.Console.Write(message); 
    string readValue = Console.ReadLine(); 
    int result = int.Parse(readValue); 
    return result; 
}


int number1, number2; 
number1 = number("Введите первое число ");  
number2 = number("Введите второе число "); 
if(number1 > number2) Console.WriteLine($"Число {number1} > {number2}"); 
if(number2 > number1) Console.WriteLine($"Число {number2} > {number1}"); 
if(number1 == number2) Console.WriteLine($"Числа равны"); 
