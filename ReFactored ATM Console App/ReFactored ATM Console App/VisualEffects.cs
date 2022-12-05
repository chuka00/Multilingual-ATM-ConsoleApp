using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReFactored_ATM_Console_App
{
    internal class VisualEffects
    {
        public static void LoadingAnimation()
        {

            for (int i = 0; i < 58; i++)
            {
                Thread.Sleep(10);
                Console.Write("-");

            }
        }
    }
}
