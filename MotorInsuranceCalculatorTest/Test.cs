using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace MotorInsuranceCalculatorTest
{
    [TestFixture()]
    public class TestQuoteCalculator
    {
        private DateTime now = DateTime.Now;

        [Test()]
        public void Test_GetQuote_ValidWithChauffeurAndYoungestUnder26()
        {
            List<Driver> drivers = new List<Driver>();
			List<DateTime> claims = new List<DateTime>();
			drivers.Add(new Driver("Jim", "Chauffeur", now.AddYears(-25), claims));
            Assert.AreEqual("Your calculated premium is £660", QuoteCalculator.GetQuote(now, drivers));
		}

        [Test()]
        public void Test_GetQuote_ValidWithAccountantAndYoungestOver25()
        {
			List<Driver> drivers = new List<Driver>();
			List<DateTime> claims = new List<DateTime>();
			drivers.Add(new Driver("Jim", "Accountant", now.AddYears(-26), claims));
			QuoteCalculator.GetQuote(now, drivers);
			Assert.AreEqual("Your calculated premium is £405", QuoteCalculator.GetQuote(now, drivers));
		}

        [Test()]
        public void Test_GetQuote_ValidWithChaufferAndSixMonthClaim()
        {
			List<Driver> drivers = new List<Driver>();
			List<DateTime> claims = new List<DateTime>();
            claims.Add(now.AddMonths(-6));
			drivers.Add(new Driver("Jim", "Chauffeur", now.AddYears(-27), claims));
			Assert.AreEqual("Your calculated premium is £594", QuoteCalculator.GetQuote(now, drivers));
        }

        [Test()]
        public void Test_GetQuote_ValidWithAccountantAndTwoYearClaim()
        {
			List<Driver> drivers = new List<Driver>();
			List<DateTime> claims = new List<DateTime>();
            claims.Add(now.AddYears(-2));
			drivers.Add(new Driver("Jim", "Accountant", now.AddYears(-23), claims));
			QuoteCalculator.GetQuote(now, drivers);
			Assert.AreEqual("Your calculated premium is £594", QuoteCalculator.GetQuote(now, drivers));
		}


        [Test()]
        public void Test_GetQuote_StartDateInPast()
        {
			List<Driver> drivers = new List<Driver>();
			List<DateTime> claims = new List<DateTime>();
			drivers.Add(new Driver("Jim", "Accountant", now.AddYears(-28), claims));
			QuoteCalculator.GetQuote(now, drivers);
			Assert.AreEqual("Policy Declined:\n  Start Date of Policy", QuoteCalculator.GetQuote(now.AddDays(-1), drivers));
        }

        [Test()]
        public void Test_GetQuote_NoDrivers()
        {
			List<Driver> drivers = new List<Driver>();
			List<DateTime> claims = new List<DateTime>();
			QuoteCalculator.GetQuote(now, drivers);
			Assert.AreEqual("Policy Declined:\n  There are no drivers on the policy", QuoteCalculator.GetQuote(now, drivers));
        }

        [Test()]
        public void Test_GetQuote_DriverUnder21()
        {
			List<Driver> drivers = new List<Driver>();
			List<DateTime> claims = new List<DateTime>();
			drivers.Add(new Driver("Jim", "Accountant", now.AddYears(-20), claims));
			QuoteCalculator.GetQuote(now, drivers);
			Assert.AreEqual("Policy Declined:\n  Age of Youngest Driver", QuoteCalculator.GetQuote(now, drivers));
        }

        [Test()]
        public void Test_GetQuote_DriverOver75()
        {
			List<Driver> drivers = new List<Driver>();
			List<DateTime> claims = new List<DateTime>();
			drivers.Add(new Driver("Jim", "Accountant", now.AddYears(-76), claims));
			QuoteCalculator.GetQuote(now, drivers);
			Assert.AreEqual("Policy Declined:\n  Age of Oldest Driver", QuoteCalculator.GetQuote(now, drivers));
		}


        [Test()]
        public void Test_GetQuote_DriverMoreThanTwoClaims()
        {
			List<Driver> drivers = new List<Driver>();
			List<DateTime> claims = new List<DateTime>();
            claims.Add(now);
            claims.Add(now);
            claims.Add(now);
			drivers.Add(new Driver("Jim", "Accountant", now.AddYears(-25), claims));
			QuoteCalculator.GetQuote(now, drivers);
            Assert.AreEqual("Policy Declined:\n  Driver has more than 2 claims (Jim)", QuoteCalculator.GetQuote(now, drivers));
        }

        [Test()]
        public void Test_GetQuote_PolicyMoreThanThreeClaims()
        {
			List<Driver> drivers = new List<Driver>();
			List<DateTime> claims = new List<DateTime>();
			claims.Add(now);
			claims.Add(now);
			drivers.Add(new Driver("Jim", "Accountant", now.AddYears(-25), claims));
			drivers.Add(new Driver("Jim", "Accountant", now.AddYears(-25), claims));
			QuoteCalculator.GetQuote(now, drivers);
			Assert.AreEqual("Policy Declined:\n  Policy has more than 3 claims", QuoteCalculator.GetQuote(now, drivers));
        }
    }
}