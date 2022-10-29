// See https://aka.ms/new-console-template for more information
int num1 = 4, num2 = 5, num3 = -3;
if (num1 < num2 && num1 < num3)
{
    Console.WriteLine("en kiçik eded:" + num1);
}
else if (num2 <= num3 && num2 <= num1)
{
    Console.WriteLine("en kiçik eded:" + num2);
}
else if (num3 <= num2 && num3 <= num1)
{
    Console.WriteLine("en kiçik eded:" + num3);
}

