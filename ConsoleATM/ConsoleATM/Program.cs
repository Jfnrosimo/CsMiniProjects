using System;

public class cardHolder
{
    String cardNum;
    int pin;
    String firstName;
    String lastName;
    double balance;

    public cardHolder(String cardNum, int pin, String firstName, String lastName, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }

    public String getCardNum()
    {
        return cardNum;
    }

    public int getPin()
    {
        return pin;
    }

    public String getFirstName()
    {
        return firstName;
    }

    public String getLastName()
    {
        return lastName;
    }

    public double getBalance() 
    {
        return balance;
    }

    public void setCardNum(String newCardNum)
    {
        cardNum = newCardNum;
    }

    public void setPin(int newPin)
    {
        pin = newPin;
    }

    public void setFirstName(String newFirstName)
    {
        firstName = newFirstName;
    }

    public void setLastName(String newLastName)
    {
        lastName = newLastName; 
    }

    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }

    public static void Main(String[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose your options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much money would you like to deposit?: ");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(deposit + currentUser.getBalance());
            Console.WriteLine("Thank you for your deposit. Your new balance is: Php"
                + currentUser.getBalance());
        }

        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much money would you like to withdraw?: ");
            double withdraw = Double.Parse(Console.ReadLine());
            if(currentUser.getBalance() > withdraw)
            {
                Console.WriteLine("Insufficient balance: ");
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdraw);
                Console.WriteLine("You have successfully withdrew: Php" + withdraw);
            }
        }

        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Your current balance is: Php" + currentUser.getBalance());
        }

        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("1284756473847584", 1234, "Jj", "Duncan", 20000));
        cardHolders.Add(new cardHolder("4546756473847584", 4567, "Lama", "Dev", 4000));
        cardHolders.Add(new cardHolder("9875756473847584", 4389, "John", "Mario", 8000));
        cardHolders.Add(new cardHolder("0868756473847584", 1094, "Ben", "Hur", 60000));
        cardHolders.Add(new cardHolder("4567756473847584", 8790, "John", "Doe", 120000));

        //Prompt user
        Console.WriteLine("Welcome to MoneyStorage");
        Console.WriteLine("Please insert your debit card: ");
        String debitCardNum = "";
        cardHolder currentUser;

        while (true)
        {
            try
            {
                debitCardNum = Console.ReadLine();

                //Check against our db
                currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                if (currentUser != null) { break; }
                else { Console.WriteLine("Card is not recognized. Please try again."); }

            }
            catch
            {
                Console.WriteLine("Card not recognized. Please try again");
            }
        }

        Console.WriteLine("Please enter your pin: ");
        int userPin = 0;
        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());

                //Check against our db
                if (currentUser.getPin() == userPin) { break; }
                else { Console.WriteLine("Incorrect pin code!"); }

            }
            catch
            {
                Console.WriteLine("Incorrect pin code!");
            }
        }
    }
}
