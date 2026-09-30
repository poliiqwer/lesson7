using lesson7;
using Microsoft.Win32.SafeHandles;
var clsMethod = new lesson7.math();
while (true)
{
    Console.WriteLine("Введите число и операцию:");
    Console.WriteLine("Введите первое число:");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    double num2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите оператор (+ - / * max min % count sum factorial1/2):");
    string oper = Console.ReadLine();
    if (oper == "+")
    {

        Console.WriteLine($"Результат сложения: {clsMethod.sum(num1, num2)}");
    }
    else if (oper == "-")
    {
        Console.WriteLine($"Результат вычитания: {clsMethod.minus(num1, num2)}");
    }
    else if (oper == "/")
    {

        Console.WriteLine($"Результат деления: {clsMethod.division(num1, num2)}");
    }
    else if (oper == "*")
    {

        Console.WriteLine($"Результат умножения: {clsMethod.multiplication(num1, num2)}");
    }
    else if (oper == "%")
    {

        Console.WriteLine($"Результат нахождения процента от числа: {clsMethod.percent(num1, num2)}");
    }
    else if (oper == "factorial")
    {
        Console.WriteLine($"Результат нахождения факториала от числа : {clsMethod.factorial_num1(num1)}");

    }

    else
    {
        Console.WriteLine("Введите оператор из списка!");
    }
    if (oper == "exit")
    {
        break;
    }
}
    }

