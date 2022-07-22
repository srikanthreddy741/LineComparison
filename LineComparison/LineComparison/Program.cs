

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WellCome To LineComparison");
            MeasureLineLength measureLineLength = new MeasureLineLength(0);

            measureLineLength.MeasuretheLength();
        }
    }
}