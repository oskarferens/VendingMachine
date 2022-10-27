
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
            bool flag = true;
            //WHEN
            service.InsertMoney(100);
            int result = service.moneyDeposit;

            //THEN
            Assert.Equal(100,result); 
        }

        [Fact]
        public void ShouldPickTheProduct()
        {
            //GIVEN
            service.FillTheMachine();
            //WHEN
            service.PickTheProduct(2);
            //THEN
            Assert.Equal(24,service.Products[3].Price);
        }

        [Fact]
        public void ShouldFillTheMachine()
        {
            //GIVEN
            //WHEN
            service.FillTheMachine();
            //THEN
            Assert.Equal(9,service.Products.Count);
        }
        
        [Fact]
        public void ShouldPurchase()
        {
            //GIVEN
            service.moneyDeposit = 100;
            service.productPrice = 52;
            //WHEN
            int result = service.Purchase();
            //THEN
            Assert.Equal(48,48);
        }
    }
}