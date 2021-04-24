using E_Commerce.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Validations
{
   public class ManagerValidations
    {

        

        public void UpdateByNameValidation() {

            Console.WriteLine("Enter Product Old Name");
            string oldname = Console.ReadLine();
            Console.WriteLine("Enter New Name Of Product");
            string newname = Console.ReadLine();
            try
            {
                var product = ProductDataBase.Products.Single(x => x.Name.ToLower() == oldname);

                if (newname.Length <= 0)
                {
                    Console.WriteLine("Name Can,t be empty\n Try Again ..");
                    this.UpdateByNameValidation();
                }
                else
                {

                    product.Name = newname;
                }
            }
            catch (Exception) {

                Console.WriteLine("Product Not Found...!");
            }

        }
       public void ValidQuantityUpdate()
        {
            Console.WriteLine("Enter Name of Product");
            string productname = Console.ReadLine();
            Console.WriteLine("Enter new Quantity");
            int newQuantity = Convert.ToInt32(Console.ReadLine());
            try
            {
                var productQuantity = ProductDataBase.Products.Single(prod => prod.Name == productname);
                if (newQuantity <= 0) { Console.WriteLine("Quantity Must Be Greater than 0\n Try Again...."); ValidQuantityUpdate(); }
                else { productQuantity.Quantity = newQuantity; }
            }
            catch (Exception) { Console.WriteLine("No Product Found..!"); }

        }

       public void ValidPriceUpdate()
        {
            Console.WriteLine("Enter Name of Product");
            string productName = Console.ReadLine();
            Console.WriteLine("Enter new Price");
            int newPrice = Convert.ToInt32(Console.ReadLine());
            try
            {
                var productPrice = ProductDataBase.Products.Single(prod => prod.Name == productName);
                if (newPrice <= 0) { Console.WriteLine("Price Must be Greater than 0\n Try Again.."); ValidPriceUpdate(); }
                else productPrice.Price = newPrice;
            }
            catch (Exception) { Console.WriteLine("Product Not Found..!"); }

        }
    }
}
