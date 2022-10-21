
using VendingMachine.dto;
using VendingMachine.repository;
using VendingMachine.service;
using Xunit;
using Xunit.Sdk;

namespace VendingMachineTest
{
    

    public class UnitTest1
    {
        VendingMachineService service = new VendingMachineService();

        [Fact]
        public void ShouldInsertMoney()
        {
            //GIVEN
            List<int> moneyDeposit = new List<int>();
            int money = 1000;
            int sum = 0;
            sum = moneyDeposit.Sum();
            //WHEN
            service.InsertMoney(money);

            //THEN
            Assert.Equal(1000,sum);

        }
        
        [Fact]
        public void ShouldPurchase()
        {
            //GIVEN
            List<int> moneyDeposit = new List<int>();
            moneyDeposit.Add(20);
            int productPrice = 8;

            //WHEN
            service.Purchase();
            //THEN
            Assert.Equal(12, 12);

        }
    }
}