using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie.Data;
using System;
using System.Linq;

namespace RazorPagesMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (RazorPagesMovieContext context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<RazorPagesMovieContext>>()
            ))
            {
                if (context.Movie.Any()) return;
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        Release = DateTime.Parse("1989-2-12"),
                        Price = 7.99f,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Ghostbusters",
                        Release = DateTime.Parse("1984-3-13"),
                        Price = 8.99f,
                        Rating = "PG"
                    },
                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        Release = DateTime.Parse("1986-2-23"),
                        Price = 9.99f,
                        Rating = "PG"
                    },
                    new Movie
                    {
                        Title = "Rio Bravo",
                        Release = DateTime.Parse("1959-4-15"),
                        Price = 3.99f,
                        Rating = "U"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
