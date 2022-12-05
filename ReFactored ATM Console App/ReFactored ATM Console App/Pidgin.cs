namespace ReFactored_ATM_Console_App
{
    internal class Pidgin : English
    {

        public int accountNumber = 554433221;
        public int pin = 1984;
        public double balance = 5000000.00;
        public double transferAmount;
        public double withdrawAmount;
        public int option;
        private string userName = "Steph Curry";
        private string recipient = "Paul George";
        private int transferAccountNum = 112233445;

        public void OperationInPidgin()
        {
            try
            {
                Console.Write("ABEG YOUR ENTER ACCOUNT NUMBER : ");
                accountNumber = Convert.ToInt32(Console.ReadLine());
                if (accountNumber != 554433221)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("ACCOUNT NUMBER NO CORRECT");
                    Console.ReadLine();
                }
                else
                {
                    Console.Write("ENTER  YOUR ATM PIN # : ");
                    pin = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n");
                    if (pin != 1984)
                    {
                        Console.WriteLine("YOU DEY WHINE ME NI, THE PIN NO CORRECT TRY AM AGAIN");
                        Console.ReadLine();
                    }
                    else if (pin == 1984)
                    {
                        while (true)
                        {
                            IntroductionPidgin();
                            
                           
                            if (option == 1)
                            {
                                DisplayBalancePidgin();
                            }
                            else if (option == 2)
                            {
                                WithdrawPidgin();
                            }
                            else if (option == 3)
                            {
                                TransferPidgin();
                            }
                            else if (option == 4)
                            {
                                Console.WriteLine("THANK YOU");
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
        private void IntroductionPidgin()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("WHICH KIND TRANSACTION YOU WAN RUN: 1, 2, 3\n");
            Console.WriteLine($"Oga {userName}, Welcome O!");
            Console.WriteLine("1. CHECK WETIN REMAIN\n");
            Console.WriteLine("2. COMOT MONEY\n");
            Console.WriteLine("3. TRANSFER MONI\n");
            Console.WriteLine("4. SHUN THIS TRANSACTION \n");
            Console.Write("\nRUN TRANSACTION : ");
            option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
        }

        private void DisplayBalancePidgin()
        {
            Console.WriteLine("ACCOUNT NUMBER : " + accountNumber);
            Console.WriteLine("ACCOUNT NAME : " + userName);
            Console.WriteLine("BALANCE : N " + balance);
            Console.WriteLine("THANK YOU");
            Console.ReadLine();
        }
        private void WithdrawPidgin()
        {
            Console.Write("HOW MUCH YOU WAN COMOT FROM YOUR ACCOUNT : ");
            withdrawAmount = Convert.ToDouble(Console.ReadLine());
            if (withdrawAmount > 10000.00 && withdrawAmount < 10)
            {

                Console.WriteLine("OMO, NA 10,000.00 BE THE HIGHEST WEY YOU FIT COMOT");
                Console.WriteLine("THIS NA YOUR REMAINING BALANCE: N " + balance);
                Console.ReadLine();
            }
            else
            {
                balance -= withdrawAmount;
                OnWithdrawSuccessful("SUCCESS!\nTHIS NA YOUR REMAINING BALANCE: N " + balance);
                Console.WriteLine("THANK YOU");
                Console.ReadLine();
            }
        }

        private void TransferPidgin()
        {
            Console.WriteLine("HOW MUCH YOU WAN TRANSFER? : ");
            transferAmount = Convert.ToDouble(Console.ReadLine());
            if (transferAmount > 10000.00 && transferAmount < 10)
            {

                Console.WriteLine("NO VEX, YOU ONLY FIT TRANSFER 10,000.00 MAXIMUM ONLY");
                Console.WriteLine("THIS IS YOUR REMAINING BALANCE: N " + balance);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("INPUT THE RECIPIENT'S ACCOUNT NUMBER");
                var randomVar = Convert.ToInt32(Console.ReadLine());
                var transferAccountNum = randomVar;
                if (transferAccountNum != 112233445)
                {
                    Console.WriteLine("THAT ACCOUNT NUMBER NO DEY BOSS!");
                }
                else
                {
                    OnTransferSuccessful($"YOU DON TRANSFER {transferAmount} GO {recipient}'S ACCOUNT");
                    balance = balance - transferAmount;
                    Console.WriteLine("THIS NA YOUR REMAINING BALANCE: N " + balance);
                    Console.WriteLine("THANK YOU");
                    Console.ReadLine();
                }
            }
        }
    }
}
