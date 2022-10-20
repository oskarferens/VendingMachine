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
    internal class VendingMachineService : VendingReposiory
    {
        Kex kex;
        CocaCola cocacola = new CocaCola("CocaCola", 8);
        SaltSticks saltSticks = new SaltSticks("Salt Sticks", 10);
        List<int> moneyDeposit = new List<int>();
        List<Object> cartList = new List<Object>();

        public void PrintMenu()
        {
            Console.WriteLine("Enter your selection: ");
            Console.WriteLine("1 - show available products");
            Console.WriteLine("2 - insert money");
            Console.WriteLine("3 - choose the product");
            Console.WriteLine("4 - finalize order");
            Console.WriteLine("0 - QUIT.");
            Console.WriteLine("");
            Console.WriteLine("Saldo: ");
            showSaldo();
        }

        public void ShowAll()
        {

            Console.WriteLine(kex);
            Console.WriteLine(cocacola);
            Console.WriteLine(saltSticks);
        }

        public void InsertMoney(int money)
        {
            Console.WriteLine("Write the amount you wan to put");
            Console.WriteLine("Available denominations 1kr, 5kr, 10kr, 20kr, 50kr, 100kr, 500kr, 1000kr");
            money = Convert.ToInt32(Console.ReadLine());
            switch (money)
            {
                case (1):
                    moneyDeposit.Add(1);
                    break;
                case (5):
                    moneyDeposit.Add(5);
                    break;
                case (10):
                    moneyDeposit.Add(10);
                    break;
                case (20):
                    moneyDeposit.Add(20);
                    break;
                case (50):
                    moneyDeposit.Add(50);
                    break;
                case (100):
                    moneyDeposit.Add(100);
                    break;
                case (500):
                    moneyDeposit.Add(500);
                    break;
                case (1000):
                    moneyDeposit.Add(1000);
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }

        public void PickTheProduct(int userInput)
        {
            Console.WriteLine(" Press 1 for Kex \n Press 2 for CocaCola \n Press 3 for Salt Sticks");
            userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == 1)
            {
                cartList.Add(15);
            } 
            else if (userInput == 2)
            {
                cartList.Add(8);
            } 
            else if (userInput == 3)
            {
                cartList.Add(10);
            } 
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

        public void Purchase()
        {
            int moneyTotal = moneyDeposit.Count;
            int moneyNeeded = cartList.Count;
            Controller controller = new Controller();

            if (moneyNeeded > moneyTotal)
            {
                Console.WriteLine("Set " + (moneyNeeded - moneyTotal) + "sek more.");
            } 
            else if (moneyNeeded < moneyTotal)
            {
                Console.WriteLine("Here is your rest: " + (moneyTotal - moneyNeeded) + "sek.");
                EndTransaction();
            }
        }

        public void EndTransaction()
        {
            Console.WriteLine("Thank you and welcome again!");
        }

        public void showSaldo ()
        {
            int sum = 0;
            sum = moneyDeposit.Sum();
            Console.WriteLine(sum);
        }
    }
}
