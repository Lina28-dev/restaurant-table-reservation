using System;

/*
 * 1. Validar si es usuario existente o si se debe registrar, y generar un sistema de resitro o login
 * 2. el programa debe ser capaz de darle la bienvenida a un usuario existente si en efecto existe
 * 3. el programa debe repetirse hasta que se registren las 10 personas
 */ 
namespace Restaurant10TableReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] UserNames = new string[10]{"Mike", "", "", "", "", "", "", "", "", ""};
            int arrayCurrentIndex = 1;
            bool userType;

            Console.WriteLine("Welcome to the best restaurant in the world!");
            while(true)
            {
                if(arrayCurrentIndex == 10)
                {
                    Console.WriteLine("The restaurant is full, try again next year");
                    Environment.Exit(0);
                }
                Console.WriteLine("Are you a register user? write true, or write false to register");
                userType = Convert.ToBoolean(Console.ReadLine());
                if (userType == true)
                {
                    Console.WriteLine("Hello, you are a registered user, please enter your exact user name");
                    string userToSearch = Console.ReadLine();
                    Console.WriteLine("The user you searched is  {0}", userToSearch);
                    int index = Array.IndexOf(UserNames, userToSearch);
                    if (index == -1) 
                    {
                        Console.WriteLine("User not found, try again or register");
                    }
                    else
                    {
                        Console.WriteLine("Welcome {0}, it's a pleasure to give you food", UserNames[index]);
                    }
                }
                else if (userType == false)
                {
                    Console.WriteLine("Please write and remember your User Name");
                    UserNames[arrayCurrentIndez] = Console.ReadLine();
                    Console.WriteLine("Your user has been saved successfully\n" +
                        "Your User Name is> {0}", UserNames[arrayCurrentIndex]);
                    arrayCurrentIndex++;
            }
        }
    }
}
