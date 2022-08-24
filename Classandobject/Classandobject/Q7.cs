using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classandobject
{
    internal class Q7
    {

        public string Name { get; set; }
        private int accno;
        private string type;
        public int balance=0;

        public int AccNo { get { return accno; } set { accno = value; } }   
        public string Type
        {
            get { return type; }
            set
            {
                if (value == "savings" || value == "current" || value == "salary")
                {
                    type = value;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
        }
        public void initial(string name,int acc,string type,int initial)
        {

            Name = name;
            AccNo = acc;
            Type = type;
            balance = initial;
        }

        public void deposit(int amount)
        {
           if(amount<0)
            {
                throw new ArgumentException(nameof(amount), "amount cant be negative");
            }
            balance+=amount;
        }
        public void withdraw(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException(nameof(amount), "amount cant be negative");
            }
            else if(balance-amount<0)
            {
                throw new InvalidOperationException("Not enough fund left to be withdrawn");
            }
            else
            {
                balance-=amount;
            }
        }
        public void display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Balance: "+balance);
        }

    }
}
