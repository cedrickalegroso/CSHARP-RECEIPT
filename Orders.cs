using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c08_Alegroso_Receipt
{
    public class Orders : Products
    {
        public double OrderTotal;
        public double OrderOverAll;

        public Orders() : base()
        {
            OrderTotal = 0;
            OrderOverAll = 0;
        }


        public Orders(string PN, double PP, int PQ, double OT, double OV)
            : base(PN, PP, PQ)
        {
            OrderTotal = OT;
            OrderOverAll = OV;
        }

        public double GetOrderTotal()
        {
            CalcOrderTotal();
            return OrderTotal;
        }

        public double GetOrderOverAll()
        {
            CalcOrderOverAll();
            return OrderOverAll;
        }

        private void CalcOrderTotal()
        {
            OrderTotal = ProductQuantity * ProductPrice;
        }

        private void CalcOrderOverAll()
        {
            OrderOverAll = OrderOverAll + OrderOverAll;
        }

        public string ToString()
        {
            return GetProductName() + " " + GetProductPrice() + " X " + GetProductQuantity() + " " + GetOrderTotal();
        }

     

    }
}
