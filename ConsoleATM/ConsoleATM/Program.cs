public class cardHolder1
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string CardNumber { get; set; }
    public double Balance { get; set; }
    public int Pin { get; set; }


    public cardHolder1 (string firstName, string lastName, string cardNumber,  int pin, double balance)
    {
        FirstName = firstName;
        LastName = lastName;
        CardNumber = cardNumber;
        Balance = balance;
        Pin = pin;
    }

    public static void Main(string[] args)
    {
        void displayOptions()
        {
            Console.WriteLine("Please choose your option...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        void deposit(cardHolder1 currentUser)
        {
            Console.WriteLine("Please input your desired deposit.");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.Balance += deposit;
            Console.WriteLine($"Your new balance is now {currentUser.Balance} pesos. Thank you for using our services");
        }

        void withdraw(cardHolder1 currentUser)
        {
            Console.WriteLine("Please input your desired withdrawal.");
            double withdraw = Double.Parse(Console.ReadLine());
            if(currentUser.Balance < withdraw)
            {
                Console.WriteLine("Sorry you dont have enough fund to withdraw such amount.");
            }
            else
            {
                currentUser.Balance -= withdraw;
                Console.WriteLine($"You have successfully withrawn {withdraw} pesos. Your new balance is {currentUser.Balance}");
            }
        }

        void balance(cardHolder1 currentUser)
        {
            Console.WriteLine($"Your current balance is {currentUser.Balance}");
        }

        List<cardHolder1> cardHolders = new List<cardHolder1>();
            cardHolders.Add(new cardHolder1("Jj", "Duncan", "1284756473847584", 1234, 20000));
            cardHolders.Add(new cardHolder1("Lama", "Dev", "4546756473847584", 4567, 4000));
            cardHolders.Add(new cardHolder1("John", "Mario", "9875756473847584", 4389, 8000));
            cardHolders.Add(new cardHolder1("Ben", "Hur", "0868756473847584", 1094, 60000));
            cardHolders.Add(new cardHolder1("John", "Doe", "4567756473847584", 8790, 120000));

        //Prompt the user
        Console.WriteLine("Welcome to MoneyStorage");
        Console.WriteLine("Please insert your debit card.");
        string debitCardNumber = "";
        cardHolder1 currentUser;

        while (true)
        {
            try
            {
                debitCardNumber = Console.ReadLine();

                //Check if debit card number is found in db
                currentUser = cardHolders.FirstOrDefault(a => a.CardNumber == debitCardNumber);
                if(currentUser != null) { break; }
                else { Console.WriteLine("Card is not recognized. Please try again."); }
            }
            catch
            {
                Console.WriteLine("Something went wrong. Please try again.");
            }
        }

        //If card i accepted do this
        Console.WriteLine("Please enter your pin number");
        int pin = 0;

        while (true)
        {
            try
            {
                pin = int.Parse(Console.ReadLine());

                //Check if pin matches the card
                if(currentUser.Pin == pin) { break; }
                else { Console.WriteLine("Incorrect pin! Please try again."); }
            }
            catch
            {
                Console.WriteLine("Incorrent pin code.");
            }
        }

        Console.WriteLine($"Welcome {currentUser.FirstName}");
        int option = 0;


        do
        {
            displayOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Something went wrong!");
            }

            if (option == 1) { deposit(currentUser); }
            else if (option == 2) { withdraw(currentUser); }
            else if (option == 3) { balance(currentUser); }
            else if (option == 4) { break; }
            else { option = 0; }
        }
        while (option != 4);
           
        Console.WriteLine("Thank you for using our services.");

    }

}