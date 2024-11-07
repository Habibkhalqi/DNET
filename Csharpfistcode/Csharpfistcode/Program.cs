using System.Diagnostics.CodeAnalysis;

void line()
{
    Console.WriteLine("--------------------------------------");
}
Console.WriteLine("<---------Calculator--------->\n");
line();
string i;
do
{
    int valueOne;
    int valueTwo;
    Console.Write("Enter ValueOne:");
    valueOne = int.Parse(Console.ReadLine());
    Console.Write("Enter ValueTwo:");
    valueTwo = int.Parse(Console.ReadLine());
    line();
    Console.WriteLine("Enter Your Choice:\n1:ADD\n2:SUB\n3:MUL\n4:D DIVID");
    line();
    int choice = int.Parse(Console.ReadLine());
    line();
    
    if (choice == 1)
    {
        int sum = valueOne + valueTwo;
        Console.WriteLine("Sum Of Two Number Is:" + sum);
    }
    else if (choice == 2)
    {
        int sub = valueOne - valueTwo;
        Console.WriteLine("Sum Of Two Number Is:" + sub);
    }
    else if (choice == 3)
    {
        int mul = valueOne * valueTwo;
        Console.WriteLine("Sum Of Two Number Is:" + mul);
    }
    else if (choice == 4)
    {
        int divid = valueOne / valueTwo;
        Console.WriteLine("Sum Of Two Number Is:" + divid);
    }
    Console.WriteLine("Do You Want To Continue Y/N");
    i= Console.ReadLine();
}
while(i=="Y" || i=="y");
Console.WriteLine("Thanks for Using Me");
Console.ReadLine();
