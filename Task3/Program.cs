// Напишите на вход два числа и установите является ли второе кратным первому числу
using static System.Console;

Clear();
WriteLine("Введите числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if(num2%num1==0)
{
    WriteLine($"Кратно");
}
{
    WriteLine("На ноль делить нельзя");
}
else 
{
    WriteLine($"Остаток от деления: {num2%num1}");
}

