// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int inputArray(string str)
{
    int NatNum = int.Parse(str);
    int digitCount = (int)Math.Log10(NatNum) + 1;
    int[] array = new int[digitCount];
    int index = 0;
    if(digitCount == 5) 
    {
        while(index < digitCount)
        {
            array[digitCount - index - 1] = NatNum % 10;
            NatNum = NatNum / 10;
            index++;
        }
        if(array[0] == array[4] && array[1] == array[3])
        {
            Console.WriteLine("Число является палиндромом");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом");
        }
    }
    else
    {
        Console.WriteLine("Число не пятизначное");
    }

    return 0;
}

void Main()
{
    Console.WriteLine("Введите натуральное число");

    string text = Console.ReadLine();

    inputArray(text);
    
}

Main();

