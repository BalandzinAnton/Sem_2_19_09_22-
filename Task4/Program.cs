// Программа принимает на вход два числа и установите является ли одно число квадратом другого
using static System.Console;

Clear();
WriteLine("Введите числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2)
{
   
    WriteLine($"Число {num1} равно числу {num2}");
    return;
}
if (num1 == 0 || num2 == 0)
{
   
    WriteLine($"Выберите отличные от нуля значения");
    return;
}
if (num1>num2)
{
    if (num1 == num2*num2)
    {
        WriteLine($"Число {num1} является квадратом {num2}");
    }
    else
    {
        WriteLine($"Число {num1} НЕ является квадратом {num2}");
    }
    return;
}
if (num2>num1)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
    if (num1 == num2*num2)
    {
        WriteLine($"Число {num1} является квадратом {num2}");
    }
    else
    {
        WriteLine($"Число {num1} НЕ является квадратом {num2}");
    }
}
