using System;

namespace Test.FeatureClasses
{
    public class Feature8Old
    {
        public string GetText()
        {
            try
            {
                throw new Exception("Me");
            }
            catch (Exception ex) 
            {
                //log exception

                if (ex.Message == "You")
                {
                    return "You";
                }
                else if (ex.Message == "Me")
                {
                    return "Me";
                }
                else
                {
                    throw; 
                    //throw ex; //bu kullanım ile stack trace kayboluyordu
                }
            }
        }
    }

    public class Feature8New
    {
        public string GetText()
        {
            try
            {
                throw new Exception("Me");
            }
            //Bu kullanım ile exception koşula uymadığı hiçbir durumda catch'e girmeyecek. Dolayısı ile istense de stack trace kaybolmayacak.
            catch (Exception ex) if (LogException(ex))
            {
            }
            catch (Exception ex) if (ex.Message == "You")
            {
                return "You";
            }
            catch (Exception ex) if (IsMe(ex.Message))
            {
                return "Me";
            }

            return "";
        }

        private bool LogException(Exception ex)
        {
            //log exception

            return false;//false döndüğü için exception catch e düşmeden loglanmış olacak.
        }

        private bool IsMe(string s)
        {
            if (s == "Me")
            {
                return true;
            }

            return false;
        }
    }
}
