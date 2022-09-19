// Взять трехзначное число, вырезать из него вторую цифру и получить двухзначное

using static System.Console;

Clear();
int number=new Random().Next(100,1000);
WriteLine(number);
int a0 = number%10;
int a1 = number/100;

int result = a1*10 + a0;

WriteLine(result);

