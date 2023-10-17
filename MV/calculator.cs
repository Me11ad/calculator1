using System;
public class Calc{
    public int Sum(int x, int y){
        return x + y;
    }

}
public class Requestor{
    Calc calc;

    public Requestor(Calc calc){
        this.calc = calc;
    }

    static void Req(){
    }  
}

public class Programm{
    static void Main(string[] args){
        Calc calc = new();
        Requestor req = new(calc);
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