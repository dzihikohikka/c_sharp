// изменить в тексте пробелы на _ с на С к на К

string text1 = "замени пожалуйста нужные буквы"
            + " в этом недлинном тексте";

string Replace(string text, char oldVal, char newVal)
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldVal) result = result + $"{newVal}";
        else result = result +$"{text[i]}";
    }
    return result;
}

string newText = Replace(text1, 'к', 'К');
Console.WriteLine(newText);