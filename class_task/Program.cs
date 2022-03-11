using System;
using Class_and__Inheritance.Models;

namespace Class_and__Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.productName = "Love your desease";
            book1.costPrice = 15;
            book1.salePrice = 35;
            book1.saledPrice = 20;
            book1.authorName = "Valeriy Sinelnikov";
            book1.pageCount = 92;
            book1.discountPercent = 5;
            book1.getInfo();
            Console.WriteLine($"Discounted price:{book1.GetDiscountedPrice()}");
        }
    }
}
