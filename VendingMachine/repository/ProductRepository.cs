using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.repository
{
    public abstract class ProductRepository
    {
        public abstract void Examine();
        public abstract void Use();
    }
}
