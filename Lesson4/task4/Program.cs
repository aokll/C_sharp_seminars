// See https://aka.ms/new-console-template for more information

void Mass(int len)
{
    int[] r = new int[len];
    for(int i = 0; i<len; i++){
        r[i] = new Random().Next(2);
        Console.WriteLine();
        Console.WriteLine(r[i]);
    }
}
Mass(int.Parse(Console.ReadLine()!));
