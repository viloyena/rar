using PredatorsApp;

namespace TestPredators
{
    [TestClass]
    public class TestPredators
    {
        [TestMethod]
        public void TestMethod_CatConstructLegs()
        {
            Cat cat = new Cat(4, 2, new DateOnly(2019, 3, 9), "Mouse", "Tom"); // input
            int expected = 4;
            int actual = cat.LegsCount;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod_CatConstructEyes()
        {
            Cat cat = new Cat(4, 2, new DateOnly(2019, 3, 9), "Mouse", "Tom"); // input
            int expected = 2;
            int actual = cat.EyesCount;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod_CatConstructBirthDate()
        {
            Cat cat = new Cat(4, 2, new DateOnly(2019, 3, 9), "Mouse", "Tom); // input
            DateOnly expected = new(2019, 3, 9);
            DateOnly actual = cat.BirthDate;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod_CatConstructMainBounty()
        {
            Cat cat = new Cat(4, 2, new DateOnly(2019, 3, 9), "Mouse", "Tom"); // input
            string expected = "Mouse";
            string actual = cat.MainBounty;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod_CatConstructName()
        {
            Cat cat = new Cat(4, 2, new DateOnly(2019, 3, 9), "Mouse", "Tom"); // input
            string expected = "Markiz";
            string actual = cat.Name;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod_CatAge()
        {
            Cat cat = new Cat(4, 2, new DateOnly(2019, 3, 9), "Mouse", "Tom"); // input
            int expected = 6;
            int actual = cat.Age;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod_CatCatchThePray()
        {
            Cat cat = new Cat(4, 2, new DateOnly(2019, 3, 9), "Mouse", "Tom"); // input
            string expected = "Catch Mouse";
            string actual = cat.CatchThePray();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod_CatEatThePray()
        {
            Cat cat = new Cat(4, 2, new DateOnly(2019, 3, 9), "Mouse", "Tom"); // input
            string expected = "Eaten 2 Mouse";
            string actual = cat.EatThePray(2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod_CatPurr()
        {
            Cat cat = new Cat(4, 2, new DateOnly(2019, 3, 9), "Mouse", "Tom"); // input
            string expected = "purr";
            string actual = cat.Purr();
            Assert.AreEqual(expected, actual);
        }
    }
}