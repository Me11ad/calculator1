using System;
namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                int res;
                Console.Write("Введите первое значение: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе значение: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите оператор: ");
                string symbol = Console.ReadLine();
 
                switch (symbol)
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("Сложение: " + res);
                        break;
                    case "-":
                        res = num1 - num2;
                        Console.WriteLine("Разность: " + res);
                        break;
                    case "*":
                        res = num1 * num2;
                        Console.WriteLine("Умножение: " + res);
                        break;
                    case "/":
                        res = num1 / num2;
                        Console.WriteLine("Деление: " + res);
                        break;
                    default:
                        Console.WriteLine("Неверный оператор");
                        break;
                }
                Console.ReadLine();
                Console.Write("Хотите продолжить?(д/н):");
                value = Console.ReadLine();
            }
            while (value=="д" || value=="Д");
        }
    }
 
}

        // double a;
        // double b;
        // double result;
        // char operat;

        // Console.WriteLine("Введите первое число");
        // a = Convert.ToDouble(Console.ReadLine());

        // Console.WriteLine("Введите оператор");
        // operat = Convert.ToChar(Console.ReadLine());

        // Console.WriteLine("Введите второе число");
        // b = Convert.ToDouble(Console.ReadLine());

        // if (operat == '+'){
        //     result = a + b;
        //     Console.WriteLine("Сумма = "+ result);
        // }
        // else if (operat == '-'){
        //     result = a - b;
        //     Console.WriteLine("Разность = "+ result);
        // }
        // else if(operat == '*'){
        //     result = a * b;
        //     Console.WriteLine("Умножение = "+ result);
        // }
        // else if(operat == '/'){
        //     result = a / b;
        //     Console.WriteLine("Деление = "+ result); 
        // }
        // else{
        //     Console.WriteLine("Неизвестный оператор");
        // }
        // Console.WriteLine("Продолжить? (y/n)");
        // again = Convert.toChar(Console.ReadLine());
        // }
