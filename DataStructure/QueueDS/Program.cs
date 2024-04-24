using System;
namespace QueueDS;


class Program{
    public static void Main(string[] args)
    {
        CustomQueue<int> customQueue=new CustomQueue<int>();

        customQueue.Enqueue(11);
        customQueue.Enqueue(12);
        customQueue.Enqueue(13);
        customQueue.Enqueue(14);
        customQueue.Enqueue(14);

        foreach(int value in customQueue){
            System.Console.WriteLine("value " + value);
        }
        
        System.Console.WriteLine(customQueue.Peek());

        System.Console.WriteLine(customQueue.DeQueue());
        System.Console.WriteLine(customQueue.DeQueue());

    }
}