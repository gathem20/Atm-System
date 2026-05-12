// Atm System 
using System.Formats.Asn1;

int passwordCard = 5555;
double balanceAccount = 20000;
double balanceAtm = 900000;
Console.WriteLine("Please Enter Your password");
int password = Convert.ToInt32(Console.ReadLine());


// withdraw function
void withdrawAtm()
{
    Console.WriteLine("Please Enter Your Withdraw");
    double withdraw = Convert.ToDouble(Console.ReadLine());
    if (withdraw < balanceAtm && withdraw < balanceAccount)
    {
        Console.WriteLine("Take your Money And Take Your Card");
        balanceAtm -= withdraw;
        balanceAccount -= withdraw;
        Console.WriteLine("Your Balance Is " + balanceAccount);
    }
    else
    {
        Console.WriteLine("Your Money Not Enough");

    }
    return;
}

// deposit function
void depositAtm()
{
    Console.WriteLine("Please Enter Your Deposit");
    double depositUser = Convert.ToDouble(Console.ReadLine());
    balanceAtm += depositUser;
    balanceAccount += depositUser;
    Console.WriteLine("Your Balance Is " + balanceAccount);
    return;
}


//balance funtion

void balance()
{
    Console.WriteLine("Your Balance Is " + balanceAccount);
    Console.WriteLine("Do You Want To Another Operation?  Yes Or No");
    string choice = Console.ReadLine();
    if (choice == "Yes")
    {
        Console.WriteLine("Withdraw"); //ok
        Console.WriteLine("Deposit"); //procssing
        Console.WriteLine("Balance"); //ok
        Console.WriteLine("Exit"); // procssing
        if (choice == "Withdraw")
        {
            withdrawAtm();
            Console.ReadKey();
            Console.WriteLine("Thank You For Use Our Service");
        }

        //deposit
        if (choice == "Deposit")
        {
            depositAtm();
            Console.ReadKey();
            Console.WriteLine("Thank You For Use Our Service");
        }

        //exit 
        if (choice == "Exit")
        {
            Console.WriteLine("Take Your Card");
            Console.ReadKey();
            Console.WriteLine("Thank You For Use Our Service");
        }
    }
    else if (choice == "No")
    {
        Console.ReadKey();
        Console.WriteLine("Thank You For Use Our Service");
    }
    return;
}

//check password
if (password == passwordCard)
{
    Console.WriteLine("Please Choose Your Option");

    Console.WriteLine("Withdraw"); //ok
    Console.WriteLine("Deposit"); //procssing
    Console.WriteLine("Balance"); //ok
    Console.WriteLine("Exit"); // procssing
    string choice = Console.ReadLine();
    // withdraw

    if (choice == "Withdraw")
    {
        withdrawAtm();
        Console.ReadKey();
        Console.WriteLine("Thank You For Use Our Service");
    }


    //deposit
    if (choice == "Deposit")
    {
        depositAtm();
        Console.ReadKey();
        Console.WriteLine("Thank You For Use Our Service");
    }

    //balance
    if (choice == "Balance")
    {
        balance();
        Console.ReadKey();
        Console.WriteLine("Thank You For Use Our Service");
    }
    //exit
    if (choice == "Exit")
    {
        Console.WriteLine("Take Your Card");
        Console.ReadKey();
        Console.WriteLine("Thank You For Use Our Service");
    }
}
else
{
    Console.WriteLine("Wrong Password");
    for (int i = 1; i <= 3; i++)
    {
        Console.WriteLine("Please Try Again");
        password = Convert.ToInt32(Console.ReadLine());
        if (password == passwordCard)
        {
            Console.WriteLine("Please Choose Your Option");
            Console.WriteLine("Withdraw"); //ok
            Console.WriteLine("Deposit"); //procssing
            Console.WriteLine("Balance"); //ok
            Console.WriteLine("Exit"); // procssing
            string choice = Console.ReadLine();
            // withdraw
            if (choice == "Withdraw")
            {
                withdrawAtm();
                Console.ReadKey();
                Console.WriteLine("Thank You For Use Our Service");
                return;
            }

            //deposit   
            if (choice == "Deposit")
            {
                depositAtm();
                Console.ReadKey();
                Console.WriteLine("Thank You For Use Our Service");
                return;
            }

            //balance
            if (choice == "Balance")
            {
                balance();
                Console.ReadKey();
                Console.WriteLine("Thank You For Use Our Service");
                return;
            }
            //exit 
            if (choice == "Exit")
            {
                Console.WriteLine("Take Your Card");
                Console.ReadKey();
                Console.WriteLine("Thank You For Use Our Service");
                return;
            }
        }
    }
    Console.ReadKey();
    Console.WriteLine("Your Card Has Been Blocked Please Contact Your Bank");
}

