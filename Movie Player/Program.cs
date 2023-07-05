using Movie_Player.Model.Manager;
using Movie_Player.Model;
using System;
using System.IO;
using System.Windows.Forms;
using static Movie_Player.Model.Movie;

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
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(3, "Agent Carter Season 1, Episode 1",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(4, "Agent Carter Season 1, Episode 2",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(5, "Agent Carter Season 1, Episode 3",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(6, "Agent Carter Season 1, Episode 4",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(7, "Agent Carter Season 1, Episode 5",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(8, "Agent Carter Season 1, Episode 6",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(9, "Agent Carter Season 1, Episode 7",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(10, "Agent Carter Season 1, Episode 8",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(11, "Agent Carter Season 2, Episode 1",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(12, "Agent Carter Season 2, Episode 2",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(13, "Agent Carter Season 2, Episode 3",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(14, "Agent Carter Season 2, Episode 4",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(15, "Agent Carter Season 2, Episode 5",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(16, "Agent Carter Season 2, Episode 6",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(17, "Agent Carter Season 2, Episode 7",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(18, "Agent Carter Season 2, Episode 8",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(19, "Agent Carter Season 2, Episode 9",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(20, "Agent Carter Season 2, Episode 10",
                Path.Combine(Application.StartupPath, "Img", "poster_2.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(21, "Captain Marvel",
                Path.Combine(Application.StartupPath, "Img", "poster_3.jpg")));
            manager.Movies.Add(new Movie(22, "Iron Man",
                Path.Combine(Application.StartupPath, "Img", "poster_4.jpg")));
            manager.Movies.Add(new Movie(23, "Iron Man II",
                Path.Combine(Application.StartupPath, "Img", "poster_5.jpg")));
            manager.Movies.Add(new Movie(24, "The Incredible Hulk",
                Path.Combine(Application.StartupPath, "Img", "poster_6.jpg")));
            manager.Movies.Add(new Movie(25, "Marvel One Shot: The Consultant",
                Path.Combine(Application.StartupPath, "Img", "poster_7.jpg")));
            manager.Movies.Add(new Movie(26, "Thor",
                Path.Combine(Application.StartupPath, "Img", "poster_8.jpg")));
            manager.Movies.Add(new Movie(27, "Avengers",
                Path.Combine(Application.StartupPath, "Img", "poster_9.jpg")));
            manager.Movies.Add(new Movie(28, "Marvel One Shot: Item 47",
                Path.Combine(Application.StartupPath, "Img", "poster_10.jpg")));
            manager.Movies.Add(new Movie(29, "Iron Man III",
                Path.Combine(Application.StartupPath, "Img", "poster_11.jpg")));
            manager.Movies.Add(new Movie(30, "Marvel One Shot: All Hail the King",
                Path.Combine(Application.StartupPath, "Img", "poster_12.jpg")));
            manager.Movies.Add(new Movie(31, "Agents Of Shield Season 1, Episode 1",
                Path.Combine(Application.StartupPath, "Img", "poster_13.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(32, "Agents Of Shield Season 1, Episode 2",
                Path.Combine(Application.StartupPath, "Img", "poster_13.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(33, "Agents Of Shield Season 1, Episode 3",
                Path.Combine(Application.StartupPath, "Img", "poster_13.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(34, "Agents Of Shield Season 1, Episode 4",
                Path.Combine(Application.StartupPath, "Img", "poster_13.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(35, "Agents Of Shield Season 1, Episode 5",
                Path.Combine(Application.StartupPath, "Img", "poster_13.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(36, "Agents Of Shield Season 1, Episode 6",
                Path.Combine(Application.StartupPath, "Img", "poster_13.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(37, "Agents Of Shield Season 1, Episode 7",
                Path.Combine(Application.StartupPath, "Img", "poster_13.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(38, "Thor Dark World",
                Path.Combine(Application.StartupPath, "Img", "poster_14.jpg")));
            manager.Movies.Add(new Movie(39, "Agents Of Shield Season 1, Episode 8",
                Path.Combine(Application.StartupPath, "Img", "poster_13.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(40, "Agents Of Shield Season 1, Episode 9",
                Path.Combine(Application.StartupPath, "Img", "poster_13.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(41, "Agents Of Shield Season 1, Episode 10",
                Path.Combine(Application.StartupPath, "Img", "poster_13.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(42, "Agents Of Shield Season 1, Episode 11",
                Path.Combine(Application.StartupPath, "Img", "poster_13.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(43, "Agents Of Shield Season 1, Episode 12",
                Path.Combine(Application.StartupPath, "Img", "poster_13.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(44, "Agents Of Shield Season 1, Episode 13",
                Path.Combine(Application.StartupPath, "Img", "poster_13.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(45, "Agents Of Shield Season 1, Episode 14",
                Path.Combine(Application.StartupPath, "Img", "poster_13.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(46, "Agents Of Shield Season 1, Episode 15",
                Path.Combine(Application.StartupPath, "Img", "poster_13.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(47, "Agents Of Shield Season 1, Episode 16",
                Path.Combine(Application.StartupPath, "Img", "poster_13.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(48, "Captain America: The Winter Soldier",
                Path.Combine(Application.StartupPath, "Img", "poster_15.jpg")));
            manager.Movies.Add(new Movie(49, "Agents Of Shield Season 1, Episode 17",
                Path.Combine(Application.StartupPath, "Img", "poster_13.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(50, "Agents Of Shield Season 1, Episode 18",
                Path.Combine(Application.StartupPath, "Img", "poster_13.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(51, "Agents Of Shield Season 1, Episode 19",
                Path.Combine(Application.StartupPath, "Img", "poster_13.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(52, "Agents Of Shield Season 1, Episode 20",
                Path.Combine(Application.StartupPath, "Img", "poster_13.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(53, "Agents Of Shield Season 1, Episode 21",
                Path.Combine(Application.StartupPath, "Img", "poster_13.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(54, "Agents Of Shield Season 1, Episode 22",
                Path.Combine(Application.StartupPath, "Img", "poster_13.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(55, "Daredevil Season 1, Episode 1",
                Path.Combine(Application.StartupPath, "Img", "poster_16.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(56, "Daredevil Season 1, Episode 2",
                Path.Combine(Application.StartupPath, "Img", "poster_16.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(57, "Daredevil Season 1, Episode 3",
                Path.Combine(Application.StartupPath, "Img", "poster_16.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(58, "Daredevil Season 1, Episode 4",
                Path.Combine(Application.StartupPath, "Img", "poster_16.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(59, "Daredevil Season 1, Episode 5",
                Path.Combine(Application.StartupPath, "Img", "poster_16.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(60, "Daredevil Season 1, Episode 6",
                Path.Combine(Application.StartupPath, "Img", "poster_16.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(61, "Daredevil Season 1, Episode 7",
                Path.Combine(Application.StartupPath, "Img", "poster_16.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(62, "Daredevil Season 1, Episode 8",
                Path.Combine(Application.StartupPath, "Img", "poster_16.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(63, "Daredevil Season 1, Episode 9",
                Path.Combine(Application.StartupPath, "Img", "poster_16.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(64, "Daredevil Season 1, Episode 10",
                Path.Combine(Application.StartupPath, "Img", "poster_16.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(65, "Daredevil Season 1, Episode 11",
                Path.Combine(Application.StartupPath, "Img", "poster_16.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(66, "Daredevil Season 1, Episode 12",
                Path.Combine(Application.StartupPath, "Img", "poster_16.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(67, "Daredevil Season 1, Episode 13",
                Path.Combine(Application.StartupPath, "Img", "poster_16.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(68, "Guardians of the Galaxy",
                Path.Combine(Application.StartupPath, "Img", "poster_17.jpg")));
            manager.Movies.Add(new Movie(69, "Guardians of the Galaxy Volume 2",
                Path.Combine(Application.StartupPath, "Img", "poster_18.jpg")));
            manager.Movies.Add(new Movie(70, "Agents of Shield Season 2, Episode 1",
                Path.Combine(Application.StartupPath, "Img", "poster_19.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(71, "Agents of Shield Season 2, Episode 2",
                Path.Combine(Application.StartupPath, "Img", "poster_19.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(72, "Agents of Shield Season 2, Episode 3",
                Path.Combine(Application.StartupPath, "Img", "poster_19.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(73, "Agents of Shield Season 2, Episode 4",
                Path.Combine(Application.StartupPath, "Img", "poster_19.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(74, "Agents of Shield Season 2, Episode 5",
                Path.Combine(Application.StartupPath, "Img", "poster_19.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(75, "Agents of Shield Season 2, Episode 6",
                Path.Combine(Application.StartupPath, "Img", "poster_19.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(76, "Agents of Shield Season 2, Episode 7",
                Path.Combine(Application.StartupPath, "Img", "poster_19.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(77, "Agents of Shield Season 2, Episode 8",
                Path.Combine(Application.StartupPath, "Img", "poster_19.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(78, "Agents of Shield Season 2, Episode 9",
                Path.Combine(Application.StartupPath, "Img", "poster_19.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(79, "Agents of Shield Season 2, Episode 10",
                Path.Combine(Application.StartupPath, "Img", "poster_19.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(80, "Agents of Shield Season 2, Episode 11",
                Path.Combine(Application.StartupPath, "Img", "poster_19.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(81, "Agents of Shield Season 2, Episode 12",
                Path.Combine(Application.StartupPath, "Img", "poster_19.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(82, "Agents of Shield Season 2, Episode 13",
                Path.Combine(Application.StartupPath, "Img", "poster_19.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(83, "Agents of Shield Season 2, Episode 14",
                Path.Combine(Application.StartupPath, "Img", "poster_19.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(84, "Agents of Shield Season 2, Episode 15",
                Path.Combine(Application.StartupPath, "Img", "poster_19.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(85, "Agents of Shield Season 2, Episode 16",
                Path.Combine(Application.StartupPath, "Img", "poster_19.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(86, "Agents of Shield Season 2, Episode 17",
                Path.Combine(Application.StartupPath, "Img", "poster_19.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(87, "Agents of Shield Season 2, Episode 18",
                Path.Combine(Application.StartupPath, "Img", "poster_19.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(88, "Agents of Shield Season 2, Episode 19",
                Path.Combine(Application.StartupPath, "Img", "poster_19.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(89, "Avengers: Age of Ultron",
                Path.Combine(Application.StartupPath, "Img", "poster_20.jpg")));
            manager.Movies.Add(new Movie(90, "Agents of Shield Season 2, Episode 20",
                Path.Combine(Application.StartupPath, "Img", "poster_19.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(91, "Agents of Shield Season 2, Episode 21",
                Path.Combine(Application.StartupPath, "Img", "poster_19.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(92, "Agents of Shield Season 2, Episode 22",
                Path.Combine(Application.StartupPath, "Img", "poster_19.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(93, "Ant-Man",
                Path.Combine(Application.StartupPath, "Img", "poster_21.jpg")));
            manager.Movies.Add(new Movie(94, "Jessica Jones Season 1, Episode 1",
                Path.Combine(Application.StartupPath, "Img", "poster_22.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(95, "Jessica Jones Season 1, Episode 2",
                Path.Combine(Application.StartupPath, "Img", "poster_22.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(96, "Jessica Jones Season 1, Episode 3",
                Path.Combine(Application.StartupPath, "Img", "poster_22.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(97, "Jessica Jones Season 1, Episode 4",
                Path.Combine(Application.StartupPath, "Img", "poster_22.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(98, "Jessica Jones Season 1, Episode 5",
                Path.Combine(Application.StartupPath, "Img", "poster_22.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(99, "Jessica Jones Season 1, Episode 6",
                Path.Combine(Application.StartupPath, "Img", "poster_22.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(100, "Jessica Jones Season 1, Episode 7",
                Path.Combine(Application.StartupPath, "Img", "poster_22.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(101, "Jessica Jones Season 1, Episode 8",
                Path.Combine(Application.StartupPath, "Img", "poster_22.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(102, "Jessica Jones Season 1, Episode 9",
                Path.Combine(Application.StartupPath, "Img", "poster_22.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(103, "Jessica Jones Season 1, Episode 10",
                Path.Combine(Application.StartupPath, "Img", "poster_22.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(104, "Jessica Jones Season 1, Episode 11",
                Path.Combine(Application.StartupPath, "Img", "poster_22.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(105, "Jessica Jones Season 1, Episode 12",
                Path.Combine(Application.StartupPath, "Img", "poster_22.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(106, "Jessica Jones Season 1, Episode 13",
                Path.Combine(Application.StartupPath, "Img", "poster_22.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(107, "Daredevil Season 2, Episode 1",
                Path.Combine(Application.StartupPath, "Img", "poster_23.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(108, "Daredevil Season 2, Episode 2",
                Path.Combine(Application.StartupPath, "Img", "poster_23.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(109, "Daredevil Season 2, Episode 3",
                Path.Combine(Application.StartupPath, "Img", "poster_23.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(110, "Daredevil Season 2, Episode 4",
                Path.Combine(Application.StartupPath, "Img", "poster_23.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(111, "Daredevil Season 2, Episode 5",
                Path.Combine(Application.StartupPath, "Img", "poster_23.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(112, "Daredevil Season 2, Episode 6",
                Path.Combine(Application.StartupPath, "Img", "poster_23.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(113, "Daredevil Season 2, Episode 7",
                Path.Combine(Application.StartupPath, "Img", "poster_23.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(114, "Daredevil Season 2, Episode 8",
                Path.Combine(Application.StartupPath, "Img", "poster_23.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(115, "Daredevil Season 2, Episode 9",
                Path.Combine(Application.StartupPath, "Img", "poster_23.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(116, "Daredevil Season 2, Episode 10",
                Path.Combine(Application.StartupPath, "Img", "poster_23.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(117, "Daredevil Season 2, Episode 11",
                Path.Combine(Application.StartupPath, "Img", "poster_23.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(118, "Daredevil Season 2, Episode 12",
                Path.Combine(Application.StartupPath, "Img", "poster_23.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(119, "Daredevil Season 2, Episode 13",
                Path.Combine(Application.StartupPath, "Img", "poster_23.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(120, "Luke Cage Season 1, Episode 1",
                Path.Combine(Application.StartupPath, "Img", "poster_24.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(121, "Luke Cage Season 1, Episode 2",
                Path.Combine(Application.StartupPath, "Img", "poster_24.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(122, "Luke Cage Season 1, Episode 3",
                Path.Combine(Application.StartupPath, "Img", "poster_24.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(123, "Luke Cage Season 1, Episode 4",
                Path.Combine(Application.StartupPath, "Img", "poster_24.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(124, "Luke Cage Season 1, Episode 5",
                Path.Combine(Application.StartupPath, "Img", "poster_24.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(125, "Luke Cage Season 1, Episode 6",
                Path.Combine(Application.StartupPath, "Img", "poster_24.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(126, "Luke Cage Season 1, Episode 7",
                Path.Combine(Application.StartupPath, "Img", "poster_24.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(127, "Luke Cage Season 1, Episode 8",
                Path.Combine(Application.StartupPath, "Img", "poster_24.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(128, "Luke Cage Season 1, Episode 9",
                Path.Combine(Application.StartupPath, "Img", "poster_24.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(129, "Luke Cage Season 1, Episode 10",
                Path.Combine(Application.StartupPath, "Img", "poster_24.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(130, "Luke Cage Season 1, Episode 11",
                Path.Combine(Application.StartupPath, "Img", "poster_24.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(131, "Luke Cage Season 1, Episode 12",
                Path.Combine(Application.StartupPath, "Img", "poster_24.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(132, "Luke Cage Season 1, Episode 13",
                Path.Combine(Application.StartupPath, "Img", "poster_24.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(133, "Agents of Shield Season 3, Episode 1",
                Path.Combine(Application.StartupPath, "Img", "poster_25.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(134, "Agents of Shield Season 3, Episode 2",
                Path.Combine(Application.StartupPath, "Img", "poster_25.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(135, "Agents of Shield Season 3, Episode 3",
                Path.Combine(Application.StartupPath, "Img", "poster_25.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(136, "Agents of Shield Season 3, Episode 4",
                Path.Combine(Application.StartupPath, "Img", "poster_25.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(137, "Agents of Shield Season 3, Episode 5",
                Path.Combine(Application.StartupPath, "Img", "poster_25.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(138, "Agents of Shield Season 3, Episode 6",
                Path.Combine(Application.StartupPath, "Img", "poster_25.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(139, "Agents of Shield Season 3, Episode 7",
                Path.Combine(Application.StartupPath, "Img", "poster_25.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(140, "Agents of Shield Season 3, Episode 8",
                Path.Combine(Application.StartupPath, "Img", "poster_25.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(141, "Agents of Shield Season 3, Episode 9",
                Path.Combine(Application.StartupPath, "Img", "poster_25.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(142, "Agents of Shield Season 3, Episode 10",
                Path.Combine(Application.StartupPath, "Img", "poster_25.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(143, "Agents of Shield Season 3, Episode 11",
                Path.Combine(Application.StartupPath, "Img", "poster_25.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(144, "Agents of Shield Season 3, Episode 12",
                Path.Combine(Application.StartupPath, "Img", "poster_25.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(145, "Agents of Shield Season 3, Episode 13",
                Path.Combine(Application.StartupPath, "Img", "poster_25.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(146, "Agents of Shield Season 3, Episode 14",
                Path.Combine(Application.StartupPath, "Img", "poster_25.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(147, "Agents of Shield Season 3, Episode 15",
                Path.Combine(Application.StartupPath, "Img", "poster_25.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(148, "Agents of Shield Season 3, Episode 16",
                Path.Combine(Application.StartupPath, "Img", "poster_25.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(149, "Agents of Shield Season 3, Episode 17",
                Path.Combine(Application.StartupPath, "Img", "poster_25.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(150, "Agents of Shield Season 3, Episode 18",
                Path.Combine(Application.StartupPath, "Img", "poster_25.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(151, "Agents of Shield Season 3, Episode 19",
                Path.Combine(Application.StartupPath, "Img", "poster_25.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(152, "Captain America: Civil War",
                Path.Combine(Application.StartupPath, "Img", "poster_26.jpg")));
            manager.Movies.Add(new Movie(153, "Team Thor Part 1",
                Path.Combine(Application.StartupPath, "Img", "poster_27.jpg")));
            manager.Movies.Add(new Movie(154, "Team Thor Part 2",
                Path.Combine(Application.StartupPath, "Img", "poster_28.jpg")));
            manager.Movies.Add(new Movie(155, "Agents of Shield Season 3, Episode 20",
                Path.Combine(Application.StartupPath, "Img", "poster_25.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(156, "Agents of Shield Season 3, Episode 21",
                Path.Combine(Application.StartupPath, "Img", "poster_25.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(157, "Agents of Shield Season 3, Episode 22",
                Path.Combine(Application.StartupPath, "Img", "poster_25.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(158, "Agents of Shield Slingshot Episode 1",
                Path.Combine(Application.StartupPath, "Img", "poster_29.jpg")));
            manager.Movies.Add(new Movie(159, "Agents of Shield Slingshot Episode 2",
                Path.Combine(Application.StartupPath, "Img", "poster_29.jpg")));
            manager.Movies.Add(new Movie(160, "Agents of Shield Slingshot Episode 3",
                Path.Combine(Application.StartupPath, "Img", "poster_29.jpg")));
            manager.Movies.Add(new Movie(161, "Agents of Shield Slingshot Episode 4",
                Path.Combine(Application.StartupPath, "Img", "poster_29.jpg")));
            manager.Movies.Add(new Movie(162, "Agents of Shield Slingshot Episode 5",
                Path.Combine(Application.StartupPath, "Img", "poster_29.jpg")));
            manager.Movies.Add(new Movie(163, "Agents of Shield Slingshot Episode 6",
                Path.Combine(Application.StartupPath, "Img", "poster_29.jpg")));
            manager.Movies.Add(new Movie(164, "Agents of Shield Season 4, Episode 1",
                Path.Combine(Application.StartupPath, "Img", "poster_30.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(165, "Agents of Shield Season 4, Episode 2",
                Path.Combine(Application.StartupPath, "Img", "poster_30.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(166, "Agents of Shield Season 4, Episode 3",
                Path.Combine(Application.StartupPath, "Img", "poster_30.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(167, "Agents of Shield Season 4, Episode 4",
                Path.Combine(Application.StartupPath, "Img", "poster_30.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(168, "Agents of Shield Season 4, Episode 5",
                Path.Combine(Application.StartupPath, "Img", "poster_30.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(169, "Agents of Shield Season 4, Episode 6",
                Path.Combine(Application.StartupPath, "Img", "poster_30.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(170, "Agents of Shield Season 4, Episode 7",
                Path.Combine(Application.StartupPath, "Img", "poster_30.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(171, "Agents of Shield Season 4, Episode 8",
                Path.Combine(Application.StartupPath, "Img", "poster_30.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(172, "Agents of Shield Season 4, Episode 9",
                Path.Combine(Application.StartupPath, "Img", "poster_30.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(173, "Agents of Shield Season 4, Episode 10",
                Path.Combine(Application.StartupPath, "Img", "poster_30.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(174, "Agents of Shield Season 4, Episode 11",
                Path.Combine(Application.StartupPath, "Img", "poster_30.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(175, "Agents of Shield Season 4, Episode 12",
                Path.Combine(Application.StartupPath, "Img", "poster_30.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(176, "Agents of Shield Season 4, Episode 13",
                Path.Combine(Application.StartupPath, "Img", "poster_30.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(177, "Agents of Shield Season 4, Episode 14",
                Path.Combine(Application.StartupPath, "Img", "poster_30.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(178, "Agents of Shield Season 4, Episode 15",
                Path.Combine(Application.StartupPath, "Img", "poster_30.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(179, "Agents of Shield Season 4, Episode 16",
                Path.Combine(Application.StartupPath, "Img", "poster_30.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(180, "Agents of Shield Season 4, Episode 17",
                Path.Combine(Application.StartupPath, "Img", "poster_30.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(181, "Agents of Shield Season 4, Episode 18",
                Path.Combine(Application.StartupPath, "Img", "poster_30.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(182, "Agents of Shield Season 4, Episode 19",
                Path.Combine(Application.StartupPath, "Img", "poster_30.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(183, "Agents of Shield Season 4, Episode 20",
                Path.Combine(Application.StartupPath, "Img", "poster_30.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(184, "Agents of Shield Season 4, Episode 21",
                Path.Combine(Application.StartupPath, "Img", "poster_30.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(185, "Agents of Shield Season 4, Episode 22",
                Path.Combine(Application.StartupPath, "Img", "poster_30.jpg"),
                FileExtension.mkv));
            manager.Movies.Add(new Movie(186, "Black Widow",
                Path.Combine(Application.StartupPath, "Img", "poster_31.jpg")));
            manager.Movies.Add(new Movie(187, "Black Panther",
                Path.Combine(Application.StartupPath, "Img", "poster_32.jpg")));
            manager.Movies.Add(new Movie(188, "Spider-Man: Homecoming",
                Path.Combine(Application.StartupPath, "Img", "poster_33.jpg")));
        }
    }
}
