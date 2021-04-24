using E_Commerce.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Authentication
{
  public  class MainMenu
    {
       public UserRecords userRecords = new UserRecords();

       
        public void Menu()
        {
            bool EXITApp = false;

            while (EXITApp != true)
            {

                Console.WriteLine("-----___WELCOME TO E-Shop___------");
                Console.WriteLine("1.\t Login");
                Console.WriteLine("2.\t Signup ");
                Console.WriteLine("3.\t Exit");

                int selectedOption = Convert.ToInt32(Console.ReadLine());

                switch (selectedOption)
                {

                    case 1:
                        Console.WriteLine("---___Login___---");                       
                        userRecords.Login();                      
                        //Console.Clear();
                      //  EXITApp = true;
                     
                        break;
                    case 2:
                        Console.WriteLine("---___SignUp___---");
                        userRecords.SignupAll();
                       // Console.Clear();
                       // EXITApp = true;
                       

                        break;
                    case 3:
                        Console.WriteLine("Thankyou For Visit..!!\nExiting...!!");
                        EXITApp = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }
            }

        }

    }
}
