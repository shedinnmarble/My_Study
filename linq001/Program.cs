using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq001
{
    class Program
    {
        static void Main(string[] args)
        {

            // Specify the data source.
            int[] scores = new int[] { 97, 92, 81, 60 };

            // Define the query expression.
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                orderby score descending
                select score;

            //var scoreQ = from score in scores
            //             where score > 80
            //             select score;

            

            //foreach (int i in scoreQ)
            //{
            //    Console.WriteLine(i + ",");
            //}

            IEnumerable<string> highScores = from score in scores
                                             where score > 80
                                             orderby score ascending
                                             select string.Format("the high score is{0}", score);
            foreach (string s in highScores)
            {
                //Console.WriteLine(  s);
            }

            int highestScore = (from score in scores
                                where score > 60 
                                orderby score ascending
                                select score).FirstOrDefault();
            Console.WriteLine(highestScore);
            Console.ReadKey();
        }
    }
}
