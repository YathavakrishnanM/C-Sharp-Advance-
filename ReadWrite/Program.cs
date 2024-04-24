using System;
using System.Collections.Generic;
using System.IO;
namespace ReadWrite;


class Program{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder")){
            Console.WriteLine("Creating Testfolder");
            Directory.CreateDirectory("TestFolder");
        }
        else{
            Console.WriteLine("Folder already Exists");
        }

        if(!File.Exists("TestFolder/Data.csv")){
            Console.WriteLine("File is creating....");
            File.Create("TestFolder/Data.csv");
        }else{
            Console.WriteLine("File is already exists");
        }


        List<Student> studentsList=new List<Student>();

        studentsList.Add(new Student(){Name="yathav",FatherName="mohan",Gender=Gender.Male,DOB=new DateTime(2002,07,21),TotalMark=90});
        studentsList.Add(new Student(){Name="santhosh",FatherName="Thangavel",Gender=Gender.Male,DOB=new DateTime(2002,11,02),TotalMark=90});
        studentsList.Add(new Student(){Name="krish",FatherName="magesh",Gender=Gender.Male,DOB=new DateTime(2002,05,21),TotalMark=80});
    
        WriteToCSV(studentsList);
        ReadCSV();
    }

    static void WriteToCSV(List<Student> studentsList){

        StreamWriter sw=new StreamWriter("TestFolder/Data.csv");

        foreach(Student student in studentsList){
            string line=student.Name+","+student.FatherName+","+student.Gender+","+student.DOB.ToString("dd/MM/yyyy")+","+student.TotalMark;
            sw.WriteLine(line);
        }
        sw.Close();
    }

    static void ReadCSV(){

        List<Student> newList=new List<Student>();
        StreamReader sr=new StreamReader("TestFolder/Data.csv");
        string line=sr.ReadLine();

        while(line!=null){
            string[] values=line.Split(",");

            if(values[0]!=""){
                Student student=new Student(){
                Name=values[0],
                FatherName=values[1],
                Gender=Enum.Parse<Gender>(values[2],true),
                DOB=DateTime.ParseExact(values[3],"dd/MM/yyyy",null),
                TotalMark=int.Parse(values[4])
            };

            newList.Add(student);
            }
            line=sr.ReadLine();
        }

        sr.Close();
        foreach(Student student in newList){
            Console.WriteLine("Name : "+student.Name);
             Console.WriteLine("FatherName : "+student.FatherName);
              Console.WriteLine("Gender : "+student.Gender);
               Console.WriteLine("DOB : "+student.DOB.ToString("dd/MM/yyyy"));
                Console.WriteLine("TotalMarks : "+student.TotalMark);
        }

    }
}