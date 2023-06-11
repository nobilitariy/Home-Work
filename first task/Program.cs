/*Напишите программу, которая на вход принимает два числа и выдаёт,
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/
Console.Write("Enter two numbers: ");
double numberA, numberB;
numberA = Convert.ToDouble(Console.ReadLine());
numberB = Convert.ToDouble(Console.ReadLine());
if(numberA < numberB)
{
    Console.WriteLine($"max = {numberB}");
}
if(numberA > numberB)
{
    Console.WriteLine($"max = {numberA}");
}
if(numberA == numberB)
{
    Console.WriteLine("The numbers are equal");
}

