using System;
namespace CustomStack;

class Program{
    public static void Main(string[] args)
    {
        Stack<int> mystack=new Stack<int>();
        mystack.Push(1);
        mystack.Push(2);
        mystack.Push(3);
        mystack.Push(4);
        mystack.Push(5);

        System.Console.WriteLine(mystack.Peek());
        System.Console.WriteLine(mystack.Peek());
        System.Console.WriteLine(mystack.Pop());
        System.Console.WriteLine(mystack.Pop());
        System.Console.WriteLine(mystack.Pop());
        System.Console.WriteLine(mystack.Pop());
    }
}