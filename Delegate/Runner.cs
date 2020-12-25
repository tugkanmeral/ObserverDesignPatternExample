using System;

namespace Delegate
{
    public static class Runner
    {
        public static void Run()
        {
            Console.WriteLine("\n#####\tBeginning of delegate example\t#####");

            Bank bank = new Bank();
            IObserver investment = new Department("Yatırım Birimi");

            bank.RegisterObserver(investment.Update);

            bank.ChangeParityValue(7.62M);

            bank.UnregisteObserver(investment.Update);

            bank.ChangeParityValue(8.2M);

            Console.WriteLine("#####\tEnd of delegate example\t#####\n");
        }
    }
}
