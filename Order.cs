using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    // enter order and display confirmation details
    public class Program
    {
        // properties
        public string productName;
        public int quantity;
        public int orderId = 0;

        // methods
        // step 1: collect order information
        public void EnterOrder()
        {
            Console.Write("Press type the name of the product you want to order. ");
            productName = Console.ReadLine();

            Console.Write("Press type the quantity of this product you would like to receive. ");
            quantity = int.Parse(Console.ReadLine());
        }

        // step 2: confirmation details
        public void ConfirmOrder()
        {
            Console.WriteLine("\nOrder placed! \nOrder summary: ");
            Console.WriteLine("Order id: " + IncreaseId().ToString()); //put something here
            Console.WriteLine("Date/time placed: " + DateTime.Now.ToString());
            Console.WriteLine("Product: " + productName);
            Console.WriteLine("Product: " + quantity);
        }

        public int IncreaseId()
        {
            orderId++;
            return orderId;
        }
    }

    // repeat Program
    public class AskForOrder
    {
        static void Main(string[] args)
        {
            Program MainProgram = new Program();
            string answer = "y";

            do
            {
                MainProgram.EnterOrder();
                MainProgram.ConfirmOrder();
                Console.Write("\nDo you want to place an order? Type y or n. ");
                answer = Console.ReadLine();
            }            

            while (answer == "y");         
        }
    }
}
