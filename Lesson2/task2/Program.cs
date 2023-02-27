// See https://aka.ms/new-console-template for more information

int TakeNum(int num)
{
    int res1 = num % 10;
    int res2 = num / 10;

    if(res1>res2){return res1;}
    else return res2;
}
int q = new Random().Next(10,100);
int result = TakeNum(q);
Console.WriteLine(q + " -> " + result);
