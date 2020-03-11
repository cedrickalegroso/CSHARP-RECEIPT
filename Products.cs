using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c08_Alegroso_Receipt
{
    public class Products
    {
        public string ProductName;
        public double ProductPrice;
        public int ProductQuantity;
     

        public Products()
        {
            ProductName = "";
            ProductPrice = 0;
            ProductQuantity = 0;
        }

        public Products(string PN, double PP, int PQ)
        {
            ProductName = PN;
            ProductPrice = PP;
            ProductQuantity = PQ;
        }

        public string GetProductName()
        {
            return ProductName;
        }

        public double GetProductPrice()
        {
            return ProductPrice;
        }

        public int GetProductQuantity()
        {
            return ProductQuantity;
        }

    


        public void SetProductName(string PN) { ProductName = PN; }
        public void SetProductPrice(double PP) { ProductPrice = PP; }
        public void SetProductQuantity(int PQ) { ProductQuantity = PQ; }


      

    }
}
