using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCMTest
{
    public class CcmMethods
    {
        public void Ccm1()
        {
            Console.WriteLine("CCM1");
        }

        public void Ccm2_Classic()
        {
            var random = new Random();
            var number = random.Next();

            // ReSharper disable once ConvertIfStatementToConditionalTernaryExpression => Interested in CCMs capability.
            if (number % 2 == 0)
            {
                Console.WriteLine("Branch Even");
            }
            else
            {
                Console.WriteLine("Branch Odd");
            }
        }

        public void Ccm2_YesThisIsStillCcm2()
        {
            // To detect this, the tool needs advanced analyzes into the parameter of the function.
            // In case this is a problem in the quality, it can be easily extracted to the function, so it's not a big issue,
            // but this is still CCM 2.
            var random = new Random();
            var number = random.Next();

            Console.WriteLine(number % 2 == 0 ? "Branch Even" : "Branch Odd");
        }

        public void Ccm3()
        {
            var random = new Random();
            var number = random.Next();

            switch (number % 3)
            {
                case 0:
                    Console.WriteLine("Branch 0");
                    break;

                case 1:
                    Console.WriteLine("Branch 1");
                    break;

                default:
                    Console.WriteLine("Branch 2");
                    break;
            }
        }

        public void Ccm4()
        {
            // Yes, technically this is CCM 4, while logically it is only CCM 3.
            // If you don't use default, only really advanced tools will deduct that modulo 3 can only have 0, 1, 2 so all your branches are covered.
            var random = new Random();
            var number = random.Next();

            switch (number % 3)
            {
                case 0:
                    Console.WriteLine("Branch 0");
                    break;

                case 1:
                    Console.WriteLine("Branch 1");
                    break;

                case 2:
                    Console.WriteLine("Branch 2");
                    break;
            }
        }

        public void LetsConstructAReallyComplexMethodBecauseIAmInterestedInThePriorityThresholdsOfJenkinsCcmPlugin()
        {
            var random = new Random();
            // ReSharper disable once SwitchStatementMissingSomeCases => R# Please ignore this, would never write this code if not testing bad ones, thanks.
            switch (random.Next())
            {
                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 6:
                    break;

                case 7:
                    break;

                case 8:
                    break;

                case 9:
                    break;

                case 10:
                    break;


                case 11:
                    break;

                case 12:
                    break;

                case 13:
                    break;

                case 14:
                    break;

                case 15:
                    break;

                case 16:
                    break;

                case 17:
                    break;

                case 18:
                    break;

                case 19:
                    break;

                case 20: // OK, so CCM 20 is only hitting normal priority in Jenkins plug-in. I have a higher standard :D (do not write something more complex than 5).
                    break;


                case 21:
                    break;

                case 22:
                    break;

                case 23:
                    break;

                case 24:
                    break;

                case 25:
                    break;

                case 26:
                    break;

                case 27:
                    break;

                case 28:
                    break;

                case 29:
                    break;

                case 30:
                    break;


                case 31:
                    break;

                case 32:
                    break;

                case 33:
                    break;

                case 34:
                    break;

                case 35:
                    break;

                case 36:
                    break;

                case 37:
                    break;

                case 38:
                    break;

                case 39:
                    break;

                case 40:
                    break;


                case 41:
                    break;

                case 42:
                    break;

                case 43:
                    break;

                case 44:
                    break;

                case 45:
                    break;

                case 46:
                    break;

                case 47:
                    break;

                case 48:
                    break;

                case 49:
                    break;

                case 50: // OK, this is high according to Jenkins CCM plug-in. Now the question is where is the threshold.
                    break;
            }
        }

        public void Ccm22()
        {
            var random = new Random();
            // ReSharper disable once SwitchStatementMissingSomeCases => R# Please ignore this, would never write this code if not testing bad ones, thanks.
            switch (random.Next())
            {
                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 6:
                    break;

                case 7:
                    break;

                case 8:
                    break;

                case 9:
                    break;

                case 10:
                    break;


                case 11:
                    break;

                case 12:
                    break;

                case 13:
                    break;

                case 14:
                    break;

                case 15:
                    break;

                case 16:
                    break;

                case 17:
                    break;

                case 18:
                    break;

                case 19:
                    break;

                case 20: // OK, so CCM 20 is only hitting normal priority in Jenkins plug-in. I have a higher standard :D (do not write something more complex than 5).
                    break;


                case 21:
                    break;

                case 22:
                    break;

            }
        }


        public void Ccm25()
        {
            var random = new Random();
            // ReSharper disable once SwitchStatementMissingSomeCases => R# Please ignore this, would never write this code if not testing bad ones, thanks.
            switch (random.Next())
            {
                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 6:
                    break;

                case 7:
                    break;

                case 8:
                    break;

                case 9:
                    break;

                case 10:
                    break;


                case 11:
                    break;

                case 12:
                    break;

                case 13:
                    break;

                case 14:
                    break;

                case 15:
                    break;

                case 16:
                    break;

                case 17:
                    break;

                case 18:
                    break;

                case 19:
                    break;

                case 20: // OK, so CCM 20 is only hitting normal priority in Jenkins plug-in. I have a higher standard :D (do not write something more complex than 5).
                    break;


                case 21:
                    break;

                case 22:
                    break;

                case 23:
                    break;

                case 24:
                    break;

                case 25:
                    break;

            }
        }

        public void Ccm30()
        {
            var random = new Random();
            // ReSharper disable once SwitchStatementMissingSomeCases => R# Please ignore this, would never write this code if not testing bad ones, thanks.
            switch (random.Next())
            {
                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 6:
                    break;

                case 7:
                    break;

                case 8:
                    break;

                case 9:
                    break;

                case 10:
                    break;


                case 11:
                    break;

                case 12:
                    break;

                case 13:
                    break;

                case 14:
                    break;

                case 15:
                    break;

                case 16:
                    break;

                case 17:
                    break;

                case 18:
                    break;

                case 19:
                    break;

                case 20: // OK, so CCM 20 is only hitting normal priority in Jenkins plug-in. I have a higher standard :D (do not write something more complex than 5).
                    break;


                case 21:
                    break;

                case 22:
                    break;

                case 23:
                    break;

                case 24:
                    break;

                case 25:
                    break;

                case 26:
                    break;

                case 27:
                    break;

                case 28:
                    break;

                case 29:
                    break;

                case 30:
                    break;
            }
        }

        public void Ccm40()
        {
            var random = new Random();
            // ReSharper disable once SwitchStatementMissingSomeCases => R# Please ignore this, would never write this code if not testing bad ones, thanks.
            switch (random.Next())
            {
                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 6:
                    break;

                case 7:
                    break;

                case 8:
                    break;

                case 9:
                    break;

                case 10:
                    break;


                case 11:
                    break;

                case 12:
                    break;

                case 13:
                    break;

                case 14:
                    break;

                case 15:
                    break;

                case 16:
                    break;

                case 17:
                    break;

                case 18:
                    break;

                case 19:
                    break;

                case 20: // OK, so CCM 20 is only hitting normal priority in Jenkins plug-in. I have a higher standard :D (do not write something more complex than 5).
                    break;


                case 21:
                    break;

                case 22:
                    break;

                case 23:
                    break;

                case 24:
                    break;

                case 25:
                    break;

                case 26:
                    break;

                case 27:
                    break;

                case 28:
                    break;

                case 29:
                    break;

                case 30:
                    break;


                case 31:
                    break;

                case 32:
                    break;

                case 33:
                    break;

                case 34:
                    break;

                case 35:
                    break;

                case 36:
                    break;

                case 37:
                    break;

                case 38:
                    break;

                case 39:
                    break;

                case 40:
                    break;

            }
        }

        public void Ccm49()
        {
            var random = new Random();
            // ReSharper disable once SwitchStatementMissingSomeCases => R# Please ignore this, would never write this code if not testing bad ones, thanks.
            switch (random.Next())
            {
                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 6:
                    break;

                case 7:
                    break;

                case 8:
                    break;

                case 9:
                    break;

                case 10:
                    break;


                case 11:
                    break;

                case 12:
                    break;

                case 13:
                    break;

                case 14:
                    break;

                case 15:
                    break;

                case 16:
                    break;

                case 17:
                    break;

                case 18:
                    break;

                case 19:
                    break;

                case 20: // OK, so CCM 20 is only hitting normal priority in Jenkins plug-in. I have a higher standard :D (do not write something more complex than 5).
                    break;


                case 21:
                    break;

                case 22:
                    break;

                case 23:
                    break;

                case 24:
                    break;

                case 25:
                    break;

                case 26:
                    break;

                case 27:
                    break;

                case 28:
                    break;

                case 29:
                    break;

                case 30:
                    break;


                case 31:
                    break;

                case 32:
                    break;

                case 33:
                    break;

                case 34:
                    break;

                case 35:
                    break;

                case 36:
                    break;

                case 37:
                    break;

                case 38:
                    break;

                case 39:
                    break;

                case 40:
                    break;


                case 41:
                    break;

                case 42:
                    break;

                case 43:
                    break;

                case 44:
                    break;

                case 45:
                    break;

                case 46:
                    break;

                case 47:
                    break;

                case 48:
                    break;

                case 49:
                    break;
            }
        }
    }
}
