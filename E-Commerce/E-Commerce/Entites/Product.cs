using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Entites
{
   public class Product
    {
        public static int AutoIncrementProduct = 0;
        public int ID { get; }

        public string Name { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }




        public Product()
        {
            AutoIncrementProduct++;
            ID = AutoIncrementProduct;
        }
        public override string ToString()
        {

            return $"ID: {this.ID}\tName: {this.Name}\tSelling Price: {this.Price}\tQuantity: {this.Quantity}\n\n";
        }





    }
}
