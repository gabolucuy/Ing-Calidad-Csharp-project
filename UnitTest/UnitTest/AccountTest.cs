using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace UnitTest
{
   
  [TestFixture]
  public class AccountTest
  {
    [Test]
    public void TestTransferFunds()
    {
      Account source = new Account();
      source.Deposit(200.00F);
      Account destination = new Account();
      destination.Deposit(150.00F);

      source.TransferFunds(destination, 100.00F);
      Assert.AreEqual(250.00F, destination.Balance);
      Assert.AreEqual(100.00F, source.Balance);
	
    }
        
    }
}
