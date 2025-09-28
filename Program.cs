namespace _4._TheBasicsOfOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle smallCircle = new(5);

            smallCircle.PrintInfoOfCircle();


            Circle biggerCircle = new(6);

            biggerCircle.PrintInfoOfCircle();


            Triangle testTriangle = new(10, 10, 10, 8);

            testTriangle.PrintInfoOfTriangle();
        }
    }
}
