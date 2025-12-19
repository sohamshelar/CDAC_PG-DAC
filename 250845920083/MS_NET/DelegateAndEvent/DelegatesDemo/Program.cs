namespace DelegatesDemo
{
    public delegate void MyDelegte();

    internal class Program
    {
        static void Main(string[] args)
        {
         CMath cMath = new CMath();
            MyAddDelegate addDel = new MyAddDelegate(cMath.Add);
        }
    }
    public class CMath
    {
        public int Add(int x ,int y) 
        { 
            return x + y; 
        }

        public int square(int x)
        {
            return x * x;
        }

    public class MyClass
        {
            public void sayHello()
            {
                Console.WriteLine("Hello");
            }

            public void Greet(String name)
            {
                Console.WriteLine($"hello {name}!!");

            }
        }

    }
}
