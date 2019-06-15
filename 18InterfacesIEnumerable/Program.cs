using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// IEnumerable uses IEnumerator
namespace _18InterfacesIEnumerable
{
    class Program
    {
        class Player
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Player(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }

        // Team is an aggregated class of Players
        class Team : IEnumerable
        {
            // under 10 years old volley ball girls team
            private Player[] teamC = new Player[4];

            public Team()
            {
                teamC[0] = new Player("Mariam", 8);
                teamC[1] = new Player("Malak", 9);
                teamC[2] = new Player("Yara", 8);
                teamC[3] = new Player("Menna", 9);
            }

            // IEnumerable method which must be implemented
            public IEnumerator GetEnumerator()
            {
                return teamC.GetEnumerator();
            }
        }

        static void Main(string[] args)
        {
            #region first discussion
            //// The array class implements the IEnumerable interface type
            //// the IEnumerable uses a method "GetEnumerable" that returns IEnumerator type
            //// so Iteration is enabled on the arrays and lists
            //string[] players = { "Barakat","Treika","Bibo"};

            //foreach (var item in players)
            //{
            //    Console.WriteLine($"The playes is {item}");
            //}
            #endregion

            #region second discussion
            Team smouhaC = new Team();

            // if Team is not implementing IEnumarable no iteration can happen
            // Team doesn't contain a public instance definition for 'GetEnumerator'
            foreach (Player player in smouhaC)
            {
                Console.WriteLine($"The playes is {player.Name} age is {player.Age}");
            }

            #endregion
        }
    }
}
