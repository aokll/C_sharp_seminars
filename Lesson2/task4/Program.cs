// See https://aka.ms/new-console-template for more information
void Find(int num)
{
    if(num % 7 == 0 && num % 23 == 0) Console.WriteLine("yes");
    else Console.WriteLine("No");
}
Find(int.Parse(Console.ReadLine()!));
