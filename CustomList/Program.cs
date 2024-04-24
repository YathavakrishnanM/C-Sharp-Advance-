using System;
namespace CustomListPractice;

class Program{
    public static void Main(string[] args)
    {
      CustomList<int> list=new CustomList<int>();

      list.Add(10);
       list.Add(20);
        list.Add(30);
         list.Add(40);
          list.Add(50);

          CustomList<int> numbers=new CustomList<int>();

          numbers.Add(1000);
          numbers.Add(2000);

          list.AddRange(numbers);

          for(int i=0;i<list.Count;i++){
            System.Console.WriteLine(list[i]);

          }
          foreach(int num in list){
              System.Console.WriteLine(num);
          }
    }
}