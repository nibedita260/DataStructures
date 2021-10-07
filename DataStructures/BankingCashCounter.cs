using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class BankCashCounter
    {
        readonly LinkedListQueue<string> queue = new LinkedListQueue<string>();
        public static int choice;
        public void CashCounter()
        {
            Console.WriteLine("Enter a limit Number of People who can create account in the Bank");
            int number = Convert.ToInt16(Console.ReadLine());
            string[] Name = new string[number];
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine((i+1)+". Enter Person Name");
                string customer = Console.ReadLine();
                queue.Enqueue(customer);
                Name[i] = customer;
            }
            foreach (var customer in Name)
            {
                Console.WriteLine("People who are in Queue:" + customer);
            }
            double Amount = 1000;
            int choice;
                Console.WriteLine("enter your name to deposit or withdraw amount to the Bank");
                string name = Console.ReadLine();
                foreach (var customer in Name)
                {
                    if (customer == name)
                    {
                        Console.WriteLine("\n1 : Deposite Money\n2 : Withdraw Money\n3 : Exit\nEnter your choice");
                        choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter Your Deposite Amount");
                                double deposite = Convert.ToDouble(Console.ReadLine());
                                Amount += deposite;
                                Console.WriteLine("Your Bank Balance Has :" + Amount);
                                queue.Dequeue();
                                Console.WriteLine(name + " ,You have successfully deposited and loggedout from the BankTransaction. Visit Again!!!");
                                break;
                            case 2:
                                Console.WriteLine("Enter your Withdraw Amount");
                                double withdraw = Convert.ToDouble(Console.ReadLine());
                                if (withdraw > Amount)
                                {
                                    Console.WriteLine("Your Balance has not sufficient to withdraw.....");
                                }
                                Amount -= withdraw;
                                Console.WriteLine("Your Bank Has :" + Amount);
                                queue.Dequeue();
                                Console.WriteLine(name + " ,you have successfully withdrawed and loggedout from the BankTransaction. Visit Again!!!");
                                break;
                            default:Console.WriteLine("You have entered wrong!!");
                                break;
                        }
                    }
                }
        }
    }
}
