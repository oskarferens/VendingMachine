using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.controller;
using VendingMachine.dto;
using VendingMachine.repository;

namespace VendingMachine.service
{
    public class VendingMachineService : VendingReposiory
    {
        private readonly int[] moneyDenominations = { 1000, 500, 100, 50, 20, 10, 5, 1 };
        public List<Product> Products = new();
        public int moneyDeposit { get; set; }
        public int productPrice = 0;


    public void PrintMenu()
        {
            Console.WriteLine("Enter your selection: ");
            Console.WriteLine("1 - show available products");
            Console.WriteLine("2 - insert money");
            Console.WriteLine("3 - choose the product");
            Console.WriteLine("4 - finalize order");
            Console.WriteLine("0 - QUIT.");
            Console.WriteLine("");
            Console.WriteLine("Saldo: " + moneyDeposit);
        }

        public void FillTheMachine()
        {
            Products.Add(new Kex("Kex", 22, "Chocolate bar"));
            Products.Add(new CocaCola("CocaCola", 15, "A can of soda "));
            Products.Add(new SaltSticks("Salted Sticks", 56, "Small baked pretzels"));
        }

        public void ShowAll()
        {
            for (int i = 0; i < Products.Count; i++)
            {
                Products[i].Examine(Products[i]);
            }
            Console.WriteLine();

        }

        public void InsertMoney(int money)
        {
            Console.WriteLine("Write the amount you want to put");
            Console.WriteLine("Available denominations 1kr, 5kr, 10kr, 20kr, 50kr, 100kr, 500kr, 1000kr");
            money = Convert.ToInt32(Console.ReadLine());
            switch (money)
            {
                case (1):
                    moneyDeposit = moneyDeposit + 1; break;
                case (5):
                    moneyDeposit = moneyDeposit + 5; break;
                case (10):
                    moneyDeposit = moneyDeposit + 10; break;
                case (20):
                    moneyDeposit = moneyDeposit + 20; break;
                case (50):
                    moneyDeposit = moneyDeposit + 50; break;
                case (100):
                    moneyDeposit = moneyDeposit + 100; break;
                case (500):
                    moneyDeposit = moneyDeposit + 500; break;
                case (1000):
                    moneyDeposit = moneyDeposit + 1000; break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }

        public void PickTheProduct(int userChoice)
        {
            Console.WriteLine(" Press 1 for Kex \n Press 2 for CocaCola \n Press 3 for Salt Sticks");
            userChoice = Convert.ToInt32(Console.ReadLine());

            if (userChoice == 1)
            {
                productPrice = Products[0].Price;
            } 
            else if (userChoice == 2)
            {
                productPrice = Products[1].Price;
            } 
            else if (userChoice == 3)
            {
                productPrice = Products[2].Price;
            } 
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

        public void Purchase()
        {
            if (productPrice == moneyDeposit)
            {
                Console.WriteLine("You'll get back: " + (moneyDeposit - productPrice) + "sek.");
                Console.WriteLine("Press 4 to confirm transaction");
            }
            else if (productPrice > moneyDeposit)
            {
                Console.WriteLine("Set " + (productPrice - moneyDeposit) + "sek more.");
            } 
            else if (productPrice < moneyDeposit)
            {
                Console.WriteLine("You'll get back: " + (moneyDeposit - productPrice) + "sek.");
                Console.WriteLine("Press 4 to confirm transaction");
            }
        }

        public void EndTransaction()
        {
            if (moneyDeposit >= productPrice)
            {
                Console.WriteLine("Complete! Thank you and welcome again!");
                
            } else
            {
                Console.WriteLine("Can't finalize transaction. Not enough founds");
            }
        }
    }
}
