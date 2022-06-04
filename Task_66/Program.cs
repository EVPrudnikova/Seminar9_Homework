/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int number1 = Input("Введите первое значение: ");
int number2 = Input("Введите второе значение: ");

int result = ResultOfSum(number1, number2);
Console.WriteLine("Сумма натуральных элементов равна: " + result);

int ResultOfSum(int a, int b)
{
    if(a > b)
    {
        return a + ResultOfSum(a - 1, b);
    }
    else if (a < b)
    {
        return b + ResultOfSum(a, b - 1);
    }
    else
    {
        return a;
    }
}

int Input(string numberName)
{
    Console.Write(numberName);
    return Convert.ToInt32(Console.ReadLine());
}