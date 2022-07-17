// Цикл For или цикл со счетчиком.

/* for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i)
}
*/

// Версия 4ого метода с использованием цикла FOR
/* string Method4(int count, string text)
{

    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;


    }
    return result;
}
*/

// Цикл в цикле. Задача - вывод таблицы умножения на экран.
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}"); // интерполяция строк 
    }
    Console.WriteLine();
}