using System;
using System.IO;

namespace FileHandling
{
    /*
class Program
{
    static void Main(string [] args)
    {
         //string Fpath=@"E:\prog.js";
        // File.Create(Fpath);
        string Fpath=@"E:\index.txt";
        //File.Create(Fpath);
        
         if(File.Exists(Fpath))
         {
             //Console.WriteLine("file created successfully");
            // File.WriteAllText(Fpath,"Created file By File handling in Csharp");
            
            //For multiple lines
            string [] str=
            {
                "Hello User Welcom",
                "Today is New Year",
                DateTime.Now.ToString()   
            };
            File.WriteAllLines(Fpath, str);
            string data=File.ReadAllText(Fpath);
            Console.WriteLine(data);
            
         }  
          else
         {
             Console.WriteLine("Error");
         }
         
        /*
        string dirPath=@"E:\Dotnet\csharp\demo";
        Directory.CreateDirectory(dirPath);
        if(Directory.Exists(dirPath))
         {
             Console.WriteLine("folder created successfully");
         }
         else
         {
             Console.WriteLine("Error");
        }
        
    }
}
*/

class FileStreamExample
{
    static void Main(string[] args)
    {
        string filePath = @"E:\Dotnet\csharp\demo\filestream.txt";
        using(FileStream filest=new FileStream(filePath,FileMode.Create))
        {
        if(File.Exists(filePath))
        {
            Console.WriteLine("File created successfully using FileStream.");
        }
        else
        {
            Console.WriteLine("Error in creating file.");
        }
        }

        //filest.Close(); using block automatically closes the stream 

    }
}
}