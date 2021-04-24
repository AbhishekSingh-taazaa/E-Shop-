using E_Commerce.DataBase;
using E_Commerce.Entites;
using E_Commerce.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.OperationByUser
{
   public class OperationByManager
    {
        ManagerValidations managerValidations { get; set; }
        public void Display()
        {

            ProductDataBase.Products.ForEach(x => Console.WriteLine(x.ToString()));

        }


        public void AddProduct()
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Quantity");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Price");
            int Price = Convert.ToInt32(Console.ReadLine());

            if (name.Length <= 0 || quantity <=0 || Price <= 0)
            {

                Console.WriteLine("All fields are mandatory..!");
                this.AddProduct();

            }
            else
            {
                ProductDataBase.Products.Add(new Product { Name = name, Quantity = quantity, Price = Price });
            }
        }

        public void UpdateProduct()
        {
            this.managerValidations = new ManagerValidations();

            bool UpdateProductExit = false;
            while (UpdateProductExit != true)
            {

                Console.WriteLine("1.\tUpdate Name");
                Console.WriteLine("2.\tUpdate Quantity");
                Console.WriteLine("3.\tUpdate Price");
                Console.WriteLine("4.\tExit");
                int i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {

                    case 1:
                        managerValidations.UpdateByNameValidation();
                        break;
                    case 2:
                        managerValidations.ValidQuantityUpdate();
                        break;
                    case 3:
                        managerValidations.ValidPriceUpdate();
                        break;
                    case 4:
                        UpdateProductExit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Operation..!");
                        break;
                }



            }
        }

        public void DeleteProduct()
        {

            Console.WriteLine("Enter Product Id");
            int removingid = Convert.ToInt32(Console.ReadLine());
            var prod = ProductDataBase.Products.Single(x => x.ID == removingid);
            ProductDataBase.Products.Remove(prod);

        }
    }
}
