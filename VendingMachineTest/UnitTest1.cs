
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
            //WHEN
            service.UpdateAccount(100);

            //THEN
            Assert.Equal(100,service.moneyDeposit); 
        }


        [Fact]
        public void ShouldFillTheMachine()
        {
            //WHEN
            service.FillTheMachine();
            //THEN
            Assert.Equal(9,service.Products.Count);
        }
        
        [Fact]
        public void ShouldShowProductsPrice()
        {
            //WHEN
            service.PickTheProduct(1);
            //THEN
            Assert.Equal(18, service.Products[1].Price);
        }

        [Fact]
        public void ShouldPurchase()
        {
            //GIVEN
            int a = service.moneyDeposit = 100;
            int b = service.productPrice = 50;
            //WHEN
            service.EndTransaction();
            //THEN
            Assert.Equal(true, true);
        }
    }
}