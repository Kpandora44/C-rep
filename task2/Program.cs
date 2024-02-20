// который на вход принимает два числа и выводит, какое число большее, а какое меньшее.

Console.WriteLine("FirstNUM: ");
int FirstNUM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("SecondNUM: ");
int SecondNUM = Convert.ToInt32(Console.ReadLine());

if  (FirstNUM > SecondNUM)
{
    Console.WriteLine("первое число больше");
}
else if (FirstNUM < SecondNUM)
{
    Console.WriteLine("второе число больше");
}
else 
{
    Console.WriteLine("числа равны");
}


