namespace ReFactored_ATM_Console_App
{
    public class English
    {

        event Action<string> TransferSuccessful;
        event Action<string> WithdrawSuccessful;

        public int accountNumber = 554433221;
        public int pin = 1984;
        public double balance = 5000000.00;
        public double transferAmount;
        public double withdrawAmount;
        public int option;
        private string userName = "Steph Curry";
        private string recipient = "Paul George";
        private int transferAccountNum = 112233445;

        public void OperationInEnglish()
        {
            try
            {
            startOver:
                Console.Write("ENTER ACCOUNT NUMBER : ");
                accountNumber = Convert.ToInt32(Console.ReadLine());
                if (accountNumber != 554433221)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("INCORRECT ACCOUNT NUMBER ");
                    goto startOver;
                }
                else
                {
                    Console.Write("ENTER ATM PIN # : ");
                    pin = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n");
                    if (pin != 1984)
                    {
                        Console.WriteLine("INCORRECT PIN NUMBER PLEASE TRY AGAIN");
                        goto startOver;
                    }
                    else if (pin == 1984)
                    {
                        while (true)
                        {
                            Introduction();


                            if (option == 1)
                            {
                                DisplayBalance();
                            }
                            else if (option == 2)
                            {
                                WithdrawMoney();
                            }
                            else if (option == 3)
                            {
                                TransferMoney();
                            }
                            else if (option == 4)
                            {
                                Console.WriteLine("THANK YOU\nPRESS ENTER TO CONTINUE");
                                Environment.Exit(10);
                            }
                            else
                            {
                                Console.WriteLine("PLEASE ENTER VALID OPTION");
                                Console.ReadLine();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error Occured:" + ex.Message);

            }

        }

        private void Introduction()
        {
            Console.WriteLine("=================================");
            Console.WriteLine($"Welcome back {userName}!");
            Console.WriteLine("CHOOSE TRANSACTION: 1, 2, 3\n");
            Console.WriteLine("1. INQUIRE\n");
            Console.WriteLine("2. WITHDRAW\n");
            Console.WriteLine("3. TRANSFER\n");
            Console.WriteLine("4. EXIT PROGRAM \n");
            Console.Write("CHOOSE TRANSACTION : ");
            option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
        }

        private void DisplayBalance()
        {
            Console.WriteLine("ACCOUNT NUMBER : " + accountNumber);
            Console.WriteLine("ACCOUNT NAME : " + userName);
            Console.WriteLine("BALANCE : N " + balance);
            Console.WriteLine("THANK YOU");
            Console.ReadLine();
        }
        public void WithdrawMoney()
        {
            Console.Write($"YOU CURRENTLY HAVE {balance}\nENTER AMOUNT TO WITHDRAW : ");
            withdrawAmount = Convert.ToDouble(Console.ReadLine());
            if (withdrawAmount > 10000.00 && withdrawAmount < 0)
            {

                Console.WriteLine("SORRY, WITHDRAWAL IS UP TO 10,000.00 MAXIMUM ONLY");
                Console.WriteLine("THIS IS YOUR REMAINING BALANCE: N " + balance);
                Console.ReadLine();
            }
            else
            {
                balance = balance - withdrawAmount;
                OnWithdrawSuccessful("SUCCESS!\nTHIS IS YOUR REMAINING BALANCE: N " + balance);
                Console.WriteLine("THANK YOU");
                Console.ReadLine();
            }
        }

        private void TransferMoney()
        {
            Console.WriteLine($"YOU CURRENTLY HAVE {balance}\nENTER AMOUNT TO TRANSFER : ");
            transferAmount = Convert.ToDouble(Console.ReadLine());
            if (transferAmount > 10000.00 && transferAmount < 0)
            {

                Console.WriteLine("SORRY, TRANSFER AMOUNT IS 10,000.00 MAXIMUM ONLY");
                Console.WriteLine("THIS IS YOUR REMAINING BALANCE: N " + balance);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Kindly input the recipient's Account Number");
                var randomVar = Convert.ToInt32(Console.ReadLine());
                var transferAccountNum = randomVar;
                if (transferAccountNum != 112233445)
                {
                    Console.WriteLine("THAT ACCOUNT NUMBER DOES NOT EXIST!");
                }
                else
                {
                    OnTransferSuccessful($"YOU'VE SUCCESSFULLY TRANSFERRED {transferAmount} to {recipient}");
                    balance = balance - transferAmount;
                    Console.WriteLine("THIS IS YOUR REMAINING BALANCE: N " + balance);
                    Console.WriteLine("THANK YOU");
                    Console.ReadLine();
                }
            }
        }

        public void AddTransferSuccessful(Action<string> method)
        {
            TransferSuccessful += method;
        }

        protected virtual void OnTransferSuccessful(string message)
        {
            TransferSuccessful?.Invoke(message);
        }

        public void AddWithdrawSuccessful(Action<string> method)
        {
            WithdrawSuccessful += method;
        }

        protected virtual void OnWithdrawSuccessful(string message)
        {
            WithdrawSuccessful?.Invoke(message);
        }
    }
}
