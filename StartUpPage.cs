namespace ExcellPeppleProject6
{
    public partial class StartUpPage : Form
    {
        /**
         * Enumeration for movie genres
         */
        public enum Genre
        {
            Action,
            Comedy,
            Drama,
            Horror,
            SciFi,
            Romance,
            Thriller,
            Documentary,
            Animation,
            Fantasy
        }

        /**
         * Enumeration for file formats
         */
        public enum FileFormat
        {
            Video,
            Audio
        }

        /**
         * Class representing a movie entry
         */
        public class Movies
        {
            public string Title { get; set; }
            public int ReleaseDate { get; set; }
            public string ImageName { get; set; }
            public int Runtime { get; set; }
            public int Ratings { get; set; }
            public List<Genre> Genres { get; set; }
            public FileFormat FileFormat { get; set; }

            // Default constructor
            public Movies()
            {
                Genres = new List<Genre>();
            }

            // Parameterized constructor
            public Movies(string title, int releaseDate, string imageName, int runtime, int ratings, List<Genre> genres, FileFormat fileFormat)
            {
                Title = title;
                ReleaseDate = releaseDate;
                ImageName = imageName;
                Runtime = runtime;
                Ratings = ratings;
                Genres = new List<Genre>(genres);
                FileFormat = fileFormat;
            }

            // Copy constructor
            public Movies(Movies other)
            {
                Title = other.Title;
                ReleaseDate = other.ReleaseDate;
                ImageName = other.ImageName;
                Runtime = other.Runtime;
                Ratings = other.Ratings;
                Genres = new List<Genre>(other.Genres);
                FileFormat = other.FileFormat;
            }
        }

        /**
         * Factory class for creating movie entries
         *
         * Note: i know this isnt covered in class but ive been looking for an excuse to try out the factory pattern
         */
        public static class MovieFactory
        {
            public static Movies CreateMovie(string title, int releaseDate, string imageName, int runtime, int ratings, List<Genre> genres, FileFormat fileFormat)
            {
                return new Movies(title, releaseDate, imageName, runtime, ratings, genres, fileFormat);
            }
        }


        
        public List<Movies> MoviesDb; // In-memory database of movies
        public string FilePath; // Path to the movie database file
        public StreamReader InputStream; // Input stream for reading the movie database file
        public StreamWriter OutputStream; // Output stream for writing to the movie database file

        public StartUpPage()
        {
            InitializeComponent();
            MoviesDb = new List<Movies>();
        }

        private void StartUpPage_Load(object sender, EventArgs e)
        {
            MoviesDb.Clear(); //clear the database on load
        }


        private void StartUpPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            // close streams if they are open
            if (InputStream != null)
            {
                InputStream.Close();
            }
            if (OutputStream != null)
            {
                OutputStream.Close();
            }

            SaveDb(); // save the database on close
            MoviesDb.Clear();
        }

        /**
         * Add Movies Button Click Event Handler
         */
        private void btnAddMovies_Click(object sender, EventArgs e)
        {
            InitializeDB();
            DataEditPage dataEditPage = new DataEditPage();
            dataEditPage.Owner = this;
            dataEditPage.ShowDialog();
        }

        /**
         * Converts a comma-separated string of genres into a list of Genre enums
         * input genresLine:  Comma-separated string of genres
         */
        public static List<Genre> ParseGenres(string genresLine)
        {
            var genres = new List<Genre>();
            var genreStrings = genresLine.Split(','); // split by comma
            foreach (var genreStr in genreStrings)
            {
                // Try to parse each genre string into a Genre enum
                if (Enum.TryParse(genreStr.Trim(), out Genre g))
                {
                    genres.Add(g);
                }
            }
            return genres;
        }

        /**
         * Movie View Button Click Event Handler
         */
        private void btnViewMovies_Click(object sender, EventArgs e)
        {
            InitializeDB();
            DataViewPage dataViewPage = new DataViewPage();
            dataViewPage.Owner = this;
            dataViewPage.ShowDialog();
        }

        /**
         * Reads the movie database from the selected file and populates the in-memory database
         */
        private void InitializeDB()
        {
            // Open file dialog to select the movie database file
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            FilePath = openFileDialog.FileName;

            if (!System.IO.File.Exists(FilePath))
            {
                MessageBox.Show("Please select a valid file");
                return;
            }

            MoviesDb.Clear();

            InputStream = new StreamReader(FilePath);

            // Read movie entries from the file until the end of the stream
            while (!InputStream.EndOfStream)
            {
                var tempTitle = InputStream.ReadLine();
                var tempReleaseDate = InputStream.ReadLine();
                var ImageName = InputStream.ReadLine();
                var tempRuntime = InputStream.ReadLine();
                var tempRatings = InputStream.ReadLine();

                var genresLine = InputStream.ReadLine();
                List<Genre> tempGenres = ParseGenres(genresLine); // parse genres from string line

                var tempFileFormat = InputStream.ReadLine();

                // Create a new movie entry using the factory method
                Movies movie = MovieFactory.CreateMovie(
                    tempTitle,
                    int.Parse(tempReleaseDate),
                    ImageName,
                    int.Parse(tempRuntime),
                    int.Parse(tempRatings),
                    tempGenres,
                    Enum.Parse<FileFormat>(tempFileFormat)
                );
                // Add the movie entry to the in-memory database
                MoviesDb.Add(movie);
            }
            // Close the input stream
            InputStream.Close();
            InputStream = null;
        }


        /**
         * Saves the in-memory movie database to the selected file
         */
        public void SaveDb()
        {
            OutputStream = new StreamWriter(FilePath, false);
            foreach (Movies movie in MoviesDb)
            {
                OutputStream.WriteLine(movie.Title);
                OutputStream.WriteLine(movie.ReleaseDate);
                OutputStream.WriteLine(movie.ImageName);
                OutputStream.WriteLine(movie.Runtime);
                OutputStream.WriteLine(movie.Ratings);
                OutputStream.WriteLine(string.Join(", ", movie.Genres));
                OutputStream.WriteLine(movie.FileFormat);
            }
            OutputStream.Close();
            OutputStream = null;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
