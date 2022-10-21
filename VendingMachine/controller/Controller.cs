using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.dto;
using VendingMachine.service;

namespace VendingMachine.controller
{
    internal class Controller
    {
        public static void StartApplication()
        {
            VendingMachineService service = new VendingMachineService();
            bool working = true;
            while (working)
            {
                service.PrintMenu();
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == 1)
                {
                    service.ShowAll();
                }
                else if (userInput == 2)
                {
                    service.InsertMoney(userInput);
                }
                else if (userInput == 3)
                {
                    service.PickTheProduct(userInput);
                    service.Purchase();
                }
                else if (userInput == 4)
                {
                    service.EndTransaction();
                    working = false;
                } else { 
                    Console.WriteLine("Purchase denied, try again!");
                    working = false;
                }
            }
        }
    }
}
