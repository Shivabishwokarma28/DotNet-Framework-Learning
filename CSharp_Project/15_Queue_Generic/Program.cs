namespace GenericExample{

class QueueExample
    {
        Queue<string> items= new Queue<string>(); //FIFO: First In First Out
        void getdata()
        {
            Console.WriteLine("Before Enqueue:"+ items.Count);
            items.Enqueue("Pizza");// adds an item to the rear
             items.Enqueue("Burger");
              items.Enqueue("Kima Noodles");
               items.Enqueue("Chicken chilly momo");
            
             Console.WriteLine("After Enqueue:"+ items.Count);
            

             foreach(string i in items)
            {
               Console.WriteLine(i); 
            }
            Console.WriteLine("After Dequeue:");
            items.Dequeue(); // Dequeue Remove from front
             foreach(string i in items)
            {
               Console.WriteLine(i); 
            }

        }
        public static void Main(string[] args)
        {
            QueueExample Q1=new QueueExample();
            Q1.getdata();
            
        }
    }
    
}