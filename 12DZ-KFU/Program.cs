using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12DZ_KFU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("13.1;1,2");
            Bank_Account bank_Account = new Bank_Account();
            bank_Account.Add(300);
            bank_Account.Add(1700);
            bank_Account.Lower(400);
            Console.WriteLine(bank_Account[0].ToString());

            Bank_Account acc1 = new Bank_Account(123, 3000, Bank_Account.Acc_Type.Сберегательный);
            Bank_Account acc2 = new Bank_Account(acc1.new_ID(), 1000, Bank_Account.Acc_Type.Накопительный);
            acc2.Transition(acc1, 1000);

            Console.WriteLine("13.2;1,2");

            Buildingindex Babuin = new Buildingindex(new[]
            {
                new Building(100, 25, 250,10),
                new Building(125, 25, 250,10),
                new Building(150, 25, 250,10),
                new Building(75, 25, 250,10),
                new Building(50, 25, 250,10),
                new Building(200, 25, 250,10),
                new Building(100, 20, 250,10),
                new Building(100, 10, 250,10),
                new Building(100, 5, 250,10),
                new Building(120, 20, 250,10)

            });
            Console.WriteLine("Введите индекс");
            int index = int.Parse(Console.ReadLine());
            if (index < 0 || index > 10)
            {
                throw new Exception("Индекста тyгел син");

            }
            Babuin[index].Print();


            Console.WriteLine(14.1);
            acc1.DumpToScreen();//14.1 CW

            Console.WriteLine(14.2);


            Console.WriteLine(14.1);

            Type type = typeof(Bank_Account);
            object[] attributes = type.GetCustomAttributes(false);
            // проходим по всем атрибутам
            foreach (atrBankAttribute attr in attributes)
            {
                Console.WriteLine($"Разработчик: {attr.Developer}\nОрганизация: {attr.Organization}");
            }


                Console.ReadKey();
        }
    }
}
