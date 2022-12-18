using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12DZ_KFU
{
    internal class BankTransaction
    {
        readonly DateTime data = DateTime.Now;
        private decimal summa;
        public decimal Summa // от
        {
            get { return summa; }
            set { summa = value; }
        }
        public BankTransaction(decimal summa)
        {
            Summa = summa;
        }//до сделал свойство
        public void PrintInfo()
        {
            Console.WriteLine($" Date:{data} Sum:{summa}");
        }
        public override string ToString()
        {
            return $"time: {data} money: {Summa}";
        }
    }
}
