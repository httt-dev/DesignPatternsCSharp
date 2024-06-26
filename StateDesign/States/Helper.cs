﻿
using System;
using System.Collections.Generic;
using StateDesign.Repository;

namespace StateDesign.States
{
    class Helper
    {
        public static void ShowBookings(List<BookedMovie> movies)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You have booked following movies: ");

            int counter = 0;

            if (movies.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t---------------------------------");
            }
            foreach (var movie in movies)
            {
                counter++;

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\tMovie Name: {movie.Movie.MovieName}");
                Console.WriteLine($"\tTotal Tickets: {movie.NoOfTickets}");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t---------------------------------");
            }
        }
    }
}
