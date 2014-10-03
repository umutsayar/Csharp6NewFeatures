namespace Test.FeatureClasses
{
    public class Feature7Old
    {
        public int? GetValue()
        {
            //TestClass testClass1 = null;
            TestClass testClass1 = new TestClass();

            if (testClass1 != null)
            {
                return testClass1.field;
            }
            else
            {
                return null;
            }
        }
    }

    public class Feature7New
    {
        public int? GetValue()
        {
            //TestClass testClass1 = null;
            TestClass testClass1 = new TestClass();

            return testClass1?.field;
        }
    }

    public class TestClass
    {
        public int? field = 12;
    }
}
