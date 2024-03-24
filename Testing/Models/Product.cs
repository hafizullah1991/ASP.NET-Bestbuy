using System.Collections;
using System.Collections.Generic;
using Testing.Models;

namespace Testing
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int CategoryID {  get; set; }
        public  bool OnSale {  get; set; }
        public int StockLevel {  get; set; }
        public IEnumerable<Category> Categories { get; set;}



    }
}
