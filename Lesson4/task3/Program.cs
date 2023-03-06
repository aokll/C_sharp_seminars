// See https://aka.ms/new-console-template for more information

int ProNum (int num)
{
    int k = 1;
    for(int i = 1; i <= num; i++){
        k = k*i;
    }
    return k;
}
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine(ProNum(a));
