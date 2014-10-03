namespace Test.FeatureClasses
{
    public class Feature4Old
    {
        public int GetValue(string input)
        {
            int result;
            return int.TryParse(input, out result) ? result : 0;
        }
    }

    public class Feature4New
    {
        public int GetValue(string input)
        {
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            else
            {
                return 0;
            }

            //result = 5; //this will give an error because of scope rule
        }
    }
}
