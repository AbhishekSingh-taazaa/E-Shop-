using E_Commerce.Entites;
using E_Commerce.Enums;
using E_Commerce.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Records

{

   public class UserRecords
    {
        public static List<User> Users = new List<User> {
            new User{ Name ="Arpit",Password="rex",Username="Json",UserType = UserType.Manager},
              new User{ Name ="Duke",Password="1234",Username="Dane",},
                new User{ Name ="Jene",Password="4321",Username="Froster",},
                  new User{ Name ="Lucy",Password="1111",Username="Black",UserType = UserType.Manager}
            };
        public static HashSet<string> LoginRecords = new HashSet<string> {
                "Json",
                "Dane",
                 "Froster",
                  "Black",

            };

        public CostumerMenu costumerMenu { get; set; }

        public ManagerMenu   managerMenu{ get; set; }
       

        public void Login()
        {

            Console.WriteLine("Enter UserName");
            string uId = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string password = string.Empty;
            ConsoleKey key;
            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace && password.Length > 0)
                {
                    Console.Write("\b \b");
                    password = password[0..^1];
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    Console.Write("*");
                    password += keyInfo.KeyChar;
                }
            } while (key != ConsoleKey.Enter);

            try {
                var Logginguser = Users.Single(user => user.Username == uId && user.Password == password);
                if (Logginguser.UserType == UserType.Costumer)
                {

                    this.costumerMenu = new CostumerMenu();
                    costumerMenu.CostumerMenuAll();
                }
                else if (Logginguser.UserType == UserType.Manager)
                {

                    this.managerMenu = new ManagerMenu();
                    managerMenu.ManagerMenuAll();
                }
                else {
                    
                }
            
            } catch (Exception ) { 
                Console.WriteLine("Invalid UserName Or Password..!");
                Console.WriteLine("Enter  Y to Signup or X to Login Again... ");
                string option = Console.ReadLine();
                if (option.ToLower() == "y") {
                    SignupAll();
                }
                else if (option.ToLower() != "y" || option.ToLower() != "x") {

                    Login();
                }
                else if (option.ToLower() == "x") {
                    return;
                }
            }
        }

        public void Signup()
        {

            Console.WriteLine("---__Welcome New Costumer__---");

            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();

            if (name.Length <= 0 || username.Length <= 0 || password.Length <= 0)
            {

                Console.WriteLine("All Fields Are Mandatory..!");
            }
            else if (username.Length > 5 || LoginRecords.Contains(username)) { Console.WriteLine("username must be unique and range between 0 to 5"); }
            else
            {
                Users.Add(new User { Name = name, Username = username, Password = password });
                LoginRecords.Add(username);
            }

            Users.ForEach(x => Console.WriteLine(x.ToString() + "\n"));
            //foreach (KeyValuePair<string, string> kvp in LoginRecords)
            //{

            //    Console.WriteLine(kvp.Key + "  " + kvp.Value);
            //}



        }

        public void SignUpForInventoryManager() {

            Console.WriteLine("Enter Admin User Name");
            string adminusername = Console.ReadLine();

            Console.WriteLine("Enter Admin Password");
            string adminpassword = Console.ReadLine();

            if (adminusername == "admin" && adminpassword == "admin") {
                Console.WriteLine("Enter Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter UserName");
                string username = Console.ReadLine();
                Console.WriteLine("Enter Password");
                string password = Console.ReadLine();
                if (name.Length <= 0 || username.Length <= 0 || password.Length <= 0)
                {

                    Console.WriteLine("All Fields Are Mandatory..!");
                }
                else if (username.Length > 5 || LoginRecords.Contains(username)) { Console.WriteLine("username must be unique and range between 0 to 5"); }
                else
                {
                    Users.Add(new User { Name = name, Username = username, Password = password, UserType = UserType.Manager });
                    LoginRecords.Add(username);
                }
            }
            else {

                Console.WriteLine("Wrong Admin User...!!\n");
            }


        }

        public void SignupAll() {
            bool SignupAllExit = false;
            while (SignupAllExit != true) {

                Console.WriteLine("1.\tSignup for Costumer");
                Console.WriteLine("2.\tSignup for Inventory Manager\n");
                int i = Convert.ToInt32(Console.ReadLine());
                switch (i) {
                    case 1:
                        this.Signup();
                        SignupAllExit = true;
                            break;
                    case 2:
                        this.SignUpForInventoryManager();
                        SignupAllExit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Operation..!!\n");
                        break;
                }
            
            }
        
        }
    }

}
