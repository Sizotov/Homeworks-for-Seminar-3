//Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();
int number;
int a;
int b;
int sum = 0;
Console.Write("Введите пятизначное число: ");
number = int.Parse(Console.ReadLine());
if(number>9999 && number<100000)
{
for(b=number;number!=0;number=number/10)
{
a=number % 10;
sum=sum*10+a;
}
if(b==sum)
{
    Console.WriteLine($"{b} является палиндромом.");
}
else
{
    Console.WriteLine($"{b} не является палиндромом.");
}
} 
else
{
    Console.WriteLine("Это непятизначное число");
}
