using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    internal class Member
    {
        
            string name;
            int memberId;
            List<string> booksBought;
            int numberOfBooksBought;
            double moneyInBank;
            double amountSpent;

            public Member(string name, int memberId, double moneyInBank)
            {
                this.name = name;
                this.memberId = memberId;
                this.moneyInBank = moneyInBank;
                this.booksBought = new List<string>();
                this.numberOfBooksBought = 0;
                this.amountSpent = 0;
            }


        public string GetName()
        {
           return  name;
        }
        public void SetName(string newName) { name = newName; }

            public int GetMemberID() {
            return memberId;}

            public double GetMoneyInBank() { return moneyInBank;}
            public void SetMoneyInBank(double amount) { moneyInBank = amount;}

            public double GetAmountSpent()  {return amountSpent;}

            public int GetNumberOfBooksBought()  {
            return numberOfBooksBought;
        }

           
            public bool BuyBook(string bookTitle, double price)
            {
                if (moneyInBank >= price)
                {
                    booksBought.Add(bookTitle);
                    numberOfBooksBought++;
                    amountSpent += price;
                    moneyInBank -= price;
                    Console.WriteLine($"Book '{bookTitle}' purchased successfully!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Insufficient balance! Purchase failed.");
                    return false;
                }
            }
            public void DisplayMember()
            {
                Console.WriteLine($"Member ID: {memberId}");
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Money in Bank: ${moneyInBank}");
                Console.WriteLine($"Amount Spent: ${amountSpent}");
                Console.WriteLine($"Books Bought ({numberOfBooksBought}): {string.Join(", ", booksBought)}");
                
            }
        
    }
}
