
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
            //WHEN
            service.UpdateAccount(100);

            //THEN
            Assert.Equal(100,service.moneyDeposit); 
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
        
    }
}