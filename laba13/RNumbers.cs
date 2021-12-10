using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba13
{
        class RNumbers
        {
            int numenator;
            int denumenator;
            public RNumbers(int Numenator, int Denumenator)
            {
                numenator = Numenator;
                denumenator = Denumenator;
            }
            private void reduce()
            {
                if (numenator % denumenator == 0 && numenator > denumenator)
                {
                    int commonNumber;
                    commonNumber = numenator / denumenator;
                    denumenator = 1;
                    numenator = numenator / commonNumber;
                }
                if (denumenator % numenator == 0 && denumenator > numenator)
                {
                    int commonnumber = denumenator / numenator;
                    numenator = 1;
                    denumenator = denumenator / commonnumber;
                }
            }
            //private int gettoonedenumenator(RNumbers a,RNumbers b)
            //{
            //    if (a.denumenator!=b.denumenator)
            //    {
            //        return a.denumenator * b.denumenator;
            //    }
            //    return a.denumenator;
            //}
            public override bool Equals(object obj)
            {
                if (obj is RNumbers)
                {
                    if (numenator == ((RNumbers)obj).numenator && denumenator == ((RNumbers)obj).denumenator)
                    {
                        return true;
                    }
                }
                return false;
            }
            public static bool operator ==(RNumbers a, RNumbers b)
            {
                if (a.numenator == b.numenator && a.denumenator == b.denumenator)
                {
                    return true;
                }
                return false;
            }
            public static bool operator !=(RNumbers a, RNumbers b)
            {
                if (a.numenator != b.numenator || a.denumenator != b.denumenator)
                {
                    return true;
                }
                return false;
            }
            public static bool operator <(RNumbers a, RNumbers b)
            {
                if (a.denumenator == b.denumenator)
                {
                    if (a.numenator < b.numenator)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (a.numenator * b.denumenator < b.numenator * a.denumenator)
                    {
                        return true;
                    }
                }
                return false;
            }
            public static bool operator >(RNumbers a, RNumbers b)
            {
                if (a.denumenator == b.denumenator)
                {
                    if (a.numenator > b.numenator)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (a.numenator * b.denumenator > b.numenator * a.denumenator)
                    {
                        return true;
                    }
                }
                return false;
            }
            public static RNumbers operator +(RNumbers a, RNumbers b)
            {
                if (a.denumenator == b.denumenator)
                {
                    int commonNumenator;
                    commonNumenator = a.numenator + b.numenator;
                    return new RNumbers(commonNumenator, a.denumenator);
                }
                else
                {
                    int commonDenumenator;
                    commonDenumenator = a.denumenator * b.denumenator;
                    int commonnumenator;
                    commonnumenator = a.numenator * b.denumenator + b.numenator * a.denumenator;
                    RNumbers R = new RNumbers(commonnumenator, commonDenumenator);
                    R.reduce();
                    return R;

                }
            }
            public static RNumbers operator -(RNumbers a, RNumbers b)
            {
                if (a.denumenator == b.denumenator)
                {
                    int commonNumenator;
                    commonNumenator = a.numenator - b.numenator;
                    return new RNumbers(commonNumenator, a.denumenator);
                }
                else
                {
                    int commonDenumenator;
                    commonDenumenator = a.denumenator * b.denumenator;
                    int commonnumenator;
                    commonnumenator = a.numenator * b.denumenator - b.numenator * a.denumenator;
                    RNumbers R = new RNumbers(commonnumenator, commonDenumenator);
                    R.reduce();
                    return R;

                }
            }
            public static RNumbers operator ++(RNumbers n)
            {
                int incNum = n.numenator + n.denumenator;
                return new RNumbers(incNum, n.denumenator);
            }
            public static RNumbers operator --(RNumbers n)
            {
                int incNum = n.numenator - n.denumenator;
                return new RNumbers(incNum, n.denumenator);
            }
            public override string ToString()
            {
                return (numenator.ToString() + "/" + denumenator.ToString());
            }
            public static bool operator <=(RNumbers a, RNumbers b)
        {
            if (a.denumenator == b.denumenator)
            {
                if (a.numenator <= b.numenator)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (a.numenator * b.denumenator <= b.numenator * a.denumenator)
                {
                    return true;
                }
            }
            return false;
            }
        public static bool operator >=(RNumbers a, RNumbers b)
        {
            if (a.denumenator == b.denumenator)
            {
                if (a.numenator >= b.numenator)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (a.numenator * b.denumenator >= b.numenator * a.denumenator)
                {
                    return true;
                }
            }
            return false;
        }
        }
    }

