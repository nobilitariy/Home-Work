Console.Write("Enter number: ");
double number = Convert.ToDouble(Console.ReadLine());
if(number > 0)
{
    for(i = 2, i <= number, i += 2)
    {
        Console.WriteLine(i);
    }
}
else if(number < 0)
{
    for(i = -2, i >= number, i -= 2)
    {
        Console.WriteLine(i);
    }
}
esle 
{
    Console.WriteLine("Enter a number other than zero");
}
     
