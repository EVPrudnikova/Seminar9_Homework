/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

int number1 = Input("Введите значение N: ");
int number2 = 1;

Console.WriteLine(OutputFunction(number1, number2));

int OutputFunction(int a, int b)
{
    if (b == a)
    {
        return b;
    }
    Console.Write(OutputFunction(a, b + 1) + ", ");
    return b;
}

int Input(string numberName)
{
    Console.Write(numberName);
    return Convert.ToInt32(Console.ReadLine());
}
