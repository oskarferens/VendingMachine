using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.repository;

namespace VendingMachine.dto
{
    internal class CocaCola : ProductRepository
    {
        private string productName;
        private int productPrice;

        public CocaCola(string productName, int productPrice)
        {
            this.productName = productName;
            this.productPrice = productPrice;
        }

        public override void Examine()
        {
            Console.WriteLine("Can of soda - 8sek");
        }

        public override void Use()
        {
            Console.WriteLine("Shake, open, sip");
        }
    }
}
