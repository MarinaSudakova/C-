// Вид 1 - не принимают, не возвращают
void Method1()
{
    Console.WriteLine("Author Marina Sudakova");
}
//Method1();

// Вид 2 - принимает, не возвращает
void Method2 (string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст для печати");

void Method21 (string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i += 1;
    }
}
//Method21 (msg: "Текст для печати", count: 3);

// Вид 3 - возвращают, но не принимают
int Method3 ()
{
    return DateTime.Now.Year;
}
// int year = Method3();
// Console.WriteLine(year);

//Вид 4 - принимает и возвращает
string Method4(int count, string text)
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

string res = Method4(10, "Бося");
Console.Write(res);
