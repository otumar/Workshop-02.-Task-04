// Напишите программу, которая принимает на вход цифру, обзначающую день недели, и проверяет, 
// является ли этот день выходным.

Console.Write("Введите число от 1 до 7: ");
string paramString = Console.ReadLine();
int Paramint = int.Parse(paramString);

if (Paramint < 1 || Paramint > 7) Console.Write("Введено неверное число.");
else
{
    if (Paramint == 6 || Paramint == 7) Console.Write("Введенное число - выходной.");
    else
    {
        Console.Write("Введенное число - будний день.");
    }
}