﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.controller;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            Controller.StartApplication();
        }
    }
}
