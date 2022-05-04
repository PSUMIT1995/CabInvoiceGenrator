using CabInvoiceGenrator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CabInvoiceGenratorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalTotalFare()
        {
            //Arrange
            CabInvoice cabInvoice = new CabInvoice();

            //Act
            int fare = cabInvoice.CalculateFare(10, 30);
            //Assert
            Assert.AreEqual(130, fare);

        }

        [TestMethod]
        public void CheckMinimumFairAsFive()
        {
            //Arrange
            CabInvoice cabInvoice = new CabInvoice();

            //Act
            double fare = cabInvoice.CalculateFare(0, 0);
            //Assert
            Assert.AreEqual(5, fare);
        }

        [TestMethod]
        public void AddMultipleRideToCheckTotalFair()
        {
            //Arrange
            CabInvoice cabInvoice = new CabInvoice();
            cabInvoice.AddRide(4, 5);
            cabInvoice.AddRide(15, 25);
            var invoiceSummary = cabInvoice.CalculateAggregate();
            //Assert
            Assert.AreEqual(220, invoiceSummary.TotalFare);
        }
        //Invoice Generator should return average fare.
        [TestMethod]
        public void AddMultipleRideToCheckAvgFare()
        {
            CabInvoice cabInvoice = new CabInvoice();
            cabInvoice.AddRide(4, 5);
            cabInvoice.AddRide(15, 25);
            var invoiceSummary = cabInvoice.CalculateAggregate();
            Assert.AreEqual(110, invoiceSummary.AvgFare);
        }
    }
}