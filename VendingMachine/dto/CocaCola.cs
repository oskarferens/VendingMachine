using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.repository;

namespace VendingMachine.dto
{
    public class CocaCola : ProductRepository
    {
        public string productName { get; set; }
        public int productPrice { get; set; }

        public CocaCola(string productName, int productPrice)
        {
            this.productName = "Cocacola";
            this.productPrice = 8;
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
