// Необходимо развернуть четырехзначное число наоборот

using static System.Console;
Clear();

int number=new Random().Next(1000,10000);
WriteLine(number);

int a1 = number/1000;
int a2 = number/100-a1*10;
int a4 = number%10;
int a3 = (number%100-a4)/10;

int result = a4*1000 + a3*100 + a2*10 + a1;

WriteLine(result);
