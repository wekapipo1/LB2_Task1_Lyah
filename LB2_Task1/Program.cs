using System;

public class Numbers
{
    int a, b; //поля
    public int A //Властивість для привласнення значення полю а
    {
        set
        {
            if (value > 0) a = value;
            else Console.WriteLine("Перше число не може бути вiд'ємним");
        }
    }
    public int B //Властивість для привласнення значення полю b
    {
        set
        {
            if (value > 0) b = value;
            else Console.WriteLine("Друге число не може бути вiд'ємним");
        }
    }
    public bool Correct() //Метод, який перевіряє існування натуральних чисел
    {
        bool p = false;
        if( a > 0 && b > 0) p= true;
        return p;
    }
    public int Nod() //Метод для знаходження НСД
    {
        int a1 = a;
        int b1 = b;
        while (b1 != 0)
        {
            int num = b1;
            b1 = a1 % b1;
            a1 = num;
        }
        return a1;
    }
    public int Nok() //Метод для знаходження НСК
    {
        int nsd = Nod();
        int nsk = (a * b) / nsd;
        return nsk;
    }
    public void Print() //Метод, який виводить на екран поля
    {
        Console.WriteLine($"a = {a} b = {b} ");
    }
}
class Program
{
    static void Main(string[] args)
    {
        int a, b;
        try
        {
            //Просимо користувача ввести два натуральних числа
            Console.WriteLine("Введiть два натуральних числа");
            Console.Write("a = "); a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = "); b = Convert.ToInt32(Console.ReadLine());
            //створення об'єкту з 0 полями
            Numbers n = new Numbers();
            //привласнення значень полям за допомогою властивостей
            n.A = a; n.B = b;
            //вивод на екран значень полів
            n.Print();
            //перевірка існування об'єкта
            if (n.Correct()) //об'єкт існує
            {
                //Застосування методів
                int nsd = n.Nod();
                int nsk = n.Nok();
                //виводимо результат
                Console.WriteLine($"НСД = {nsd} НСК = {nsk}");
            }
            //об'єкт не існує
            else Console.WriteLine("Числа не є натуральними");
        }
        catch
        {
            //інші можливі виключення
            Console.WriteLine("Помилка!!! Введiть натуральне число");
        }
        Console.ReadKey();
    }
}
