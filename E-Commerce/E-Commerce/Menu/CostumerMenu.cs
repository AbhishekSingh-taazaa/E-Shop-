using E_Commerce.OperationByUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Menu
{
   public class CostumerMenu
    {
        OperationByCostumer operationByCostumer = new OperationByCostumer();

     

        public void CostumerMenuAll()
        {

            bool CostumerMenuExit = false;
            while (CostumerMenuExit != true)
            {

                Console.WriteLine("1.\tProducts");
                Console.WriteLine("2.\tItems in Cart");
                Console.WriteLine("3.\tGenerate Bill");
                Console.WriteLine("4.\tClear Cart");
                Console.WriteLine("5.\tExit");

                int selectedOption = Convert.ToInt32(Console.ReadLine());
                switch (selectedOption)
                {
                    case 1:
                        operationByCostumer.productList();
                        break;
                    case 2:
                        operationByCostumer.CartList();
                        break;
                    case 3:
                        operationByCostumer.GenerateBill();
                        break;
                    case 4:
                        operationByCostumer.ClearCart();
                        break;
                    case 5:
                        Console.WriteLine("Thankyou For Visit..!");
                        CostumerMenuExit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Selection...!!");
                        break;


                }

            }


        }
    }
}
