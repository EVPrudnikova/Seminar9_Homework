/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9  */

int m = Input("m");
int n = Input("n");

int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Ackermann(m - 1, 1);
    else if (m > 0 && n > 0)
        return Ackermann(m - 1, Ackermann(m, n - 1));
    return Ackermann(m, n);
}

if (m >= 0 && n >= 0)
{
    Console.WriteLine($"Результат: {Ackermann(m, n)}");
}
else
{
    Console.WriteLine("Функция не рабочая");
}

int Input(string numberName)
{
    Console.Write($"Введите значение для {numberName}: ");
    return Convert.ToInt32(Console.ReadLine());
}
