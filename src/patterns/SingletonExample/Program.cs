namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MySingleton singleton = MySingleton.GetInstance();

            singleton.Talk("Hello World");
        }
    }
}
