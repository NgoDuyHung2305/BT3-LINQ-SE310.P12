using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_to_OBJECT.Data
{
    public class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string Origin { get; set; }
        public DateTime Date { get; set; }
        public Product() { }
        public Product(string id,string name,int quantity,int price,string origin,DateTime date)
        {
            ID=id;
            Name=name;
            Quantity=quantity;
            Price=price;
            Origin=origin;
            Date=date;
        }
    }
}
