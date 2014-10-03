namespace Test.FeatureClasses
{
    public class Feature2Old
    {
        public Feature2Old(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X
        {
            get;
            set;
        }

        public int Y
        {
            get;
            set;
        }
    }

    public class Feature2New(int x, int y)
    {
        public int X
        {
            get;
        }
        = x;//constructor'da setlenecek

        public int Y
        {
            get;
            set;
        }
        = y;//constructor'da setlenecek

        public int Z
        {
            get;
            set;
        }
        = 123;//constructor'da setlenecek
    }
}
