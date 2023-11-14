using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
namespace calculator
{
    class Program
    {   
        delegate void Operation1(int num1, int num2);
        delegate void Operation2(int num1, int num2);
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

                Operation1 operation = Add;
                int result = operation();
                Console.WriteLine(result);

                operation = Minus;
                result = operation();
                Console.WriteLine(result);

                int Add(int num1, int num2) => num1 + num2;

                int Minus(int num1, int num2) => num1 - num2;

                class Add{
                        res = num1 + num2;
                        Console.WriteLine("Сложение: " + res);
                    }   
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
