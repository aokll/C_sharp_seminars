// See https://aka.ms/new-console-template for more information
void Kvad(int num)
{
    for(int i =1; i<=num; i++){
        Console.Write(i*i + " ,");
    }
}
int x = int.Parse(Console.ReadLine()!);
Kvad(x);
