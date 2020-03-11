using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c08_Alegroso_Receipt
{
    class Cashier
    {
        public string CashierName;
        public int CashierNo;

        public Cashier()
        {
            CashierName = "";
            CashierNo = 0;
        }

        public Cashier(string CN, int CNO)
        {
            CashierName = CN;
            CashierNo = CNO;
        }

        public string GetCashierName()
        {
            return CashierName;
        }

        public int GetCashierNo()
        {
            return CashierNo;
        }

        public void SetCashierName(string CN) { CashierName = CN; }
        public void SetCashierNo(int CNO) { CashierNo = CNO; }


        public string ToString()
        {
            return "Paid for to " + GetCashierName() + " of Counter " + GetCashierNo();
        }
        
        
        /* other way 
        
          public void ToString(Orders O1, Orders O2, Orders O3)
        {
            Console.WriteLine( "Paid for to " + GetCashierName() + " of Counter " + GetCashierNo() );
            O1.ToString();
            O2.ToString();
            O3.ToString();
            Console.Write("\nTotal: ");
            Console.Write(O1.GetOrderTotal() + O2.GetOrderTotal() + O3.GetOrderTotal());
        } 
        
        */


    }
}
