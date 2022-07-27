using CinemaSystemApp;
using CSData;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
class Program
    {
        
    static Place placeA, placeB, placeC;
    static Film film1, film2, film3;
    static User user1, user2, user3;
    static Ticket ticket1, ticket2, ticket3;
    
        static void Main(string[] args)
        {
            CreateObjects();
            PrintData();
            PopulateDatabase();
            ExecuteQueries();
            Console.WriteLine("Press any key. ");
            Console.ReadKey();
        }
        static void CreateObjects()
        {
        placeA = new Place("Vukovarska", 1, 50, 3, 2);
        placeB = new Place("Dubrovačka", 2, 40, 5, 8);
        placeC = new Place("Matice Hrvatske", 3, 30, 4, 6);
        film1 = new Film("Doctor Strange 2", "Horror", "4D", 126);
        film2 = new Film("The Batman", "Action", "2D", 176);
        film3 = new Film("The Lost City", "Adventure", "3D", 112);
        user1 = new User("Petar", "Student");
        user2 = new User("Ana", "Dijete");
        user3 = new User("Ivan", "Odrasla Osoba");
        ticket1 = new Ticket();
        ticket2 = new Ticket();
        ticket3 = new Ticket();
        ticket1.User = user1;
        ticket2.User = user2;
        ticket3.User = user3;
        ticket1.Film = film1;
        ticket2.Film = film2;
        ticket3.Film = film3;
        ticket1.Place = placeA;
        ticket2.Place = placeB;
        ticket3.Place = placeC;
        }
        static void PrintData()
        {
        Console.WriteLine("--------Baza uspješno kreirana--------------");
        user1.CalculateDiscount();
        ticket1.CalculatePrice();
        Console.WriteLine();
        Console.WriteLine(ticket1);
        Console.WriteLine();  ticket1.PrintTicket();
        user2.CalculateDiscount();
        ticket2.CalculatePrice();
        Console.WriteLine();
        Console.WriteLine(ticket2);
        Console.WriteLine();  ticket2.PrintTicket();
        user3.CalculateDiscount();
        ticket3.CalculatePrice();
        Console.WriteLine();
        Console.WriteLine(ticket3);
        Console.WriteLine();  ticket3.PrintTicket();
    }
        static void PopulateDatabase()
        {
        
        var context = new DataContext();
        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();
        context.Place.Add(placeA);
        context.Place.Add(placeB);
        context.Place.Add(placeC);
        context.Film.Add(film1);
        context.Film.Add(film2);
        context.Film.Add(film3);
        context.User.Add(user1);
        context.User.Add(user2);
        context.User.Add(user3);
        context.Ticket.Add(ticket1);
        context.Ticket.Add(ticket2);
        context.Ticket.Add(ticket3);


        int noRows = context.SaveChanges();
        Console.WriteLine("Number of rows affected: {0}", noRows);
        Console.WriteLine("{0} Rows affected.", noRows);
    }
    static void ExecuteQueries() { }
    }
