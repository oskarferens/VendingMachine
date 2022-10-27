using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;
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
            Products.Add(new SweetSnacks("Kex", 22, "Chocolate bar"));
            Products.Add(new SweetSnacks("Mars", 18, "Chocolate bar with carmel "));
            Products.Add(new SweetSnacks("Snickers", 24, "Chocolate bar with peanuts"));
            Products.Add(new Beverage("CocaCola", 15, "A can of cocacolastic soda "));
            Products.Add(new Beverage("Fanta", 13, "A can of fantastic soda "));
            Products.Add(new Beverage("Sprite", 14, "A can of soda"));
            Products.Add(new Snacks("Salted Sticks", 48, "Small baked pretzels"));
            Products.Add(new Snacks("BBQ peanuts", 56, "Sprinkle peanuts"));
            Products.Add(new Snacks("Chips", 38, "Fried potatoes"));
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
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.WriteLine("Your saldo is: " + moneyDeposit);
                
                Console.WriteLine("Write the amount you want to put or press 0 to get back to menu.");
                Console.WriteLine("Available denominations 1kr, 5kr, 10kr, 20kr, 50kr, 100kr, 500kr, 1000kr");
                money = Convert.ToInt32(Console.ReadLine());
                switch (money)
                {
                    case (0):
                        flag = false; break;
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
        }

        public void PickTheProduct(int userChoice)
        {
            Console.WriteLine("Press number to chose the product");
            Console.WriteLine("");

            for (int i = 0; i < Products.Count; i++)
            {
                Console.WriteLine("Press " + i + " for - ");
                Products[i].Examine(Products[i]);
                Console.WriteLine("");
            }

            userChoice = Convert.ToInt32(Console.ReadLine());

            switch (userChoice)
            {
                case (0):
                    productPrice = Products[0].Price;
                    break;
                case (1):
                    productPrice = Products[1].Price;
                    break;
                case (2):
                    productPrice = Products[2].Price;
                    break;
                case (3):
                    productPrice = Products[3].Price;
                    break;
                case (4):
                    productPrice = Products[4].Price;
                    break;
                case (5):
                    productPrice = Products[5].Price;
                    break;
                case (6):
                    productPrice = Products[6].Price;
                    break;
                case (7):
                    productPrice = Products[7].Price;
                    break;
                case (8):
                    productPrice = Products[8].Price;
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }

        public void Purchase()
        {
            int rest = moneyDeposit - productPrice;

            if(moneyDeposit < productPrice)
            {
                EndTransaction();
            } else
            {
                int thousand = (rest / 1000);
                int five_hundred = ((rest % 1000) / 500);
                int one_hundred = ((rest % 500) / 100);
                int fifthy = ((rest % 100) / 50);
                int twenty = ((rest % 50) / 20);
                int ten = ((rest % 20) / 10);
                int five = ((rest % 10) / 5);
                int one = ((rest % 5) / 1);

                Dictionary<string, int> hash = new Dictionary<string, int>();
                hash.Add("thousand", thousand);
                hash.Add("five_hundred", five_hundred);
                hash.Add("one_hundred", one_hundred);
                hash.Add("fifthy", fifthy);
                hash.Add("twenty", twenty);
                hash.Add("ten", ten);
                hash.Add("five", five);
                hash.Add("one", one);

                Console.Clear();
                Console.WriteLine("Your rest is " + rest + "sek and will be returned as follows: ");

                foreach (KeyValuePair<string, int> pair in hash)
                {
                    Console.WriteLine("denomination: " + pair.Key + "  Amount: " + pair.Value);
                }
                Console.WriteLine();
                Console.WriteLine("Press 4 to finalize order");
                Console.WriteLine();
            }
        }

        public void EndTransaction()
        {
            if (moneyDeposit >= productPrice)
            {
                Console.WriteLine("Transaction complete. Thank you and welcome again!");
            } else
            {
                Console.WriteLine("Can't finalize the transaction. Not enough founds.");
                Console.WriteLine("Machine returns " + moneyDeposit + "sek.");
                Console.WriteLine("Try again");
            }
        }
    }
}
