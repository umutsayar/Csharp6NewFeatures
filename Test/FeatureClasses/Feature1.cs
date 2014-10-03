namespace Test.FeatureClasses
{
    public class Feature1Old
    {
        private int x, y;

        public Feature1Old(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Feature1New(int x, int y)
    {
        private int _x = x;
        private int _y = y;

        //default constructor ancak primary constructor çağırılarak kullanılabilir
        public Feature1New() : this(1,2)
        {
        }

        //overload constructor ancak primary constructor çağırılarak kullanılabilir
        public Feature1New(int a) : this(a, 2)
        {
        }

        //bu şekilde bir overload constroctor tanımlanamaz. Primary constructor ile çakışıyor
        //public Feature1New(int a, int b)
        //{
        //}
    }
}
