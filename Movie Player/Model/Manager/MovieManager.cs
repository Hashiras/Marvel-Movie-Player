

using System.Collections.Generic;
using System.Diagnostics;

namespace Movie_Player.Model.Manager
{
    internal class MovieManager
    {
        private static MovieManager instance;
        private List<Movie> movies;

        private MovieManager()
        {
            movies = new List<Movie>();
        }

        public static MovieManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MovieManager();
                }
                return instance;
            }
        }

        public List<Movie> Movies {
            get { return movies; 
            } 
        }

        public Movie currentMovie
        {
            get
            {
                return movies[0];
            }
        }


        public Movie nextMovie
        {
            get
            {
                return movies[1];
            }
        }

        public void Sort(int EntryNumber)
        {
            Debug.WriteLine("Debug: The current entry number is " + EntryNumber);
            //Adjust to the index
            movies.Sort((movie1, movie2) =>
            {
                int entryNumber1 = (movie1.EntryNumber - EntryNumber + movies.Count) % movies.Count;
                int entryNumber2 = (movie2.EntryNumber - EntryNumber + movies.Count) % movies.Count;
                return entryNumber1.CompareTo(entryNumber2);
            });
        }
    }
}
