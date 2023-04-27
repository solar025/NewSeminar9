// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int first, int second)
{
    if(first == 0)
    {
        return second + 1;
    }
    if((first != 0) && (second == 0))
{
    return Akkerman(first -1, 1);
}
    else return Akkerman(first - 1, Akkerman(first, second -1));
}

System.Console.WriteLine(Akkerman(1,8));