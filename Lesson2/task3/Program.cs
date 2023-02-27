// See https://aka.ms/new-console-template for more information
void exploer (int i1,int i2)
{
    if(i1 % i2 == 0)Console.WriteLine("кратно");
    else Console.WriteLine($"не кратно{i1%i2}");
}
exploer(16,4);
