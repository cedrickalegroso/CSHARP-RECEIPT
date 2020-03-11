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

    }
}
