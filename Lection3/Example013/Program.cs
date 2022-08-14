// Вид 1 (Ничего не принимает и ничего не возвращает)

void Method1()
{
    Console.WriteLine("Автор ...");
}

Method1();



// Вид 2 (Что то принимает и ничего не возвращает)

void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method21("Текст", 4);
Method21(count: 4, msg: "Новый текст");



// Вид 3 (Что-то возвращают, но ничего не принимают)

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);



// Вид 4 (Что-то принимают и что-то возвращают)

string Metho4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

// Замена цикла While на For

string res = Metho4(10, "AsGuard");
Console.WriteLine(res);


string Metho41(int count, string text)
{
    string result = String.Empty;

    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res2 = Metho41(10, "AsGuard");
Console.WriteLine(res2);

// Таблица умножения с использованием цикла For