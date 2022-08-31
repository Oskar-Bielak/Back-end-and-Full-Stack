using System;

namespace _03_State
{    
    class CreditCard
    {
        public string Pin { get; set; }
        public decimal Balance { get; set; }

        public CreditCard(string pin)
        {
            Pin = pin;
        }
    }

    class CashMachine
    {
        public CreditCard CreditCard { get; set; }
        public IState State { get; set; }

        public CashMachine(CreditCard creditCard)
        {
            CreditCard = creditCard;
            State = new PinRequired(3);
        }

        public void Operations()
        {
            while (State.Change(this)){}
        }
    }

    interface IState
    {
        bool Change(CashMachine cashMachine);        
    }

    class PinRequired : IState
    {
        private readonly int attempts;

        public PinRequired(int attempts = 1)
        {
            this.attempts = attempts;
        }

        public bool Change(CashMachine cashMachine)
        {
            int counter = 1;
            string pin;
            do
            {
                Console.WriteLine($"Enter pin ({counter} / {attempts}):");
                pin = Console.ReadLine();
                ++counter;
            } while (counter <= attempts && pin.CompareTo(cashMachine.CreditCard.Pin) != 0); 
            // wymien wszystkie sposoby porownywania napisow

            if (pin.CompareTo(cashMachine.CreditCard.Pin) != 0)
            {
                // musi np wyjac i wlozyc karte ponownie
                Console.WriteLine("Invalid pin value. Try again later"); 
                cashMachine.State = new AppEnd();
            }
            else
            {
                cashMachine.State = new UserOptions();
            }
            return true;
        }
    }

    class UserOptions : IState
    {
        public bool Change(CashMachine cashMachine)
        {
            Console.WriteLine("1. Account balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdrawal");
            Console.WriteLine("4. Exit");

            Console.WriteLine("Choose option:");
            if (!int.TryParse(Console.ReadLine(), out int option))
            {
                Console.WriteLine("Invalid option number.");
                cashMachine.State = new UserOptions();
            }

            switch (option)
            {
                case 1:
                    cashMachine.State = new AccountBalance();
                    break;
                case 2:
                    cashMachine.State = new Deposit();
                    break;
                case 3:
                    cashMachine.State = new Withdrawal();
                    break;
                case 4:
                    cashMachine.State = new AppEnd();
                    break;
                default:
                    Console.WriteLine("Invalid option number");
                    cashMachine.State = new UserOptions();
                    break;
            }
            return true;
        }
    }

    class AccountBalance : IState
    {
        public bool Change(CashMachine cashMachine)
        {
            Console.WriteLine($"Account balance: {cashMachine.CreditCard.Balance}");
            cashMachine.State = new UserOptions();
            return true;
        }
    }

    class Withdrawal : IState
    {
        public bool Change(CashMachine cashMachine)
        {
            // zauwaz ze fragment kodu ponizej jest identyczny z tym, ktory
            // spotkasz w metodzie Change w klase Deposit - zaproponuj rozwiazanie
            // ktore pozwoli wyeliminowac nadmierne powielanie kodu
            Console.WriteLine("Enter the amount of money:");

            if (!decimal.TryParse(Console.ReadLine(), out decimal amount))
            {
                Console.WriteLine("Invalid value.");
                cashMachine.State = new UserOptions();
            }

            cashMachine.CreditCard.Balance -= amount;
            cashMachine.State = new UserOptions();
            return true;
        }
    }

    class Deposit : IState
    {
        public bool Change(CashMachine cashMachine)
        {
            Console.WriteLine("Enter the amount of money:");

            if (!decimal.TryParse(Console.ReadLine(), out decimal amount))
            {
                Console.WriteLine("Invalid value.");
                cashMachine.State = new UserOptions();
            }

            cashMachine.CreditCard.Balance += amount;
            cashMachine.State = new UserOptions();
            return true;
        }
    }

    class AppEnd : IState
    {
        public bool Change(CashMachine cashMachine)
        {
            Console.WriteLine("Have a nice day!");
            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {            
            var creditCard = new CreditCard("1234");
            var cashMachine = new CashMachine(creditCard);
            cashMachine.Operations();
        }
    }
}
