// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int sumNatural(int first, int second)
{
    if(first > second)
    {
        return 0;
    }
return (first + sumNatural(first + 1, second));
}
System.Console.WriteLine(sumNatural(5,8));