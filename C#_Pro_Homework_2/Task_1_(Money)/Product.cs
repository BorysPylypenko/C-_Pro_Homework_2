using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Pro_Homework_2.Task_1__Money_
{
    public class Product
    {
        public Money _price {  get; set; }
        public string? _name { get; set; }

        public Product(Money Price, string Name) 
        {
            _name = Name;
            _price = Price;
        }

        public void ReducePrice (Money discont)
        {
            if (discont.GetValue() > _price.GetValue())
            {
                Console.WriteLine("Discount more than product price");
            }
            else
            {
                _price.SetValue(_price._dollars - discont._dollars, _price._cents - discont._cents);
                
                if (_price._cents < 0)
                {
                    int dollarsCorrection = (-_price._cents - 1) / 100 + 1;
                    _price.SetValue(_price._dollars - dollarsCorrection, _price._cents + dollarsCorrection * 100);
                }
                else if (_price._dollars <= 0)
                {
                    _price.SetValue(0, _price._cents);
                }
                Console.WriteLine($"Product price reduce by {discont.GetValue()} dollars");
            }
        }
        public void DisplayProduct()
        {
            Console.WriteLine($"Product name: {_name}");
            Console.WriteLine($"Product price: {_price.Display()}");
        }
    }
}
