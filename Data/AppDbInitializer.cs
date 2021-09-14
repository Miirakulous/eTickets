using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eTickets.Data
{
    public static class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();
                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                    {
                        Name = "Cinema 1",
                        Logo = "http://dotnethow.net/images/cinemas/cinemas-1.jpeg",
                        Description = "This is the description of the first cinema"
                    },
                    new Cinema()
                    {
                        Name = "Cinema 2",
                        Logo = "http://dotnethow.net/images/cinemas/cinemas-2.jpeg",
                        Description = "This is the description of the second cinema"
                    },
                    new Cinema()
                    {
                        Name = "Cinema 3",
                        Logo = "http://dotnethow.net/images/cinemas/cinemas-3.jpeg",
                        Description = "This is the description of the third cinema"
                    },
                    new Cinema()
                    {
                        Name = "Cinema 4",
                        Logo = "http://dotnethow.net/images/cinemas/cinemas-4.jpeg",
                        Description = "This is the description of the fourth cinema"
                    },
                    new Cinema()
                    {
                        Name = "Cinema 5",
                        Logo = "http://dotnethow.net/images/cinemas/cinemas-5.jpeg",
                        Description = "This is the description of the fifth cinema"
                    },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                    {
                        FullName = "Actor 1",
                        Bio = "This is the description of the first actor",
                        ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-1.jpeg"
                    }, new Actor()
                    {
                        FullName = "Actor 2",
                        Bio = "This is the description of the second actor",
                        ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-2.jpeg"
                    }, new Actor()
                    {
                        FullName = "Actor 3",
                        Bio = "This is the description of the third actor",
                        ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-3.jpeg"
                    }, new Actor()
                    {
                        FullName = "Actor 4",
                        Bio = "This is the description of the fourth actor",
                        ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-4.jpeg"
                    }, new Actor()
                    {
                        FullName = "Actor 5",
                        Bio = "This is the description of the fifth actor",
                        ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-5.jpeg"
                    }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                    {
                        FullName = "Producer 1",
                        Bio = "This is the description of the first producer",
                        ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-1.jpeg"
                    },
                        new Producer()
                    {
                        FullName = "Producer 2",
                        Bio = "This is the description of the second producer",
                        ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-2.jpeg"
                    }, new Producer()
                    {
                        FullName = "Producer 3",
                        Bio = "This is the description of the third producer",
                        ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-3.jpeg"
                    }, new Producer()
                    {
                        FullName = "Producer 4",
                        Bio = "This is the description of the fourth producer",
                        ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-4.jpeg"
                    }, new Producer()
                    {
                        FullName = "Producer 5",
                        Bio = "This is the description of the fifth producer",
                        ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-5.jpeg"
                    },
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                    {
                        Name = "Scoob",
                        Description = "This is the description of the Scoob movie",
                        Price = 39.50,
                        ImageUrl = "http://dotnethow.net/images/movies/movie-7.jpeg",
                        StartDate = DateTime.Now.AddDays(-10),
                        EndDate = DateTime.Now.AddDays(-2),
                        CinemaId = 1,
                        ProducerId = 3,
                        MovieCategory = MovieCategory.Comedy
                    }, new Movie()
                    {
                        Name = "Cold Stone",
                        Description = "This is the description of the Cold Stone movie",
                        Price = 39.50,
                        ImageUrl = "http://dotnethow.net/images/movies/movie-8.jpeg",
                        StartDate = DateTime.Now.AddDays(3),
                        EndDate = DateTime.Now.AddDays(20),
                        CinemaId = 1,
                        ProducerId = 3,
                        MovieCategory = MovieCategory.Comedy
                    }, new Movie()
                    {
                        Name = "Scoob",
                        Description = "This is the description of the Scoob movie",
                        Price = 39.50,
                        ImageUrl = "http://dotnethow.net/images/movies/movie-1.jpeg",
                        StartDate = DateTime.Now.AddDays(-10),
                        EndDate = DateTime.Now.AddDays(-2),
                        CinemaId = 1,
                        ProducerId = 3,
                        MovieCategory = MovieCategory.Comedy
                    }, new Movie()
                    {
                        Name = "Scoob",
                        Description = "This is the description of the Scoob movie",
                        Price = 39.50,
                        ImageUrl = "http://dotnethow.net/images/movies/movie-1.jpeg",
                        StartDate = DateTime.Now.AddDays(-10),
                        EndDate = DateTime.Now.AddDays(-2),
                        CinemaId = 1,
                        ProducerId = 3,
                        MovieCategory = MovieCategory.Comedy
                    }, new Movie()
                    {
                        Name = "Scoob",
                        Description = "This is the description of the Scoob movie",
                        Price = 39.50,
                        ImageUrl = "http://dotnethow.net/images/movies/movie-1.jpeg",
                        StartDate = DateTime.Now.AddDays(-10),
                        EndDate = DateTime.Now.AddDays(-2),
                        CinemaId = 1,
                        ProducerId = 3,
                        MovieCategory = MovieCategory.Comedy
                    },
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {

                }
            }
        }
    }
}
