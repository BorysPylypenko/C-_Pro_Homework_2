using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Pro_Homework_2.Task_1__Money_
{
    public class Money
    {
        public int _dollars { get; set; }
        public int _cents {  get; set; }

        public Money(int Dollars, int Cents) 
        {
            _dollars = Dollars;
            _cents = Cents;
        }

        public string Display()
        {
            if (_cents == null || _cents == 0)
            {
                return ($"{_dollars} dollars ");
            }
            else if (_dollars == null || _dollars == 0)
            {
                return ($"{_cents} cents ");
            }
            else
            {
                return ($"{_dollars} dollars and {_cents} cents ");
            }
            
        }

        public double GetValue()
        {
            return _dollars + (double)_cents / 100;
        }

        public void SetValue(int Dollars, int Cents)
        {
            _dollars = Dollars;
            _cents = Cents;
        }
    }
}
