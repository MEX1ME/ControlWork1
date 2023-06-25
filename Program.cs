// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


//                       ----СортировкаПоДлине----

string[] ConvertStringToArray(string newString)
{
    char[] delimiterChars = { ' ', ',', '.', '\r', '\n', '\t' };
    string[] words = newString.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
    return words;
}

string[] FilterText(string[] text, int elementLength)
{
    int count = 0;
    for (int i = 0; i < text.Length; i++)
    {
        int length = text[i].Length;
        if (length <= elementLength)
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

string myString = @"Однажды весною, в час небывало жаркого заката, в Москве, 
на Патриарших прудах, появились два гражданина. Первый из них, одетый в летнюю серенькую пару, 
был маленького роста, упитан, лыс, свою приличную шляпу пирожком нес в руке, 
а на хорошо выбритом лице его помещались сверхъестественных размеров очки в черной роговой оправе. 
Второй – плечистый, рыжеватый, вихрастый молодой человек в заломленной на затылок клетчатой кепке 
– был в ковбойке, жеваных белых брюках и в черных тапочках.";

// string myString = @"Мы учим людей с нуля осваивать программирование, 
// веб-дизайн и маркетинг и другие профессии. Проводим онлайн-курсы и 
// бесплатные мастер-классы, развиваем сообщество, сотрудничаем с 
// компаниями по трудоустройству и непрерывно тестируем новые 
// методики для поднятия эффективности обучения.";



int elementLength = 3;
string[] wordsArray = ConvertStringToArray(myString);
Console.WriteLine($"original array:");
PrintArray(wordsArray);
Console.WriteLine();
wordsArray = FilterText(wordsArray, elementLength);
Console.WriteLine($"filtered array:");
PrintArray(wordsArray);