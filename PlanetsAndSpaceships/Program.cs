using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            int num = 1;

            foreach (string planet in planetList)
            {
                Console.WriteLine(num+". "+planet);
                num++;
            }
            Console.WriteLine("_____________________");

            List<string> lastPlanets = new List<string>() { "Neptune", "Uranus" };

            planetList.AddRange(lastPlanets);

            num = 1;

            foreach (string planet in planetList)
            {

                Console.WriteLine(num + ". " + planet);
                num++;
            }
            Console.WriteLine("_____________________");

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");

            num = 1;

            foreach (string planet in planetList)
            {
                Console.WriteLine(num + ". " + planet);
                num++;
            }
            Console.WriteLine("_____________________");

            List<string> rockyPlanets = new List<string>();
            rockyPlanets = planetList.GetRange(0, 4);

            num = 1;

            foreach(string planet in rockyPlanets)
            {
                Console.WriteLine(num + ". " + planet);
                num++;
            }
            Console.WriteLine("______________________");

            planetList.Remove("Pluto");

            num = 1;

            foreach (string planet in planetList)
            {
                Console.WriteLine(num + ". " + planet);
                num++;
            }
            Console.WriteLine("_____________________");

            Dictionary<string, List<string>> spaceCraft = new Dictionary<string, List<string>>();




            Console.ReadLine();

        }
    }
}
