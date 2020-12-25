using System;

namespace DotNet
{
    public static class Runner
    {
        public static void Run()
        {
            Console.WriteLine("\n#####\tBeginning of dotnet example\t#####");

            Bank bank = new Bank();
            Department investment = new Department("Yatırım Birimi");

            investment.RegisterObserver(bank);

            bank.ChangeParityValue(7.62M);

            investment.UnregisterObserver();
            //bank.CloseNotificationService();

            bank.ChangeParityValue(8.2M);

            Console.WriteLine("#####\tEnd of dotnet example\t#####\n");
        }
    }
}
