// See https://aka.ms/new-console-template for more information
int TakeNum(int num)
{
    Console.WriteLine(num);
    return num % 10;
}
int res = TakeNum(new Random().Next(100,1000));
Console.WriteLine(res);
