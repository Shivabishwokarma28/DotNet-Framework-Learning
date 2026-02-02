using System;
/*
 An indexer allows an object to be indexed such as an array.
 When we define an indexer for a class, this class behaves similar to a virtual array

[access_modifier] [return_type] this[parameter_list]

{

    get { // code to return value }

    set { // code to assign value }

}
*/
namespace Indexers
{
    class Employee
    {
        private int[] Id=new int[5];
        private string[] name=new string[5];
        public int this[int index]
        {
            set
            {
                Id[index]=value;
            }
            get
            {
                return Id[index];
            }
            
        }
        
        public string this[string key]
        {
            set
            {
                name[int.Parse(key)]=value;
            }
            get
            {
                return name[int.Parse(key)];
            }
        }

        
        
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Employee e1=new Employee();
            e1[0]=2;
            e1["0"]="Ichigo";
            e1[1]=3;
            e1[2]=9;
            e1[3]=18;
            e1[4]=41;
            System.Console.WriteLine($" {e1[0]} {e1["0"]}");
            
        }
    }
}