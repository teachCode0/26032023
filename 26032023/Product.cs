using System;
using System.Collections.Generic;
using System.Text;

namespace _26032023
{
    internal class Product
    {
        public readonly int Id;
        private double _price;
        private int _age;
        private string _name;
        private double _discountedPercent;
        public int Age
        {
            get => this._age;
            set
            {
                if (value >= 0 && value < 150)
                    this._age = value;
            }
        }
        public double Price
        {
            get
            {
                return this._price;
            }
            set
            {
                if (value >= 0)
                    this._price = value;
            }
        }

        public double DiscountedPercent
        {
            get => this._discountedPercent;
            set
            {
                if(value>=0 && value <= 100)
                {
                    this._discountedPercent = value;
                    this.DiscountedPrice = this._price * (100 - value) / 100;
                }
            }
        }

        public double DiscountedPrice { get; private set; }

        public string Name
        {
            get => this._name;
            set
            {
                if(value.Length>=1 && value.Length <= 5)
                    this._name = value;
            }
        }

        //public double GetPrice()
        //{
        //    return this._price;
        //}

        //public void SetPrice(double price)
        //{
        //    if (price >= 0)
        //    {
        //        this._price = price;
        //    }
        //}
        public void GetInfo()
        {
            Console.WriteLine($"Name : {Name} - Price : {Price} - DiscountedPercent - {DiscountedPercent} - DiscoutedPrice : {DiscountedPrice}");
        }
    }
}
