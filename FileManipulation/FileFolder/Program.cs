using System;
using System.IO;
namespace FileFolder;

class Program
{

    public static void Main(string[] args)
    {
        string path = @"C:\Users\YathavakrishnanMohan\OneDrive - Syncfusion\Desktop\MyFolder";
        string folderPath = path + "/Yathav";

        if (!Directory.Exists(folderPath))
        {
            Console.WriteLine("Creating folder...");
            Directory.CreateDirectory(folderPath);
        }
        else
        {
            Console.WriteLine("Folder already exists");
        }


        string filePath = path + "/myFile.text";
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Creating file...");
            File.Create(filePath);
        }
        else
        {
            System.Console.WriteLine("File already exists");
        }

        System.Console.WriteLine("Select  1. CreateFolder   2. CreateFile   3. DeleteFolder     4. DeleteFile");
        int option = int.Parse(Console.ReadLine());
        switch (option)
        {

            case 1:
                {
                    System.Console.WriteLine("Enter the folder name do you want create");
                    string folderName = Console.ReadLine();
                    string newPath = path + "/" + folderName;
                    if (!Directory.Exists(newPath))
                    {
                        Console.WriteLine("Creating folder " + folderName + "....");
                        Directory.CreateDirectory(newPath);
                    }
                    else
                    {
                        Console.WriteLine("Folder already exists");
                    }
                    break;
                }

            case 2:
                {
                    Console.WriteLine("Enter the file name do you want create");
                    string fileName = Console.ReadLine();
                    Console.WriteLine("Please enter the file extension ");
                    string extension = Console.ReadLine();
                    string newFilePath = path + "/" + fileName + "." + extension;

                    if (!File.Exists(newFilePath))
                    {
                        Console.WriteLine("Creating file " + fileName + "." + extension + "....");
                        File.Create(newFilePath);
                    }
                    else
                    {
                        Console.WriteLine("Already exists the file ");
                    }
                    break;
                }

            case 3:
                {

                    foreach (string path1 in Directory.GetDirectories(path))
                    {

                        Console.WriteLine(path1);
                    }

                    Console.WriteLine("Select the folder wish to remove");
                    string userSelect = Console.ReadLine();

                    foreach (string path1 in Directory.GetDirectories(path))
                    {

                        if (path1.Contains(userSelect))
                        {
                            Console.WriteLine("Removing folder " + path1 + "....");
                            Directory.Delete(path1);
                        }
                    }
                    break;
                }

            case 4:
                {
                    foreach (string file in Directory.GetFiles(path))
                    {
                        Console.WriteLine(file);
                    }
                    Console.WriteLine("Please select the file do you want delete with extension ");
                    string userSelectFile = Console.ReadLine();

                    foreach (string file in Directory.GetFiles(path))
                    {
                        if (file.Contains(userSelectFile))
                        {
                            Console.WriteLine("Removing file...");
                            File.Delete(file);
                        }
                    }
                    break;
                }
        }


        System.Console.WriteLine("Please enter the foldername do you want create");

        string userFolder=Console.ReadLine();
        string newPath1=path+"/"+userFolder;
        if(!Directory.Exists(newPath1)){
            System.Console.WriteLine(userFolder+" is creating....");
            Directory.CreateDirectory(newPath1);
        }
        else{
            System.Console.WriteLine("The folder is already exists ");
        }
    }
}