/* ВозвращаемыйТипДанных ИмяМетода([ТипДанных1 ИмяАргумента1, ... ])
{
 Тело Метода
 return ЗначениеСоответствующееВозвращаемомуТипуДанных;
}
*/

// Вид метода 1. Ничего не принимает и ничего не возвращает. 
void Method1()
{
    Console.WriteLine("123")
}

Method1(); // Вызов метода

// Вид метода 2. Ничего не вовзращает, но может принимать аргументы.
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Text of msg");

// 2.1 Когда нужно несколько выводов
void Method2b(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }

}
Method2b("Text of msg", 4);

// 2.2 
Method2b(count: 4, "new text");

//Вид метода 3. Что то вовзращает, но ничего не принимает.
int Method3()
{
    return DateTime.Now.Year;
}
int year Method3 ();
Console.WriteLine(year);

//Вид метода 4. Что то вовзращает и что то принимает.
string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;
    while (i < count)
    {
        result = result + text;
        i++;

    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine (res);