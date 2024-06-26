﻿using System;
using StateDesign.Repository;

namespace StateDesign
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            NowShowingMovies();
            var bookingSystem = new BookingContext();
            // show instructions
            Console.WriteLine("Movie Ticket Booking System");
            Console.WriteLine("1: Login");
            Console.WriteLine("2: New Booking");
            Console.WriteLine("3: Show Result");
            Console.WriteLine("4: Cancel Ticket");
            Console.WriteLine("5: Logout");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nEnter Request: ");
                string command = Console.ReadLine();

                if (int.Parse(command) > 5)
                {
                    Console.WriteLine("Invalid Request - Please enter valid request number.");
                    break;
                }

                switch (command)
                {
                    case "1":
                        bookingSystem.Login("DummyUser", "DummyPassword");
                        break;
                    case "2":
                        bookingSystem.BookTicket();
                        break;
                    case "3":
                        bookingSystem.ShowResult();
                        break;
                    case "4":   
                        bookingSystem.Cancel();
                        break;
                    case "5":
                        bookingSystem.LogOut();
                        break;
                }

                
            }
             
        }
        
        private static void NowShowingMovies()
        {
            Console.WriteLine("\n\t\t\tNow Showing");
            Console.WriteLine("-----------------------------------------------------------");

            var movies = SingletonRepository.GetInstance.GetAllMovies();
            int serialNumber = 1;
            foreach (var movie in movies)
            {
                Console.Write($"{serialNumber}. {movie.MovieName} \t");
                serialNumber++;
            }

            Console.WriteLine("\n-----------------------------------------------------------\n");
        }

        
    }
}