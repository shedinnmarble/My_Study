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

            string[] names = { "Svetlana Omelchenko", "Claire O'Donnell", "Sven Mortensen", "Cesar Garcia" };
            IEnumerable<string> FirstSelect = from name in names
                                              let first = name.Split(new char[] { ' ' })[0]
                                              select name.Split(new char[] { ' ' })[0];

            var testZijv = from name in names
                           group name by name into test2
                           select test2;
            foreach (var item in testZijv)
            {
                Console.WriteLine(  item);

            }
            foreach (var item in FirstSelect)
            {
                //Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
