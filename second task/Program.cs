/* Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */
Console.WriteLine("Inter three numbers: ");
double number1, number2, number3;
number1 = Convert.ToDouble(Console.ReadLine());
number2 = Convert.ToDouble(Console.ReadLine());
number3 = Convert.ToDouble(Console.ReadLine());
if(number1 > number2 && number1 > number3)
{
    Console.WriteLine(number1);
}
if(number2 > number1 && number2 > number3)
{
    Console.WriteLine(number2);
}
if(number3 > number1 && number3 > number2)
{
    Console.WriteLine(number3);
}