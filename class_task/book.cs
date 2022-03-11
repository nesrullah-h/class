using System;
using System.Collections.Generic;
using System.Text;

namespace Class_and__Inheritance.Models
{
    internal class Book : Product
    {
        public string authorName;
        public int pageCount;
        public double discountPercent;

        public void getInfo()
        {
            Console.WriteLine($"AuthorName:{authorName}\nPageCount:{pageCount}\nDiscountPercent:{discountPercent}%\nproductName:{productName}\nCostPrice:{costPrice}\nSaledPrice: {saledPrice}");
        }


        public double GetDiscountedPrice()
        {
            return (salePrice - ((salePrice * discountPercent) / 100));
        }

    }
}