int number(string message)
{
    System.Console.Write(message); 
    string readValue = Console.ReadLine(); 
    int result = int.Parse(readValue); 
    return result; 
}


int number1, number2, number3; 
number1 = number("Введите первое число ");  
number2 = number("Введите второе число "); 
if(number1 % number2 == 0) 
{
    Console.WriteLine($"Число {number1} кратно {number2}"); 
}
else
{
    number3 = number1 % number2; 
    Console.WriteLine($"Число {number1} не кратно {number2}, остаток {number3}"); 
}


