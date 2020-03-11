using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c08_Alegroso_Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
            Cashier C1 = new Cashier();
            Products P1 = new Products();

            Orders O1 = new Orders();
            Orders O2 = new Orders();
            Orders O3 = new Orders();


            // Cashier starts //

            Console.Write("Enter the Cashier: ");
            C1.SetCashierName(Console.ReadLine());
            Console.Write("Enter counter number: ");
            C1.SetCashierNo(int.Parse(Console.ReadLine()));

            // Cashier ends //

            Console.WriteLine();

            // Order starts //

            // Order 1 //
            Console.Write("Enter Item 1 Name: ");
            O1.SetProductName(Console.ReadLine());
            Console.Write("Enter price: ");
            O1.SetProductPrice(double.Parse(Console.ReadLine()));
            Console.Write("Enter Quantity: ");
            O1.SetProductQuantity(int.Parse(Console.ReadLine()));

            Console.WriteLine();

            // Order 2 //
            Console.Write("Enter Item 2 Name: ");
            O2.SetProductName(Console.ReadLine());
            Console.Write("Enter price: ");
            O2.SetProductPrice(double.Parse(Console.ReadLine()));
            Console.Write("Enter Quantity: ");
            O2.SetProductQuantity(int.Parse(Console.ReadLine()));

            Console.WriteLine();

            // Order 3 //
            Console.Write("Enter Item 3 Name: ");
            O3.SetProductName(Console.ReadLine());
            Console.Write("Enter price: ");
            O3.SetProductPrice(double.Parse(Console.ReadLine()));
            Console.Write("Enter Quantity: ");
            O3.SetProductQuantity(int.Parse(Console.ReadLine()));

            // Order ends //

            Console.WriteLine();

            // Output Starts //

            Console.Write("==================================");
            Console.WriteLine();
            Console.Write(C1.ToString());
            Console.WriteLine();
            Console.Write(O1.ToString());
            Console.WriteLine();
            Console.Write(O2.ToString());
            Console.WriteLine();
            Console.Write(O3.ToString());
            Console.WriteLine();
            Console.WriteLine();

            double Overall = O1.GetOrderTotal() + O2.GetOrderTotal() + O3.GetOrderTotal();
            Console.Write(Overall);
            Console.WriteLine();
            Console.Write("==================================");


            Console.WriteLine();
            
            
            /* Other Way
            
             Console.Write("==================================");
            Console.WriteLine();
            C1.ToString(O1, O2, O3);
            Console.WriteLine(); 
            Console.Write("==================================");
            
            */

            // Output Ends //

        }
    }
}
