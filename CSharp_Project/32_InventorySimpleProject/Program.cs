using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace InventoryTracker

{
    class Inventory
    {
        public int Id;
        public string Name;
        public double Price;
        public int Quantity;
        static List<Inventory> inventory = new List<Inventory>(); //inventory is object of List<Inventory>
        
        // Adding Product
        
        public static void AddProduct()
        {
            Inventory Inver=new Inventory(); // Creating Object I

            Console.WriteLine("Enter Product Id:");
            Inver.Id=int.Parse(Console.ReadLine()); 

            Console.WriteLine("Enter Product Name:");
                        Console.WriteLine("Enter Product Names:");

            Inver.Name=Console.ReadLine();

            Console.WriteLine("Enter Product Price:");
            Inver.Price=double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Product Quantity:");
            Inver.Quantity=int.Parse(Console.ReadLine());

            inventory.Add(Inver);// Adding Object Inver to List inventory
            Console.WriteLine("Product Added Successfully!");
        }
        // Viewing Products
        public static void ViewProducts()
        {
            Console.WriteLine("Product List:");
            foreach(Inventory Inv in inventory)//Capital I for Inventory Object
            //Small i for inventory List
            {
                Console.WriteLine($"Id: {Inv.Id}| Name: {Inv.Name} | Price: {Inv.Price}| Quantity: {Inv.Quantity}");
            }
        }
        // Updating Product
        public static void UpdateProduct()
        {
            Console.WriteLine("Enter Product Id to Update");
            int id=int.Parse(Console.ReadLine());

            foreach(Inventory Inv in inventory)//Capital I for Inventory Object
            //Small i for inventory List
            {
                if(Inv.Id==id)
                {
                    Console.WriteLine("Enter New Product Name:");
                    Inv.Name=Console.ReadLine();

                    Console.WriteLine("Enter New Product Price:");
                    Inv.Price=double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter New Product Quantity:");
                    Inv.Quantity=int.Parse(Console.ReadLine());

                    Console.WriteLine("Product Updated Successfully!");
                    return;// Exit after updating
                }
            }
        }
        // Deleting Product
        static public void DeleteProduct()
        {
            Console.WriteLine("Enter Product Id to Delete");
            int id=int.Parse(Console.ReadLine());

            for(int i=0;i<inventory.Count;i++)
            {
                if(inventory[i].Id==id)
                {
                    inventory.RemoveAt(i);
                    Console.WriteLine("Product Deleted Successfully!");
                }
            }
        }
        class ApplicationException:Exception
        {
            public ApplicationException(string message):base(message)
            {

            }
        }

    }
    class Program:Inventory
    {
        
        
        public static void Main(string [] args)
        {
            Console.WriteLine("Welcome to Inventory Tracker!");
            Console.WriteLine("\n1. Add Product");
                        Console.WriteLine("\n1. Add Product");

            Console.WriteLine("2. View Products");
            Console.WriteLine("3. Update Product");
            Console.WriteLine("4. Delete Product");
            Console.WriteLine("5. Exit");

            int choice=Convert.ToInt32(Console.ReadLine());
            try{
            if(choice==1)
            {
                AddProduct();//ListObject.Add(object);
            }
            else if(choice==2)
            {
                ViewProducts(); //using foreach loop to view all products which are stored in List Object
            }
            else if(choice==3)
            {
                UpdateProduct(); //using foreach loop to find the product by id and update its details
            }
            else if(choice==4)
            {
                DeleteProduct(); //using RemoveAt() method of List to delete product by id
            }
            else if(choice==5)
            {
               Console.WriteLine("Exiting...");
            
            }
                else
                {
                    throw new ApplicationException("Invalid Choice! Please select a valid option.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: "+ex.Message);
            }
            
        }
    }
}