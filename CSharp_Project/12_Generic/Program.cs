using System;
using System.Collections.Generic; 
/*
namespace Generic_Method
{
    class Example
    {
        public static void printarr<T>( T[] arr)
        {
            foreach (T i in arr)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine($"Type of T is:{typeof(T)}");
        }
         
    }
    class Program
    {
        public static void Main(string [] args)
        {
            int [] array={22,4,55,76,39};
            string[] str={"Shiva","Luffy","Zoro","Sanji"};

            Example.printarr(array);
            Example.printarr(str);
        }
    }
   
}
 */
  // Generic Class is used to create a class that can work with any data type.
 namespace Generic_clas
{
    /*
    class User<T>//Generic Class
    {
        T data;//Generic Data Member
        public User(T value)
        {
            data = value;
        }
        public T getData()
        {
            return data;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            User <int> u1= new User<int>(55);//Generic Object
             User <string> u2= new User<string>("Shiva");  
             Console.WriteLine($"User Id is: {u1.getData()}");
             Console.WriteLine($"User Name is: {u2.getData()}");
        }
    }
    */
    //Generic Class with multiple type parameters
    /*

    class User<T1, T2>//Generic Class with multiple type parameters
    {
        T1 id;
        T2 name;
        public User(T1 Uid, T2 Uname)
        {
            id = Uid;
            name = Uname;
            
        }
        public void display()
        {
            Console.WriteLine($"User Id is: {id}");
            Console.WriteLine($"User Name is: {name}");
        }
        
        
    }
    class Program
    {
        
        public static void Main(string[] args)
        {
            User <int,string> u1=new User<int,string>(100,"Shiva");
            User <int,string> u2= new User<int, string>(101,"Luffy");
            u1.display();
            u2.display();
        }
    }
    */
    
  
    
}