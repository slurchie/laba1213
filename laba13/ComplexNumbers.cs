using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba13
{
    class ComplexNumbers
    {
        int realnum;
        int imnum;
        public ComplexNumbers(int Realnum, int Imnum)
        {
            realnum = Realnum;
            imnum = Imnum;
        }

        public override bool Equals(object obj)
        {
            if (obj is ComplexNumbers)
            {
                if (realnum == ((ComplexNumbers)obj).realnum && imnum == ((ComplexNumbers)obj).imnum)
                {
                    return true;
                }
            }
            return false;
        }
        public static ComplexNumbers operator +(ComplexNumbers a, ComplexNumbers b)
        {
            int commonRealnum = a.realnum + b.realnum;
            int commonImnum = a.imnum + b.imnum;
            return new ComplexNumbers(commonRealnum, commonImnum);
        }
        public static ComplexNumbers operator -(ComplexNumbers a, ComplexNumbers b)
        {
            int commonRealnum = a.realnum - b.realnum;
            int commonImnum = a.imnum - b.imnum;
            return new ComplexNumbers(commonRealnum, commonImnum);
        }
        public static ComplexNumbers operator *(ComplexNumbers a, ComplexNumbers b)
        {
            int commonRealnum = a.realnum * b.realnum - a.imnum * b.imnum;
            int commonImnum = b.imnum * a.realnum + a.imnum * b.realnum;
            return new ComplexNumbers(commonRealnum, commonImnum);
        }
        public override string ToString()
        {
            return (realnum.ToString() + "+" + 'i' + imnum.ToString());
        }
    }
}

