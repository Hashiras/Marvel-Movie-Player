using Movie_Player.Model;
using Movie_Player.Model.Manager;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Movie_Player.Menu
{
    public partial class FrmMain : Form
    {
        private int lastEntryWatched;
        private string content;
        private string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "preferences.txt");

        public FrmMain()
        {
            InitializeComponent();

        }

        private void LoadList(Boolean reload)
        {
            movieList.Items.Clear();
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "preferences.txt");
            content = File.ReadAllText(filePath);
            if (int.TryParse(content, out int lastEntryWatched))
            {
                int EntryNumber = int.Parse(content);
                if (!reload)
                    EntryNumber = EntryNumber + 1;
                MovieManager.Instance.Sort(EntryNumber);
            }
            else
            {
                MovieManager.Instance.Sort(1);
            }
            foreach (Movie movie in MovieManager.Instance.Movies)
            {
                ListViewItem item = new ListViewItem(movie.Title);
                item.ImageKey = movie.EntryNumber.ToString();
                posterList.Images.Add("" + movie.EntryNumber, Image.FromFile(movie.PosterPath));

                item.Tag = movie;

                movieList.Items.Add(item);
            }

            movieList.ItemActivate += (s, ignored2) =>
            {
                ListView listView = (ListView)s;
                if (listView.SelectedItems.Count == 0)
                    return;
                ListViewItem selectedItem = movieList.SelectedItems[0];
                Movie associatedMovie = selectedItem.Tag as Movie;
                lastEntryWatched = associatedMovie.EntryNumber;
                File.WriteAllText(filePath, lastEntryWatched.ToString());
                Process.Start("explorer.exe", associatedMovie.MoviePath);
                Debug.WriteLine("Debug: Playing media file: " + associatedMovie.MoviePath);
                this.WindowState = FormWindowState.Minimized;
            };
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadList(false);
        }

        private void NewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            ((Form)sender).Dispose();
        }

        private void btn_resume_Click(object sender, EventArgs e)
        {
            Movie associatedMovie = MovieManager.Instance.currentMovie;
            lastEntryWatched = associatedMovie.EntryNumber;
            File.WriteAllText(filePath, lastEntryWatched.ToString());
            Process.Start("explorer.exe", associatedMovie.MoviePath);
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Movie associatedMovie = MovieManager.Instance.nextMovie;
            lastEntryWatched = associatedMovie.EntryNumber;
            File.WriteAllText(filePath, lastEntryWatched.ToString());
            Process.Start("explorer.exe", associatedMovie.MoviePath);
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        { 
            if (this.WindowState == FormWindowState.Minimized)
            {
                LoadList(true);
            }
        }


    }
}
