using E_Commerce.DataBase;
using E_Commerce.OperationByUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Menu
{
  public  class ManagerMenu
    {
        public OperationByManager OperationByManager = new OperationByManager();

      
        public void ManagerMenuAll()
        {

            bool ManagerMenuExit = false;
            while (ManagerMenuExit != true)
            {
                Console.WriteLine("\n1.\tAdd Product");
                Console.WriteLine("2.\tUpdate Product");
                Console.WriteLine("3.\tRemove Product");
                Console.WriteLine("4.\tExit");

                int selectedOption = Convert.ToInt32(Console.ReadLine());
                switch (selectedOption)
                {
                    case 1:
                        OperationByManager.AddProduct();
                        break;
                    case 2:
                        OperationByManager.UpdateProduct();
                        break;
                    case 3:
                        OperationByManager.DeleteProduct();
                        break;
                    case 4:
                        ManagerMenuExit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Selection...!!");
                        break;


                }

            }


        }
       
    }
}
