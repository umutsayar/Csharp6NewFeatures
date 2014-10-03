namespace Test.FeatureClasses
{
    public class Feature5Old
    {
        private int x = 3;
        private int y = 5;

        public int Value
        {
            get
            {
                return x * y;
            }
        }
    }

    public class Feature5New
    {
        private int x = 3;
        private int y = 5;

        public int Value => x * y;
    }
}
    