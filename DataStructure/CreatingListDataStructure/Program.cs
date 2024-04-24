using System;
namespace CreatingListDataStructure;

class Program{
    public static void Main(string[] args)
    {
        CustomList<int> numberList=new CustomList<int>();
        
        numberList.Add(10);
        numberList.Add(20);
        numberList.Add(30);
        numberList.Add(40);

        CustomList<int> numbers=new CustomList<int>();
       

       numbers.Add(60);
       numbers.Add(70);

       numberList.AddRange(numbers);
       
       
       for(int i=0;i<numberList.Capacity;i++){
        System.Console.WriteLine(numberList[i]);
       }
    }

      
}