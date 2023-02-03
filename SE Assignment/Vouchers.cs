using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Assignment
{
    public class Vouchers
    {
        private string voucherId;
        private double discountAmt;
        private DateTime expiryDate;

        public string VoucherId
        {
            get { return voucherId; }
            set { voucherId = value; }
        }
        public double DiscountAmt
        {
            get { return discountAmt; }
            set { discountAmt = value; }
        }
        public DateTime ExpiryDate
        {
            get { return expiryDate; }
            set { expiryDate = value; }
        }

        public bool isValid()
        {
            if (DateTime.Now > expiryDate)
            {
                return false;
            }
        }
    }
}