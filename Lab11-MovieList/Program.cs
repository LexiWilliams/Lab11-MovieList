using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_MovieList
{
    class Program
    {
        public static List<Movie> movies = new List<Movie>
        {
            new Movie("The Lion King", "Animation"),
            new Movie("Mulan","Animation"),
            new Movie("Free Solo","Documentary"),
            new Movie("Role Models", "Comedy"),
            new Movie("Blackfish","Documentary"),
            new Movie("Zombieland","Comedy"),
            new Movie("Aladdin","Animation"),
            new Movie("The Hangover","Comedy"),
            new Movie("Food, inc","Documentary"),
            new Movie("Tangled","Animation")
        };

        static void Main(string[] args)
        {

            List<Movie> moviesAlphabetical = Movie.Alphebatize(movies);
            bool runAgain = true;
            while (runAgain)
            {
                int category = Movie.ChooseCategory(moviesAlphabetical, "Welcome to the movie list. There are 10 movies in this list." +
                    "\nWhich category would you like to see movies for?");
                Movie.PrintByCategory(category, moviesAlphabetical);
                runAgain = Movie.RunAgain("Would you like to see movies in another category?\nType yes to choose another category, " +
                    "type no to quit.");
            }



        }

    }
}
    

