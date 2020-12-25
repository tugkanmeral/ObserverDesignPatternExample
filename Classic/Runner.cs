using System;

namespace Classic
{
    public static class Runner
    {
        public static void Run() 
        {
            Console.WriteLine("\n#####\tBeginning of classic example\t#####");

            Bank bank = new Bank();
            Department investment = new Department("Yatırım Birimi");

            bank.RegisterObserver(investment);

            bank.ChangeParityValue(7.62M);

            bank.UnregisterObserver(investment);

            bank.ChangeParityValue(8.2M);

            Console.WriteLine("#####\tEnd of classic example\t#####\n");
        }
    }
}
