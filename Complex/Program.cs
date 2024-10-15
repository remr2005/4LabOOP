using System.Security.Cryptography;
using System.Text;
using Complex;
public class Program
{
    public static void Main(string[] args)
    {
        Complex.Complex complex1 = new Complex.Complex(1,1);
        Complex.Complex complex2 = new Complex.Complex(2,3);
        Console.WriteLine((complex1 + complex2).ToString());
        Console.WriteLine((complex1 - complex2).ToString());
        Console.WriteLine((complex1 * complex2).ToString());
        Console.WriteLine((complex1 / complex2).ToString());
        Console.WriteLine(complex1 == complex2);
        Console.WriteLine(complex1 != complex2);
        complex1 = new Complex.Complex(2,1);
        complex2 = new Complex.Complex(3,-1);
        Console.WriteLine((complex1 * complex2).ToString());
    }
}
