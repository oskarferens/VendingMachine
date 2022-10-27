using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.repository;

namespace VendingMachine.dto
{
    public class SweetSnacks : Product
    {

        public SweetSnacks(string name, int price, string description) : base(name, price, description) { }

        public override void Examine(Product product)
        {
            Console.WriteLine($"{product.Name}, {product.Price} sek, {product.Description}");
        }

        public override void Use(Product product)
        {

            Console.WriteLine($"{product.Name} - Enjoy your snack!");
        }
    }
}
