Console.Write("Enter number: ");
double number = Convert.ToDouble(Console.ReadLine());
double i = 0;
if(number > 0)
{
    for(i = 2; i <= number; i += 2)
    {
        Console.WriteLine(i);
    }
}
else if(number < 0)
{
    for(i = -2; i >= number; i -= 2)
    {
        Console.WriteLine(i);
    }
}
else
{
    Console.WriteLine("Enter a number other than zero");
}
     
