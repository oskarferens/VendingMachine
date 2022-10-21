using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.dto;

namespace VendingMachine.repository
{
    public interface VendingReposiory
    {
        public void Purchase();
        public void ShowAll();
        public void InsertMoney(int money);
        public void EndTransaction();
    }
}
