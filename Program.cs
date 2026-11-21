namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }

        public override string ToString()
        {
            return $"Title :  pages";
            //Q3
            int pages = 464;
            int Pages = int.Parse("464");
            //Q4
            try
            {
                int a = 10;
                int b = 0;
                int Result1 = a / b;
                Console.WriteLine(Result1);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }
            //Q5
            int pages1 = 300;
            double result = pages1;

            Console.WriteLine(result);
            //Q6
            double price = 49.99;
            int Result2 = (int)price;

            Console.WriteLine(Result2);
            //Q7
            string pagesText = "464";
            int pages2 = Convert.ToInt32(pagesText);

            Console.WriteLine(pages2);
            //Q8
            //Q9
            int pages3 = 464;
            string PagesText = pages.ToString();

            Console.WriteLine(pagesText);
            Console.WriteLine(pagesText.GetType());
            //Q10



        }
    }
}
