
﻿using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
namespace book_shop_management
{
    internal class program
    {
        static string title, author, sold_title, customer_name;
        static float price;
        static int quantity, sold_quantity;
        //main function start here
        static void Main(String[] args)
        {
            int choice = 0;
            while(choice < 6)
            {
                Console.WriteLine("BOOK SHOP LIST");
                Console.WriteLine("1.add book");
                Console.WriteLine("2.sell book");
                Console.WriteLine("3.view book");
                Console.WriteLine("4.view sales");
                Console.WriteLine("5.exit");
                Console.WriteLine("choose option:");
                choice = Convert.ToInt32(Console.ReadLine());


                //applying switch statement for choices
                switch (choice)
                {
                    case (1):
                        add_book();
                        Console.WriteLine();
                        break;
                    case (2):
                        sell_book();
                        Console.WriteLine();
                        break;
                    case (3):
                        printReport(true, title, author,price.ToString(),quantity.ToString());
                        Console.WriteLine();
                        break;
                    case (4):
                        printReport(false, customer_name, sold_title, sold_quantity.ToString(), (price * sold_quantity).ToString());
                        Console.WriteLine();
                        break;
                    case (5):
                        Console.WriteLine("EXIT");
                        break;
                    default:
                        Console.WriteLine("CHOOSE CHOICE");
                        break ;

                }

            }
        }// main file ends


        //adding book
        static void add_book()
        {
            Console.Write("BOOK TITLE: ");//
            title = Console.ReadLine();
            Console.Write("AUTHOR NAME: ");
            author = Console.ReadLine();
            Console.Write("PRICE: ");
            price = Convert.ToInt32(Console.ReadLine());
            Console.Write("QUANTITY: ");
            quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("BOOK ADDED IN SHOP");
        }

        //selling book
        static void sell_book()
        {
            Console.Write("BOOK TITLE: ");//
            title = Console.ReadLine();


            Console.Write("QUANTITY: ");
            sold_quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("CUSTOMER NAME: ");
            customer_name = Console.ReadLine();

            
                if(sold_quantity <= quantity)
                {
                    Console.WriteLine($"sold {sold_quantity} OF {sold_title} to {customer_name}");
                    quantity -= sold_quantity;
                }

                else
                {
                    Console.WriteLine($"Cannot sell as only{quantity} books are available");

                }
            

        }


        //Report

        static void printReport(bool book_report, string first_r1, string second_r1,string third_r1,string fourth_r1)
        {
            if(book_report)
            {
                Console.WriteLine("BOOK INVENTORY");
                Console.WriteLine($"Title \t\t\t\t Author \t\t\t price \t\t\t quantity");
                Console.WriteLine($"{first_r1} \t\t\t\t {second_r1} \t\t\t\t {third_r1}\t\t\t\t{fourth_r1}");
            }
            else
            {
                Console.WriteLine(" SALE REPORT");
                Console.WriteLine($"customer name \t\t\t\t book \t\t\t\t quantity purchase \t\t\t\t amount");
                Console.WriteLine($"{first_r1} \t\t\t {second_r1} \t\t\t {third_r1} \t\t\t {fourth_r1}");
                Console.WriteLine($"Total amount spend: ${fourth_r1}");
            }
        }


    }
}
























//namespace book_shop_management
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        { // making title, author, price and quantoty variable
//            public string title { get; set; }
//        public string author { get; set; }
//        public decimal price { get; set; }
//        public int quantity { get; set; }
//        }
        


//        //lisitng books
//        static List<Book> inventory = new List<Book>();
//        static string customerName = " ";


//        //main function for code
//        static void Main()
//        {
//            Console.WriteLine("Book Shop Management System");
//            GetCustomerName();

//            while (true)
//            { //giving the menu list for seller 
//                Console.WriteLine("\nMenu:");
//                Console.WriteLine("1. Add Book");
//                Console.WriteLine("2. Sell Book");
//                Console.WriteLine("3. View Inventory");
//                Console.WriteLine("4. Exit");
//                Console.Write("Choose option: ");
//                string choice = Console.ReadLine();

//                switch (choice)
//                {
//                    case "1":
//                        AddNewBook();
//                        break;
//                    case "2":
//                        SellBook();
//                        break;
//                    case "3":
//                        ViewInventory();
//                        break;
//                    case "4":
//                        Console.WriteLine("Exiting system.");
//                        return;
//                    default:
//                        Console.WriteLine("Invalid option!");
//                        break;
//                }
//            }
//        }


//        //customer information
//        static void GetCustomerName()
//        {
//            Console.Write("Enter customer name: ");
//            customerName = Console.ReadLine();
//        }


//        //adding new book
//        static void AddNewBook()
//        {
//            Console.Write("Book Title: ");
//            string title = Console.ReadLine();
//            Console.Write("Author: ");
//            string author = Console.ReadLine();


//            //taking price input
//            var Price = int.Parse(Console.ReadLine());


//            //taking quantity input
//            int quantity = int.Parse(Console.ReadLine());


//            inventory.Add(new Book { Title = title, Author = author, Price = price, Quantity = quantity });
//            Console.WriteLine("Book added successfully.");
//        }


//        //sell book 
//        static void SellBook()
//        {
//            if (inventory.Count == 0)
//            {
//                Console.WriteLine("No books in inventory.");
//                return;
//            }

//            Console.Write("Book Title to Sell: ");
//            string title = Console.ReadLine();

//            Book book = inventory.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
//            if (book == null)
//            {
//                Console.WriteLine("Book not found.");
//                return;
//            }

//        }


//        static void Inventory()
//        {
//            if(inventory.Count == 0)
//            {
//                Console.WriteLine(
//            }
//        }





//    }
//}


>>>>>>> 448ee05 (book shop managment 12th september)
