﻿// See https://aka.ms/new-console-template for more information
void Quarter (int x,int y)
{
    if(x==0 || y==0)
        console.WriteLine("x=0, y=0");
        else if(x>0 && y>0)
        Console.WriteLine("I");
        else if(x<0 && y>0)
        Console.WriteLine("II");
        else if(x<0 && y<0)
        Console.WriteLine("III");
        else if(x>0 && y<0)
        Console.WriteLine("IV");
}
int  num_1 = int.Parse(Console.ReadLine()!);
int  num_2 = int.Parse(Console.ReadLine()!);
Quarter(num_1,num_2);