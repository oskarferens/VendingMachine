using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.repository;

namespace VendingMachine.dto
{
    public class Kex : ProductRepository
    {
        public string productName { get; set; }
        public int productPrice { get; set; }

        public Kex(string productName, int productPrice)
        {
            this.productName = "Kex";
            this.productPrice = 22;
        }


        public override void Examine()
        {
            Console.WriteLine("chocolate bar - 22sek");
        }

        public override void Use()
        {
            Console.WriteLine("Open and eat");
        }
    }
}
