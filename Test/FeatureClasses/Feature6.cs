namespace Test.FeatureClasses
{
    public class Feature6Old
    {
        private int x = 3;
        private int y = 5;

        public int GetValue()
        {
            return x * y;
        }
    }

    public class Feature6New
    {
        private int x = 3;
        private int y = 5;

        public int GetValue() => x * y;
    }
}
