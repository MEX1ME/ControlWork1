string[] ConvertStringToArray(string newString)
{
    char[] delimiterChars = { ' ', ',', '.', '\r', '\n' };
    string[] words = newString.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
    return words;
}

string[] FilterText(string[] text)
{
    int count = 0;
    for (int i = 0; i < text.Length; i++)
    {
        int length = text[i].Length;
        if (length <= 3)
        {
            text[count] = text[i];
            count++;
        }
    }
    Array.Resize(ref text, count);
    return text;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i != array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

string myString = @"ИТ-специалист — это представитель одной из 
более чем 500 цифровых профессий, связанных с разработкой 
программ и использованием компьютерной техники.
Глобализация сделала сферу ИТ одной из самых высокооплачиваемых: 
российским компаниям приходится конкурировать с зарубежными 
за хороших специалистов. Экономика и повседневная жизнь все больше 
переходит в «цифру», поэтому у ИТ-сферы многообещающие перспективы.";

string[] wordsArray = ConvertStringToArray(myString);
Console.WriteLine($"original array:");
PrintArray(wordsArray);
Console.WriteLine();
wordsArray = FilterText(wordsArray);
Console.WriteLine($"filtered array:");
PrintArray(wordsArray);