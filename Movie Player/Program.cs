using Movie_Player.Model.Manager;
using Movie_Player.Model;
using System;
using System.IO;
using System.Windows.Forms;

namespace Movie_Player
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Load Movies
            loadMovies();
            Application.Run(new FrmSplash());
        }

        private static void loadMovies()
        {
            MovieManager manager = MovieManager.Instance;
            manager.Movies.Add(new Movie(1, "Captain America: The First Avenger",
                Path.Combine(Application.StartupPath, "Img", "poster_1.jpg")));
            manager.Movies.Add(new Movie(2, "Marvel One Shot: Agent Carter",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg")));
            manager.Movies.Add(new Movie(3, "Agent Carter Season 1, Episode 1",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"), FileExtension.mkv));
            manager.Movies.Add(new Movie(4, "Agent Carter Season 1, Episode 2",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"), FileExtension.mkv));
            manager.Movies.Add(new Movie(5, "Agent Carter Season 1, Episode 3",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"), FileExtension.mkv));
            manager.Movies.Add(new Movie(6, "Agent Carter Season 1, Episode 4",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"), FileExtension.mkv));
            manager.Movies.Add(new Movie(7, "Agent Carter Season 1, Episode 5",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"), FileExtension.mkv));
            manager.Movies.Add(new Movie(8, "Agent Carter Season 1, Episode 6",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"), FileExtension.mkv));
            manager.Movies.Add(new Movie(9, "Agent Carter Season 1, Episode 7",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"), FileExtension.mkv));
            manager.Movies.Add(new Movie(10, "Agent Carter Season 1, Episode 8",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"), FileExtension.mkv));
            manager.Movies.Add(new Movie(11, "Agent Carter Season 2, Episode 1",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"), FileExtension.mkv));
            manager.Movies.Add(new Movie(12, "Agent Carter Season 2, Episode 2",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"), FileExtension.mkv));
            manager.Movies.Add(new Movie(13, "Agent Carter Season 2, Episode 3",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"), FileExtension.mkv));
            manager.Movies.Add(new Movie(14, "Agent Carter Season 2, Episode 4",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"), FileExtension.mkv));
            manager.Movies.Add(new Movie(15, "Agent Carter Season 2, Episode 5",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"), FileExtension.mkv));
            manager.Movies.Add(new Movie(16, "Agent Carter Season 2, Episode 6",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"), FileExtension.mkv));
            manager.Movies.Add(new Movie(17, "Agent Carter Season 2, Episode 7",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"), FileExtension.mkv));
            manager.Movies.Add(new Movie(18, "Agent Carter Season 2, Episode 8",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"), FileExtension.mkv));
            manager.Movies.Add(new Movie(19, "Agent Carter Season 2, Episode 9",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"), FileExtension.mkv));
            manager.Movies.Add(new Movie(20, "Agent Carter Season 2, Episode 10",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"), FileExtension.mkv));
            manager.Movies.Add(new Movie(21, "Captain Marvel",
                Path.Combine(Application.StartupPath, "Img", "poster_3.jpg")));
        }
    }
}
