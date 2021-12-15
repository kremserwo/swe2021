using System;

namespace SingletonExample
{
    class MySingleton
    {

        private static MySingleton INSTANCE;

        /**
         * Private constructor prevents further instantiation
         */
        private MySingleton()
        {

        }

        public static MySingleton GetInstance()
        {
            if(INSTANCE == null)
            {
                INSTANCE = new MySingleton();
            }

            return INSTANCE;
        }

        public void Talk(string what)
        {
            Console.WriteLine(what);
        }


    }
}
