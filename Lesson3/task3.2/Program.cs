// See https://aka.ms/new-console-template for more information
void Quarter (int x)
{
        if(x==1)
            Console.WriteLine("x>0, y>0");
        else if(x==2)
            Console.WriteLine("x<0, y>0");
        else if(x==3)
            Console.WriteLine("x<0 y<0");
        else if(x==4)
            Console.WriteLine("x>0 y<0");
        else Console.WriteLine("error");
}
int  num_1 = int.Parse(Console.ReadLine()!);
Quarter(num_1);
