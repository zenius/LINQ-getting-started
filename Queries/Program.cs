using System;
using System.Collections.Generic;
using System.Linq;

namespace Queries
{
  class Program
  {
    static void Main(string[] args)
    {
      // FirstExample();
      // SecondExample();
      ThirdExample();
    }

    public static void ThirdExample()
    {
      // Demo: Custom Filter Operation 
      var movies = new List<Movie>()
      {
          new Movie() { Id = 1 , Title = "The Dark Knight", Rating = 8.9f , Year = 2008 },
          new Movie() { Id = 2 , Title = "The King's Speech", Rating = 8.0f , Year = 2010 },
          new Movie() { Id = 3 , Title = "Casablanca", Rating = 8.5f , Year = 1942 },
          new Movie() { Id = 4 , Title = "Star Wars V", Rating = 8.7f , Year = 1980 }
      };

      var filteredMovies = movies.Filter(movie => movie.Year > 2000).ToList();

      ShowMovies(filteredMovies);
    }
    public static void SecondExample()
    {
      // Demo: Custom Filter Operation 
      var movies = new List<Movie>()
      {
          new Movie() { Id = 1 , Title = "The Dark Knight", Rating = 8.9f , Year = 2008 },
          new Movie() { Id = 2 , Title = "The King's Speech", Rating = 8.0f , Year = 2010 },
          new Movie() { Id = 3 , Title = "Casablanca", Rating = 8.5f , Year = 1942 },
          new Movie() { Id = 4 , Title = "Star Wars V", Rating = 8.7f , Year = 1980 }
      };

      var filteredMovies = movies.Filter(movie => movie.Year > 2000);

      ShowMovies(filteredMovies);
    }
    public static void FirstExample()
    {
      // Demo: Filter Operation 
      var movies = new List<Movie>()
      {
          new Movie() { Id = 1 , Title = "The Dark Knight", Rating = 8.9f , Year = 2008 },
          new Movie() { Id = 2 , Title = "The King's Speech", Rating = 8.0f , Year = 2010 },
          new Movie() { Id = 3 , Title = "Casablanca", Rating = 8.5f , Year = 1942 },
          new Movie() { Id = 4 , Title = "Star Wars V", Rating = 8.7f , Year = 1980 }
      };

      var filteredMovies = movies.Where(movie => movie.Year > 2000);

      ShowMovies(filteredMovies);
    }

    public static void ShowMovies(IEnumerable<Movie> movies)
    {
      //   foreach (var movie in movies)
      //   {
      //     Console.WriteLine(movie.Title);
      //   }
      var enumerator = movies.GetEnumerator();
      while (enumerator.MoveNext())
      {
        var movie = enumerator.Current;
        Console.WriteLine(movie.Title);
      }

    }
  }
}
