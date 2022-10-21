using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.repository;

namespace VendingMachine.dto
{
    public class SaltSticks : ProductRepository
    {
        public string productName { get; set; }
        public int productPrice { get; set; }

        public SaltSticks(string productName, int productPrice)
        {
            this.productName = "SaltSticks";
            this.productPrice = 56;
        }

        public override void Examine()
        {
            Console.WriteLine("Salty snack - 56sek");
        }

        public override void Use()
        {
            Console.WriteLine("Open and eat");
        }
    }
}
