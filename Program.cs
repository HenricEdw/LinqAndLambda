using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameObjects = new List<GameObject> 
            {
                new Ship{ID=1, X=0, Y=0, CurrentHP=50, MaxHP=100, PlayerID=1},
                new Ship{ID=2, X=4, Y=2, CurrentHP=75, MaxHP=100, PlayerID=1},
                new Ship{ID=3, X=9, Y=3, CurrentHP=0, MaxHP=100, PlayerID=2}
            };

            var players = new List<Player>
            {
                new Player{ID=1, UserName="Player 1", TeamColor="Red"},
                new Player{ID=2, UserName="Player 2", TeamColor="Blue"}
            };

            var result1 = from o in gameObjects
                          //let percentHealth = Math.Round(o.CurrentHP / o.MaxHP * 100)
                          select o.CurrentHP + "/" + o.MaxHP;//$"{o.ID} has {percentHealth}% remaining!";

            foreach (var hp in result1)
            {
                Console.WriteLine(hp);
            }

            //var sortedResult = from o in gameObjects
            //                   orderby o.ID
            //                   select o;

            //foreach(var o in sortedResult)
            //{
            //    Console.WriteLine(o.ID);
            //}

            //Går att joina olika collections också
            //I detta fall skapar vi en anonym typ som vi sedan skriver ut
            //var colors = from o in gameObjects
            //             join p in players on o.PlayerID equals p.ID
            //             select new { o.ID, p.TeamColor };

            //foreach(var color in colors)
            //{
            //    Console.WriteLine(color);
            //}

            Console.ReadLine();
        }

        //var list = from name in names
        //           where name.Contains('a')
        //           select name;

        //var houseList = new List<House> {
        //        new House { Price = 500, Rooms = 4 },
        //        new House { Price = 200, Rooms = 2 },
        //        new House { Price = 800, Rooms = 8 },
        //        new House { Price=150, Rooms= 1}
        //    };


        //var houses = from house in houseList
        //             where house.Price > 250 && house.Rooms > 3
        //             select house;
    }
}
