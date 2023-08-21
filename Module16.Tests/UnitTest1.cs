namespace Module16.Tests
{
    using Calculator;
   
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AdditionalModuleTest()
        {
            Random rnd = new Random();
            int a = rnd.Next();
            int b = rnd.Next();
            Assert.AreEqual(Calculator.Additional(a, b), a + b);
        }

        [Test]
        public void SubtractionModuleTest()
        {
            Random rnd = new Random();
            int a = rnd.Next();
            int b = rnd.Next();
            Assert.AreEqual(Calculator.Subtraction(a, b), a - b);
        }
        [Test]
        public void MiltiplicationModuleTest()
        {
            Random rnd = new Random();
            int a = rnd.Next();
            int b = rnd.Next();
            Assert.AreEqual(Calculator.Miltiplication(a, b), a * b);
        }
        [Test]
        public void DivisionModuleTest()
        {
            Random rnd = new Random();
            int a = rnd.Next();
            int b = rnd.Next();
            Assert.AreEqual(Calculator.Division(a, b), a / b);
        }
    }
}