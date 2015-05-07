using Sqo;

namespace NoSQLDemo.DbFactories
{
    public class SiaqoDbFactory
    {
        private static Siaqodb _instance;

        public static Siaqodb GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Siaqodb(@"c:\databases\");
            }
            return _instance;
        }
    }
}