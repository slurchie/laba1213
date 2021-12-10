using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Commercial;

namespace laba13
{

	class Program
{
	static void Main(string[] args)
	{
		Bank bank = new Bank();
		bank.CreateAccount(4364, Commercial.Type.Сберегательный, 1000);

	}
}
}


