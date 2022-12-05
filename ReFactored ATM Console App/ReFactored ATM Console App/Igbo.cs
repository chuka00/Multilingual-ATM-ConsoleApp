using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ReFactored_ATM_Console_App
{
    public class Igbo : English
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

        public void OperationInIgbo()
        {
            try
            {
                startOver:
                Console.Write("tinye nomba akauntu : ");
                accountNumber = Convert.ToInt32(Console.ReadLine());
                if (accountNumber != 554433221)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Nomba akauntụ ezighi ezi ");
                    Console.ReadLine();
                }
                else
                {
                    Console.Write("tinye pin akauntu# : ");
                    pin = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n");
                    if (pin != 1984)
                    {
                        Console.WriteLine("Nomba Pin ezighi ezi biko nwaa ozo");
                        Console.ReadLine();
                    }
                    else if (pin == 1984)
                    {
                        while (true)
                        {
                            IntroductionIgbo();
                           
                            if (option == 1)
                            {
                                DisplayBalanceIgbo();
                            }
                            else if (option == 2)
                            {
                                WithdrawMoneyIgbo();
                            }
                            else if (option == 3)
                            {
                                TransferMoneyIgbo();
                            }
                            else if (option == 4)
                            {
                                Console.WriteLine("Daalu");
                                Environment.Exit(10);
                            }
                            else
                            {
                                Console.WriteLine("Biko tinye ezigbo nhoro");
                                Console.ReadLine();
                            }
                        }
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine("An Error occured "+ ex.Message);
            }
        }

        private void IntroductionIgbo()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Horo azumahia: 1, 2, 3\n");
            Console.WriteLine("1. Juo ase\n");
            Console.WriteLine("2. Ikwusi\n");
            Console.WriteLine("3. Nyefee Ego");
            Console.WriteLine("4. Mmemme opupu \n");
            Console.Write("Horo azumahia : ");
            option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
        }
        private void DisplayBalanceIgbo()
        {
            Console.WriteLine("Nomba akauntu : " + accountNumber);
            Console.WriteLine("Aha akauntu : " + userName);
            Console.WriteLine("Ego Balance : N " + balance);
            Console.WriteLine("Daalu");
            Console.ReadLine();
        }

        private void WithdrawMoneyIgbo()
        {
            Console.Write("Tinye ego i ga-ewepu : ");
            withdrawAmount = Convert.ToDouble(Console.ReadLine());
            if (withdrawAmount > 10000.00 && withdrawAmount < 10)
            {

                Console.WriteLine("Ndo, iwepu ihe ruru 10,000.00 kacha naani");
                Console.WriteLine("Nke a bu nguzozi nke gi foduru: N " + balance);
                Console.ReadLine();
            }
            else
            {
                balance = balance - withdrawAmount;
                OnWithdrawSuccessful("Nke a bu nguzozi nke gi foduru: N " + balance);
                Console.WriteLine("Daalu");
                Console.ReadLine();
            }
        }
        public void TransferMoneyIgbo()
        {
            Console.WriteLine("Tinye ego iji nyefee : ");
            transferAmount = Convert.ToDouble(Console.ReadLine());
            if (transferAmount > 10000.00 && transferAmount < -0)
            {

                Console.WriteLine("Ndo, ego mbufe bụ 10,000.00 kacha naanị");
                Console.WriteLine("Nke a bụ nguzozi nke gị fọdụrụ: N " + balance);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Jiri nwayọ tinye nọmba Akaụntụ onye nnata");
                var randomVar = Convert.ToInt32(Console.ReadLine());
                var transferAccountNum = randomVar;
                if (transferAccountNum != 112233445)
                {
                    Console.WriteLine("ahụ ahụ adịghị adị!");
                }
                else
                {
                    OnTransferSuccessful($"Eferefela gị nke ọma {transferAmount} ka {recipient}");
                    balance = balance - transferAmount;
                    Console.WriteLine("Nke a bụ nguzozi nke gị fọdụrụ: N " + balance);
                    Console.WriteLine("DAALU");
                    Console.ReadLine();
                }
            }
        }
    }
}
