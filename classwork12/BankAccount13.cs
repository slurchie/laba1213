using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace classwork12
{
    class BankAccount13
    {
        public enum account { incorrect, saving, current };
        private Queue<BankTransaction> bankTransactions = new Queue<BankTransaction>();
        public string holder { get; private set; }
        public int number { get; private set; }
        public account type { get; private set; }
        public  decimal balance { get; private set; }
        private static int num = 1;
        public BankAccount13(string holder, decimal balance , account type)
        {
            
            this.holder = holder;
            this.balance = balance;
            this.type = type;
            Queue<BankTransaction> bankTransactions = new Queue<BankTransaction>();
        }
        public BankAccount13()
        {

        }
        public BankAccount13(decimal balance, account type)
        {
            this.balance = balance;
            this.type = type;

            IncreaseNum();

        }
        public BankAccount13(decimal balance)
        {
            this.balance = balance;
            IncreaseNum();
        }
        public BankAccount13(account type)
        {
            this.type = type;
            IncreaseNum();
        }
        public void Dispose(string file)
        {
            StreamWriter stream = new StreamWriter(file);
            foreach (BankTransaction item in bankTransactions)
            {
                stream.WriteLine(item.ToString());
            }
            stream.Close();
            GC.SuppressFinalize(stream);

        }
        public void PutItOnTheAccount(decimal temp)
        {
            BankTransaction bankT = new BankTransaction(temp);
            balance += temp;
            bankTransactions.Enqueue(bankT);
        }
        public void WithdrawFromTheAccount(decimal temp)
        {

            if (temp <= balance)
            {
                balance -= temp;
                BankTransaction bankT = new BankTransaction(temp);
                bankTransactions.Enqueue(bankT);
            }
            else if (temp > balance)
            {
                Console.WriteLine("Недостаточно средств");
            }
            else
            {
                Console.WriteLine("Ошибка при вводе баланса");
            }
        }
        public void IncreaseNum()
        {
            number = num++;
        }
        public void Print()
        {
            Console.WriteLine($"Account number: {number}" + $"\n balance: {balance}" + $" \ntype: {type}");
        }
        public void GetBank_Account()
        {
            Console.WriteLine("Введите баланс:");
            bool result = decimal.TryParse(Console.ReadLine(), out decimal temp1);
            if (result)
            {
                balance = temp1;
            }
            else
            {
                Console.WriteLine("Ошибка при вводе баланса");
            }
            Console.WriteLine("Выберите тип счета: saving или current\nВведите 1 или 2");
            result = Int32.TryParse(Console.ReadLine(), out int temp);
            switch (temp)
            {
                case 1:
                    type = account.saving;
                    break;
                case 2:
                    type = account.current;
                    break;
                default:
                    Console.WriteLine("Нужно вводить только 1 или 2");
                    break;
            }
        }
        public void Transfer(BankAccount13 from, decimal sum)
        {
            if (sum <= from.balance)
            {
                from.WithdrawFromTheAccount(sum);
                PutItOnTheAccount(sum);
            }
            else
            {
                Console.WriteLine("не получается");
            }

        }
    }
}