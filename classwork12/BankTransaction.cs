using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork12
{
    class BankTransaction
    {
        readonly DateTime time; //readonly означает чтоприсвоение значения полю
                                //может происходить только при объявлении или в конструкторе
                                //этого класса
        readonly decimal sum;
        public BankTransaction(decimal sum)
        {
            this.sum = sum;
            time = DateTime.Now;
        }
        public override string ToString() //переопределяем чтобы было легче использовать при объявлении
        {
            return $"{time} {sum}";
        }
    }
}
