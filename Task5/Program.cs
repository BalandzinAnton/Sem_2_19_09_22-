// Необходимо развернуть трехзначное число наоборот

using static System.Console;
Clear();

int number=new Random().Next(100,1000);
WriteLine(number);
int a3 = number%10;
int a1 = number/100;
int a2 = number/10-a1*10;
int result = a3*100 + a2*10 + a1;

WriteLine(result);
