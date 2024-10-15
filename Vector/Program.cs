using System.Security.Cryptography;
using System.Text;
using Vector;

public class Program
{
    public static void Main(string[] args)
    {
        Vector3D vector1 = new Vector3D(1, 2, 3);
        Vector3D vector2 = new Vector3D(4, 5, 6);
        Vector3D vector3 = new Vector3D(4, 5, 6);
        Console.WriteLine((vector1 + vector2).ToString());
        Console.WriteLine((vector1 - vector2).ToString());
        Console.WriteLine((vector1 * vector2).ToString());
        Console.WriteLine(vector3 == vector2);
        Console.WriteLine(vector3 != vector2);
    }
}
