using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Entites
{
   public class CartProduct
    {
       
        public int ID { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }




       
        public override string ToString()
        {

            return $"\nID: {this.ID}\tName: {this.Name}\tSelling Price: {this.Price}\tQuantity: {this.Quantity}\n\n";
        }



    }
}
