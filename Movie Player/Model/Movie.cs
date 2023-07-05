
using System.IO;
using System.Windows.Forms;

namespace Movie_Player.Model
{
    public class Movie
    {
        public Movie(int EntryNumber, string Title, string PosterPath, string MoviePath)
        {
            this.EntryNumber = EntryNumber;
            this.Title = Title;
            this.PosterPath = PosterPath;
            this.MoviePath = MoviePath;
        }
        public Movie(int EntryNumber, string Title, string PosterPath)
        {
            this.EntryNumber = EntryNumber;
            this.Title = Title;
            this.PosterPath = PosterPath;
            this.MoviePath = Path.Combine(Application.StartupPath, "Media", EntryNumber + ".mp4");
        }
        public int EntryNumber { get;}
        public string Title { get; }
        public string PosterPath { get;}
        public string MoviePath { get;}
    }
}
