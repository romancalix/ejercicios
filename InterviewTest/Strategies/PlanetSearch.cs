namespace InterviewTest.Strategies
{
    public class PlanetSearch
    {

        public static double GetSpottingMetric(int[] results)
        {
            double minSum = results[0] + results[1] + results[2];

            for (int i = 1; i <= results.Length - 3 ; i++) 
            {
                double currentSum = results[i] + results [i + 1] + results[i+2];
                
                if (currentSum < minSum) 
                {
                    minSum = currentSum;
                }
                
            }
            return minSum / 3.0;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(GetSpottingMetric(new int[] { 2, 1, 3, 0, 1, 5, 0, 0, 6, 7 }));
        }
    }
}