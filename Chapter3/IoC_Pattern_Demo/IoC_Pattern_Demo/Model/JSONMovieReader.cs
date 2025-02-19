using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IoC_Pattern_Demo.Model
{
    public class JSONMovieReader : IMovieReader
    {
        static string file = @"G:\Ki_7\PRN222\Chapter3\IoC_Pattern_Demo\IoC_Pattern_Demo\Data\MoviesDB.json";
        static List<Movie> movies = new List<Movie>();

        public List<Movie> ReadMovies()
        {
            var moviesText = File.ReadAllText(file);
            return JsonSerializer.Deserialize<List<Movie>>(moviesText);
        }
    }
}
