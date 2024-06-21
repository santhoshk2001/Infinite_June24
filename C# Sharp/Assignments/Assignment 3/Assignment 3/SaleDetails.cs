using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    using System;

    public class SaleDetails
    {
        private int salesNo;
        private int productNo;
        private double price;
        private DateTime dateOfSale;
        private int qty;
        private double totalAmount;

        public SaleDetails(int salesNo, int productNo, double price, int qty, DateTime dateOfSale)
        {
            this.salesNo = salesNo;
            this.productNo = productNo;
            this.price = price;
            this.qty = qty;
            this.dateOfSale = dateOfSale;

            CalculateTotalAmount();
        }

        private void CalculateTotalAmount()
        {
            this.totalAmount = qty * price;
        }

        public void ShowData()
        {
            Console.WriteLine($"Sales Number: {salesNo}");
            Console.WriteLine($"Product Number: {productNo}");
            Console.WriteLine($"Price per unit: {price:C}");
            Console.WriteLine($"Quantity: {qty}");
            Console.WriteLine($"Date of Sale: {dateOfSale.ToShortDateString()}");
            Console.WriteLine($"Total Amount: {totalAmount:C}");
        }

        public static void Main()
        {
            SaleDetails sale1 = new SaleDetails(1, 1718, 25.5, 5, DateTime.Today);

            sale1.ShowData();

            Console.ReadLine();
        }
    }

}
