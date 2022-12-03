using Microsoft.Win32.SafeHandles;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace SmartphoneShop.Tests
{
    [TestFixture]
    public class SmartphoneShopTests
    {
        [SetUp]
        public void SetUp()
        {

        }

        [TestCase(0)]
        [TestCase(5)]
        [TestCase(10)]
        public void SetValidConstructor(int capacity)
        {
            var shop = new Shop(capacity);
            Assert.AreEqual(capacity, shop.Capacity);
        }

        [TestCase(0)]
        [TestCase(80)]
        [TestCase(1000)]
        public void InitiliazingNewPhoneListViaConstructor(int capacity)
        {
            var shop = new Shop(capacity);

            Assert.IsNotNull(shop.Count);
        }

        [TestCase(-1)]
        [TestCase(-10)]
        [TestCase(-1000)]
        public void NonValidCapacityThrowsException(int capacity)
        {
            Assert.Throws<ArgumentException>(() => new Shop(capacity), "Invalid capacity.");
        }

        [Test]
        public void ValidAddMethod()
        {
            int capacity = 10;
            string modelName = "Samsung";
            int maximumBatteryCharge = 100;

            int expectedOutput = 1;

            var smartphone = new Smartphone(modelName, maximumBatteryCharge);
            var shop = new Shop(capacity);
            shop.Add(smartphone);

            Assert.AreEqual(expectedOutput, shop.Count);

        }

        [Test]
        public void AddSmartPhoneAlreadyExistThrowsExceptio()
        {
            int capacity = 10;
            string modelName = "Samsung";
            int maximumBatteryCharge = 100;

            var smartphone = new Smartphone(modelName, maximumBatteryCharge);
            var shop = new Shop(capacity);

            shop.Add(smartphone);
            Assert.Throws<InvalidOperationException>(() => shop.Add(smartphone), $"The phone model {smartphone.ModelName} already exist.");

        }

        [Test]
        public void AddSmartPhoneWithFullCapacityOfShop()
        {
            int capacity = 2;
            string modelName = "Samsung";
            string secondModelName = "Nokia";
            string thirdModelName = "Iphone";
            int maximumBatteryCharge = 100;

            var smartphone1 = new Smartphone(modelName, maximumBatteryCharge);
            var smartphone2 = new Smartphone(secondModelName, maximumBatteryCharge);
            var smartphone3 = new Smartphone(thirdModelName, maximumBatteryCharge);
            var shop = new Shop(capacity);

            shop.Add(smartphone1);
            shop.Add(smartphone2);

            Assert.Throws<InvalidOperationException>(() => shop.Add(smartphone3), "The shop is full.");


        }

        [TestCaseSource("ValidSmartPhones")]
        public void RemoveSmartPhoneSuccesfull(Smartphone[] smartphones,int capacity)
        {
            var shop = new Shop(capacity);

            foreach (var smartphone in smartphones)
            {
                shop.Add(smartphone);
            }

            int expectedOutput = shop.Count - 1;
            shop.Remove("Samsung");
            Assert.AreEqual(expectedOutput, shop.Count);
        }

        [TestCaseSource("ValidSmartPhones")]
        public void RemoveSmartPhoneNotExistThrowsException(Smartphone[] smartphones, int capacity)
        {
            var shop = new Shop(capacity);

            foreach (var smartphone in smartphones)
            {
                shop.Add(smartphone);
            }
            // here not sure about name of removing??
            Assert.Throws<InvalidOperationException>(() => shop.Remove("Motorolla"), $"The phone model Motorolla doesn't exist.");

        }

        [TestCase(10)]
        public void TestPhoneMethodSuccesfull(int capacity)
        {
            var shop = new Shop(capacity);

            var smartphone1 = new Smartphone("PM", 100);

            shop.Add(smartphone1);
            shop.TestPhone("PM", 55);

            int expectedOutput = 45;

            Assert.AreEqual(expectedOutput, smartphone1.CurrentBateryCharge);

        }

        [TestCaseSource("ValidSmartPhones")]
        public void TestPhoneMethodWithNonExistSmartphone(Smartphone[] smartphones, int capacity)
        {
            var shop = new Shop(capacity);

            foreach (var smartphone in smartphones)
            {
                shop.Add(smartphone);
            }
            // here not sure about name of removing??
            Assert.Throws<InvalidOperationException>(() => shop.TestPhone("Motorolla",40), $"The phone model Motorolla doesn't exist.");

        }


        [TestCase(10)]
        public void TestPhoneMethodWithLowBatteryThrowsException(int capacity)
        {
            var shop = new Shop(capacity);

            var smartphone1 = new Smartphone("PM", 64);

            shop.Add(smartphone1);
            
            Assert.Throws<InvalidOperationException>(() => shop.TestPhone("PM", 65), $"The phone model {smartphone1.ModelName} is low on batery.");


        }

        [TestCase(10)]
        public void ChargePhoneMethodSuccessfull(int capacity)
        {
            var shop = new Shop(capacity);

            var smartphone1 = new Smartphone("PM", 100);
            int expectedOutput = smartphone1.MaximumBatteryCharge;

            shop.Add(smartphone1);
            shop.TestPhone("PM", 55);
            shop.ChargePhone("PM");
            int actualOutput = smartphone1.CurrentBateryCharge;

            Assert.AreEqual(expectedOutput, actualOutput);

        }

        [TestCaseSource("ValidSmartPhones")]
        public void ChargePhoneNotExistSmartPhoneThrowsException(Smartphone[] smartphones, int capacity)
        {
            var shop = new Shop(capacity);

            foreach (var smartphone in smartphones)
            {
                shop.Add(smartphone);
            }
            // here not sure about name of removing??
            Assert.Throws<InvalidOperationException>(() => 
            shop.ChargePhone("Motorolla"), $"The phone model Motorolla doesn't exist.");

        }







        private static IEnumerable<TestCaseData> ValidSmartPhones()
        {
            yield return new TestCaseData(new object[] {new Smartphone[]
            {
                new Smartphone("Samsung",100),
                new Smartphone("Nokia",99),
                new Smartphone("Iphone",98),
                new Smartphone("Xiaomi",97),
            },
            10 }
            );
        }

    }
}