using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.repository;

namespace VendingMachine.dto
{
    internal class SaltSticks : ProductRepository
    {
        private string productName;
        private int productPrice;

        public SaltSticks(string productName, int productPrice)
        {
            this.productName = productName;
            this.productPrice = productPrice;
        }

        public override void Examine()
        {
            Console.WriteLine("Salty snack - 10sek");
        }

        public override void Use()
        {
            Console.WriteLine("Open and eat");
        }
    }
}
