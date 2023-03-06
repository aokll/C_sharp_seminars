// See https://aka.ms/new-console-template for more information

int SumNum(int num)
{
    int k = 0;
    for(int i = 1; num > 0; i++){
        num = num/10;
        k=i;
    }
    return k;
}
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNum(a));
