public class cardHolder
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string CardNumber { get; set; }
    public int Pin { get; set; }
    public double Balance { get; set; }

    public cardHolder(string firstName, string lastName, string cardNumber, int pin, double balance)
    {
        FirstName = firstName;
        LastName = lastName;
        CardNumber = cardNumber;
        Pin = pin;
        Balance = balance;
    }
    

    public static void Main(string[] args)
    {
        void displayOptions()
        {
            Console.WriteLine("Please choose your options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        void deposit( cardHolder currentUser)
        {
            Console.WriteLine("How much money would you like to deposit?");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.Balance = currentUser.Balance + deposit;
            Console.WriteLine("Thank you for your deposit. Your new balance is: Php"
                    + currentUser.Balance);
        }

        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much money would you like to withdraw?: ");
                        double withdraw = Double.Parse(Console.ReadLine());
                        if(currentUser.Balance < withdraw)
                        {
                            Console.WriteLine("Insufficient balance!");
                        }
                        else
                        {
                            currentUser.Balance = (currentUser.Balance - withdraw);
                            Console.WriteLine("You have successfully withdrew: Php" + withdraw);
                Console.WriteLine("Your new balance is: Php " + currentUser.Balance);
                        }
        }

        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Your current balance is: Php" + currentUser.Balance);
        }

        List<cardHolder> cardHolders = new List<cardHolder>();
                cardHolders.Add(new cardHolder( "Jj", "Duncan", "1284756473847584", 1234, 20000));
                cardHolders.Add(new cardHolder( "Lama", "Dev", "4546756473847584", 4567, 4000));
                cardHolders.Add(new cardHolder("John", "Mario", "9875756473847584", 4389, 8000));
                cardHolders.Add(new cardHolder("Ben", "Hur", "0868756473847584", 1094, 60000));
                cardHolders.Add(new cardHolder("John", "Doe", "4567756473847584", 8790, 120000));

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
                currentUser = cardHolders.FirstOrDefault(a => a.CardNumber == debitCardNum);
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
                if (currentUser.Pin == userPin) { break; }
                else { Console.WriteLine("Incorrect pin code! Please try again."); }

            }
            catch
            {
                Console.WriteLine("Incorrect pin code! Please try again.");
            }
        }

        Console.WriteLine("Welcome " + currentUser.FirstName + " " + currentUser.LastName);
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
            if(option == 1) { deposit(currentUser); }
            else if(option == 2) { withdraw(currentUser); }
            else if(option == 3) { balance(currentUser); } 
            else if(option == 4) { break; }
            else { option = 0; }
        }
        while (option != 4);
        Console.WriteLine("Thank you!");
    }
} 