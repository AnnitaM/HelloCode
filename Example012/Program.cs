// метод кот ничего не принимает и ничего не возвращает
void Method1()
{
    Console.WriteLine("Author is Annita Maniri");
}
Method1(); // вызов метода

Console.WriteLine("++++++++++++");


// метод кот ничего не возвращает, может принимать какие-то аргументы
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Message");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }

}
// Method21(msg:"C#", count: 5);
Method21(count: 5, msg: "I dont understand C#");

Console.WriteLine("++++++++++++");


// метод кот что-то возвращает, ничего не принимает
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

Console.WriteLine("++++++++++++");


// метод кот что-то принимает и что-то возвращает
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;//изначально это пустая строка
    
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "gksdvhlh ");
Console.WriteLine(res);