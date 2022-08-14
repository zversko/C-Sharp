// Дан текст. В тексте нужно все пробелы заменить черточками, 
// маленькие буквы "к" заменить большими "К", а большие "С" заменить маленькими "c"

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы Вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] будет "r"

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
string newText2 = Replace(newText, 'к', 'К');
Console.WriteLine(newText2);
Console.WriteLine();
string newText3 = Replace(newText2, 'с', 'С');
Console.WriteLine(newText3);
Console.WriteLine();