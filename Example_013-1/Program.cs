/*
Дан текст. В тексте нужно все пробелы заменить черточками,
маленькие буквы “к” заменить большими “К”, а большие “С” заменить
маленькими “с”.

— Я думаю, — сказал князь, улыбаясь, — что,
ежели бы вас послали вместо нашего милого
Винценгероде, вы бы взяли приступом согласие
прусского короля. Вы так красноречивы. Вы
дадите мне чаю?
*/
string text = "Beverly "
+ "Storefronts of the beauty, yeah "
+ "Pictures of the rich life "
+ "Gimme the date tonight "
+ "Yeah ";

// string s = "qwerty
//             012
// s[3] = r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'e', 'E');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'o', '0');
Console.WriteLine(newText);
Console.WriteLine();