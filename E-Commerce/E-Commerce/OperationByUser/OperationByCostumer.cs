using E_Commerce.DataBase;
using E_Commerce.Entites;
using E_Commerce.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.OperationByUser
{
   public class OperationByCostumer
    {
       public static  List<CartProduct> ItemInCart = new List<CartProduct>();


        public UserRecords userRecords { get; set; }

        public void productList() {

            try
            { ProductDataBase.Products.ForEach(x => Console.WriteLine(x.ToString()));

                if (ProductDataBase.Products.Count() <= 0) {

                    Console.WriteLine("Product List Is Empty ..!\nLogin as Manager to Add Some Product");
                    userRecords = new UserRecords();
                    userRecords.Login();
                }

            }
            catch (Exception) {
                Console.WriteLine("Error");
            }
            this.AddProductToCart();
            Console.WriteLine("\nY to ADD more Product or N to Exit");
            string yesORno = Console.ReadLine().ToLower();
            if (yesORno == "y")
            {
                this.productList();
            }
            else {
                Console.WriteLine("Thankyou..!!");
            }
                
           
        
        
        }

        public void AddProductToCart() {
            Console.WriteLine("\n Enter product Id to choose");
            int i = Convert.ToInt32(Console.ReadLine());
            try
            {
                var selectedProduct = ProductDataBase.Products.Single(x => x.ID == i);

                Console.WriteLine("Enter Quantity");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if (quantity <=0) {
                    Console.WriteLine("Quantity Cannot be less than 0 ");
                    AddProductToCart();
                }
                if (selectedProduct.Quantity >= quantity)
       
                {
                   // selectedProduct.Quantity = selectedProduct.Quantity - quantity;
                    ItemInCart.Add(
                        new CartProduct {ID =selectedProduct.ID , Name = selectedProduct.Name,Quantity = quantity , Price = (selectedProduct.Price*quantity)}
                        );
                }
                else if (selectedProduct.Quantity == 0)
                {

                    Console.WriteLine("Sorry,Product is out of stock...!");
                }
                else
                {

                    Console.WriteLine("Avilable Quantity is not enough..!");
                }
            }
            catch (Exception) {

                Console.WriteLine("Wrong Choice...!");
                AddProductToCart();
            
            }

          
           
            

           
        }

        public void CartList()
        {
            Console.WriteLine("---__Your-Cart__---");
            this.CartDisplay();
            Console.ReadKey();
          
        }

        public void GenerateBill() {
            Console.WriteLine($"\t\tName\tQuantity\tPrice");
            int TotalAmount = 0;
            ItemInCart.ForEach(x => {
                Console.WriteLine($"\t\t{x.Name}\t{x.Quantity}\t{x.Price}");
                TotalAmount += x.Price;
                ProductDataBase.Products.ForEach(Y => {

                    if (Y.ID == x.ID)
                    {
                        Y.Quantity = Y.Quantity - x.Quantity;
                    }
                
                });
            });
            Console.WriteLine($"\tTotal Billing Amount ----{TotalAmount}");
            ItemInCart.Clear();

           
        }


        public void ClearCart() {

            Console.WriteLine("Do you really want to clear cart...?");
            Console.WriteLine("press Y for Yes or N for No");
            string warn = Console.ReadLine().ToLower();
            if (warn == "y")
            {
                try {
                    
                    ItemInCart.Clear();
                    if (ItemInCart.Count() <=0) { Console.WriteLine("Cart is Empty...!"); }
                
                } catch (Exception) { Console.WriteLine("Cart Is Empty..!"); }
            }
        
        }

        public void CartDisplay() {

          ItemInCart.ForEach(x => Console.WriteLine($"\nProduct Name :- {x.Name}\nQuantity :-{x.Quantity}\n Total Price :-{x.Price}\n\n\n"));
            if (ItemInCart.Count() <= 0) { Console.WriteLine("Cart is Empty...!"); }
        }

    }
}
