using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab11_MovieList
{
    class Movie
    {
        #region fields and properties
        public string Title { get; set; }
        public string Category { get; set; }
        #endregion
        #region Constructors
        public Movie(string title, string category)
        {
            this.Title = title;
            this.Category = category;
        }
        #endregion
        #region Methods
        public static List<Movie> Alphebatize(List<Movie> movies)
        {

            var moviesAlphabetical = movies.OrderBy(t => t.Title);
            return moviesAlphabetical.ToList<Movie>();
        }
        public static void PrintMovies(List<Movie> movies, string message)
        {
            Console.WriteLine(message);
            int count = 0;
            foreach (Movie x in movies)
            {
                count++;
                Console.WriteLine($"{count}.{x.Title}");
            }
            Console.WriteLine("");
        }
        public static int ChooseCategory(List<Movie> movies, string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("1: Animations\n2.Comedies\n3.Documentaries\n");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int categoryNumber))
            {
                if (categoryNumber > 0 && categoryNumber <= 3)
                {
                    return categoryNumber;
                }
            }
            Console.WriteLine("That input is invalid");
            return ChooseCategory(movies, message);
        }
        public static void PrintByCategory(int category, List<Movie> movies)
        {
            Console.WriteLine("");
            if (category == 1)//animations
            {
                Console.WriteLine("Animations:");
                foreach (Movie x in movies)
                {
                    if (x.Category == "Animation")
                    {
                        Console.WriteLine(x.Title);
                    }
                }
                Console.WriteLine("");
            }
            else if (category == 2)//comedies
            {
                Console.WriteLine("Comedies:");
                foreach (Movie x in movies)
                {
                    if (x.Category == "Comedy")
                    {
                        Console.WriteLine(x.Title);
                    }
                }
                Console.WriteLine("");
            }
            else if (category == 3)//documentaries
            {
                Console.WriteLine("Documentaries:");
                foreach (Movie x in movies)
                {
                    if (x.Category == "Documentary")
                    {
                        Console.WriteLine(x.Title);
                    }
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("That input is invalid");
                PrintByCategory(category, movies);
            }
        }
        public static bool RunAgain(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine().ToLower();
            if(input=="yes")
            {
                Console.WriteLine("");
                return true;
            }
            else if(input == "no")
            {
                Console.WriteLine("Goodbye.");
                return false;
            }
            else
            {
                Console.WriteLine("That input is invalid");
                return RunAgain(message);
            }
        }
    }
    #endregion



}

