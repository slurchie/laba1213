using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Commercial

{
		public class Bank
		{
			private Hashtable hashtable = new Hashtable();//Представляет коллекцию пар «ключ-значение»,
														  //которые упорядочены по хэш-коду ключа.
			public int CreateAccount()
			{
				BankAccount opened = new BankAccount();
				//По индексу словаря  добавляем объект класса Account
				hashtable[opened.Index] = opened;
				return opened.Index;
			}
			public int CreateAccount(Type typeAccount, decimal balance) //свойство создающее новый акк
			{
				BankAccount opened = new BankAccount(typeAccount, balance);
				hashtable[opened.Index] = opened;
				return opened.Index;
			}
			public int CreateAccount(int id, Type typeAccount, decimal balance)
			{
				BankAccount opened = new BankAccount(id, typeAccount, balance);
				hashtable[opened.Index] = opened;
				return opened.Index;
			}
			public void DeleteAccount(int number) //метод удаляющий акк
			{
				hashtable.Remove(number);
			}
			public List<BankAccount> GetListAccount()//создаётся лист аккаунтов,
													 //в нём проходятся по каждому элементу списка по значению
													 //если находит значени, то добавляется новый элемнт в список

			{
				List<BankAccount> accounts = new List<BankAccount>();
				foreach (var item in hashtable.Values)
				{
					if (item is BankAccount)
					{
						accounts.Add((BankAccount)item);
					}
				}
				return accounts;
			}
			public BankAccount this[int Indexator]//
			{
				get
				{
					return (BankAccount)hashtable[Indexator]; //ра
				}
				set
				{

				}
			}


		}
	}

