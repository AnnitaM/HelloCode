string Method4(int count, string text)
{
    string result = String.Empty;//изначально это пустая строка

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    
    return result;
}

string res = Method4(7, "gksdvhlh ");
Console.WriteLine(res);

Console.WriteLine( );
Console.WriteLine("+++++++++++++++++++");
Console.WriteLine( );

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j < 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine( );
}