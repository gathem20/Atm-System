// Atm System 
using System.Formats.Asn1;

int passwordCard = 5555;
double balanceAccount = 20000;
double balanceAtm = 50000;
Console.WriteLine("Please Enter Your password");
int password = Convert.ToInt32(Console.ReadLine());


void sound()
{
    Console.WriteLine("Take Your Card");
    for (int i = 0; i <= 10; i++)
    {
        Console.Beep(1000, 500);
        if (Console.KeyAvailable)
        {
            Console.ReadKey();
            break;
        }

    }
}

// Menu
void Menu()
{

    Console.WriteLine("Please Choose Your Option");

    Console.WriteLine("1-:Withdraw"); //ok
    Console.WriteLine("2-:Deposit"); //ok
    Console.WriteLine("3-:Balance"); //ok
    Console.WriteLine("4-:Exit"); //ok
    string choice = Console.ReadLine();
    // withdraw

    if (choice == "1")
    {
        withdrawAtm();

    }


    //deposit
    if (choice == "2")
    {
        depositAtm();

    }

    //balance
    if (choice == "3")
    {
        balance();

    }
    //exit
    if (choice == "4")
    {
        sound();
        Console.WriteLine("Thank You For Use Our Service");
    }
}

void anotherOperation()
{
    Console.WriteLine("Do You Want To Another Operation?  Yes Or No");
    string valid = Console.ReadLine();
    valid = valid.ToUpper();
    if (valid == "YES")
    {
        Menu();
    }
    else if (valid == "NO")
    {
        sound();
        Console.WriteLine("Thank You For Use Our Service");
    }
}
// withdraw function
void withdrawAtm()
{
    Console.WriteLine("Please Enter Your Withdraw");
    double withdraw = Convert.ToDouble(Console.ReadLine());
    if (withdraw < balanceAtm && withdraw < balanceAccount)
    {
        balanceAtm -= withdraw;
        balanceAccount -= withdraw;

        sound();
        //sound
        Thread.Sleep(2000);

        Console.WriteLine("Take Your Money");
        for (int i = 0; i <= 10; i++)
        {
            Console.Beep(1000, 500);
            if (Console.KeyAvailable)
            {
                Console.ReadKey();
                break;
            }
        }
        Console.WriteLine("Thank You For Use Our Service");
        //sound
    }
    else if (withdraw > balanceAtm)
    {
        Console.WriteLine("The Atm Has No Enough Money");
        anotherOperation();
    }
    else
    {
        Console.WriteLine("Your Balance Account Has Not Enough Money");
        anotherOperation();
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
    anotherOperation();
    return;
}


//balance funtion

void balance()
{
    Console.WriteLine("Your Balance Is " + balanceAccount);
    anotherOperation();
    return;
}

//check password
if (password == passwordCard)
{
    Menu();
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
            Menu();
            return;
        }
    }
    Console.ReadKey();
    sound();
    Console.WriteLine("Your Card Has Been Blocked Please Contact Your Bank");
}

