using LoginApp.Dal;

namespace LoginApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoginDBContext loginDBContext = new LoginDBContext();
            int noOfRowsAffected = 0;
            while (true)
            {
                Console.WriteLine("1.Login,2.Register,3.ForgotPassword ,4.Exit");
                int opChoice = Convert.ToInt32(Console.ReadLine());

                switch (opChoice)
                {
                    case 1:
                        Console.WriteLine("Enter username");
                        string username= Console.ReadLine();

                        Console.WriteLine("Enter Password");
                        string password= Console.ReadLine();

                        bool validate = loginDBContext.validateUser(username, password);
                        if (validate)
                        {
                            Console.WriteLine("Login successfully");
                        }
                        else
                        {
                            Console.WriteLine("Invalid username and password ...");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter username to register");
                        string registerUsername= Console.ReadLine();

                        Console.WriteLine("Enter password");
                        string registerPassword= Console.ReadLine();

                        bool register = loginDBContext.registerUser(registerUsername,registerPassword);

                        if(register)
                        {
                            Console.WriteLine("Register Sccuessfully");

                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter Username: ");
                        string forgotusername = Console.ReadLine();

                        bool checkUsername = loginDBContext.checkUsername(forgotusername);
                        if (checkUsername)
                        {
                            Console.WriteLine("Enter New Password: ");
                            string newPassword = Console.ReadLine();

                            bool updatePassword = loginDBContext.updatePassword(forgotusername, newPassword);
                            if (updatePassword)
                            {
                                Console.WriteLine("Password Updated Successfully...");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("Failed To Update Password!!!");
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Username");
                            Console.WriteLine();
                        }

                        break;

                    case 4:
                        Console.WriteLine("Thank You for visiting");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
