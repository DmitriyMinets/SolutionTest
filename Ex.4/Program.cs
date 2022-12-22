namespace Ex._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack myStack = new MyStack();

            myStack.Push(4);
            myStack.Push(5);
            Console.WriteLine(myStack.Pop());
        }
    }
}