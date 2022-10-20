using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.dto;

namespace VendingMachine.repository
{
    internal interface VendingReposiory
    {
        protected void Purchase();
        protected void ShowAll();
        protected void InsertMoney(int money);
        protected void EndTransaction();
    }
}
