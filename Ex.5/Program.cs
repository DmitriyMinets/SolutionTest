namespace Ex._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass derivedClass = new DerivedClass("Alex", "Pow", 32);
            derivedClass.ShowField();

            Console.WriteLine(new string('-', 50));

            BaseClass derivedClassTwo = new DerivedClassTwo("Dima", "Minets", 26, 466742);
            derivedClassTwo.ShowField();
        }
    }
}