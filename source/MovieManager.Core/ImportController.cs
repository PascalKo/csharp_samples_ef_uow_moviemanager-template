using MovieManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using Utils;

namespace MovieManager.Core
{
    public class ImportController
    {
        const string Filename = "movies.csv";

        /// <summary>
        /// Liefert die Movies mit den dazugehörigen Kategorien
        /// </summary>
        public static IEnumerable<Movie> ReadFromCsv()
        {
            string[] lines = File.ReadAllLines(Filename);


            for (int i = 0; i < lines.Length; i++)
            {
                Category category = new Category();

                string[] part = lines[i].Split(';');

                Movie movie = new Movie(part[0], category, Convert.ToInt32(part[2]), Convert.ToInt32(part[3]), Convert.ToInt32(part[4]));
            }
            return default;
        }
    }
}
