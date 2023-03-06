// See https://aka.ms/new-console-template for more information

int SumNum(int num)
{
    int all_sum = 0;
    for(int i = 0; i<=num; i++) 
    all_sum += i;
    return all_sum;
}
int a = int.Parse(Console.ReadLine()!);
int res = SumNum(a);
Console.WriteLine(res);
