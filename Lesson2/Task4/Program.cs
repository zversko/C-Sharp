int number(string message)
{
    System.Console.Write(message); 
    string readValue = Console.ReadLine(); 
    int result = int.Parse(readValue); 
    return result; 
}


int number1, number2, number3; 
number1 = number("Введите число ");
number2 = number("Введите первое число для деления ");
number3 = number("Введите второе число для деления ");

if(number1 % number2 == 0 && number1 % number3 == 0) 
{
    
    Console.WriteLine($"Число {number1} кратно {number2} и {number3}"); 
}
else
{
    Console.WriteLine($"Число {number1} не кратно одновременно {number2} и {number3}"); 
}

