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
    }
}
