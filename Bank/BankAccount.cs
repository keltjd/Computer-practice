using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    class BankAccount
    {
        public BankAccount()
        {
            _count += 1;
        }
        public void Remove_from_bill(decimal money)
        {
            this._money -= money;
        }
        public void Add_on_bill(decimal money)
        {
            this._money += money;
        }
        public decimal GetMoneys()
        {
            return this._money;
        }

        public decimal GetCount()
        {
            return _count;
        }
        public override string ToString()
        {
            return $"{_count} {this._money}";
        }
        private decimal _money;
        static int _count = 0;

    }
}
