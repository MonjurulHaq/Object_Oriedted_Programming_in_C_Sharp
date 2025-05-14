using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass d1 = new DerivedClass(1, 2, 3, 4, 5);
            d1.a = 4;
            d1.b = 7;
            d1.x = 9;   

            d1.changeBaseValues();

            Console.WriteLine($"{d1.a} {d1.b} {d1.x}");

            int sum = d1.addNumbers(6,7);
            Console.WriteLine($"Summation: {sum}");
        }
    }
}

class BaseClass{
    public int x;
    protected int y, z;

    public BaseClass(int x, int y, int z){
        this.x = x;
        this.y = y;
        this.z = z;
        Console.WriteLine("Invoking Base Class Constructor");
    }

    public int addNumbers(int p, int q){
        return p+q;
    }


}

class DerivedClass: BaseClass{
    public int a,b;

    public DerivedClass(int a, int b, int x, int y, int z): base(x,y,z){
        this.a = a;
        this.b = b;
        Console.WriteLine("Invoking Derived Class Constructor");
    } 

    public void changeBaseValues(){
            y = 10;
            z = 10;
            Console.WriteLine(y + " " + z);
        }
}