using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace ReFactored_ATM_Console_App
{
    internal class ATM
    {
        //English english = new English();
        
        public English english1 { get; set; } = new English();
        public Igbo igbo { get; set; } = new Igbo();
        public Pidgin pidgin { get; set; } = new Pidgin();

            
        public virtual void Start()
        {
            english1.AddTransferSuccessful(HandleTransferSuccessful);
            english1.AddWithdrawSuccessful(HandleWithdrawSuccessful);


        startOver:
            Console.WriteLine("Good day! Welcome to GT Bank");
            Console.WriteLine("Please enter a language of your choice\n 'E' for English,\n 'P' for Pidgin \n 'I' for igbo");
            string chosenLanguage = Console.ReadLine().ToUpper();

            Igbo igbo = new Igbo();

            English english = new English();

            Pidgin pidgin = new Pidgin();

            switch (chosenLanguage)
            {
                case "E":
                    english.OperationInEnglish();
                    break;
                case "P":
                    pidgin.OperationInPidgin();
                    break;
                case "I":
                    igbo.OperationInIgbo();
                    break;
                default:
                    Console.WriteLine("Invalid selection, try again\n");
                    break;

            }
                goto startOver;
        }

        public static void HandleTransferSuccessful(string message)
        {
            Console.WriteLine("=> {0}", message);
        }

        public static void HandleWithdrawSuccessful(string message)
        {
            Console.WriteLine("=> {0}", message);
        }
    }
}
