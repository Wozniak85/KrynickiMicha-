internal class Program
{

        public delegate void MySampleDelegate(int number);
        public static class MyDelegate
    {
        public static MySampleDelegate mySampleDelegate;

        static void Main(string[] args)
        {
            mySampleDelegate += SampleMethod;

            mySampleDelegate?.Invoke(10);
        }

        public static void SampleMethod(int number)
        {
            Console.WriteLine("Podana liczba: " + number);
        }
    }
}