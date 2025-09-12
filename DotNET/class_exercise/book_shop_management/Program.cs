namespace book_shop_management
{
    internal class Program
    {
        static void Main(string[] args)
        { // making title, author, price and quantoty variable
            public string title { get; set; }
        public string author { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
        }
        


        //lisitng books
        static List<Book> inventory = new List<Book>();
        static string customerName = " ";


        //main function for code
        static void Main()
        {
            Console.WriteLine("Book Shop Management System");
            GetCustomerName();

            while (true)
            { //giving the menu list for seller 
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Sell Book");
                Console.WriteLine("3. View Inventory");
                Console.WriteLine("4. Exit");
                Console.Write("Choose option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNewBook();
                        break;
                    case "2":
                        SellBook();
                        break;
                    case "3":
                        ViewInventory();
                        break;
                    case "4":
                        Console.WriteLine("Exiting system.");
                        return;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            }
        }


        //customer information
        static void GetCustomerName()
        {
            Console.Write("Enter customer name: ");
            customerName = Console.ReadLine();
        }


        //adding new book
        static void AddNewBook()
        {
            Console.Write("Book Title: ");
            string title = Console.ReadLine();
            Console.Write("Author: ");
            string author = Console.ReadLine();


            //taking price input
            var Price = int.Parse(Console.ReadLine());


            //taking quantity input
            int quantity = int.Parse(Console.ReadLine());


            inventory.Add(new Book { Title = title, Author = author, Price = price, Quantity = quantity });
            Console.WriteLine("Book added successfully.");
        }


        //sell book 
        static void SellBook()
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine("No books in inventory.");
                return;
            }

            Console.Write("Book Title to Sell: ");
            string title = Console.ReadLine();

            Book book = inventory.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }

        }


        static void Inventory()
        {
            if(inventory.Count == 0)
            {
                Console.WriteLine(
            }
        }





    }
}
