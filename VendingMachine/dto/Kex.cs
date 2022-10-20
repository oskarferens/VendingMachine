using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.repository;

namespace VendingMachine.dto
{
    internal class Kex : ProductRepository
    {
        private string productName = "Kex";
        private int productPrice = 15;

    public Kex(string productName, int productPrice)
        {
            this.productName = productName;
            this.productPrice = productPrice;
        }


        public override void Examine()
        {
            Console.WriteLine("chocolate bar - 15sek");
        }

        public override void Use()
        {
            Console.WriteLine("Open and eat");
        }
    }
}
