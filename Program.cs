using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planets = new List<string>() { "Mercury", "Mars" };

            //add() jupiter and saturn at the end of the list 

            planets.Add("Jupiter");
            planets.Add("Saturn");

            //Create another List that contains that last two planet of our solar system.
            List<string> lastPlanets = new List<string>() { "Uranus", "Neptune" };

            //Combine the two lists by using AddRange().
            planets.AddRange(lastPlanets);

            //Use Insert() to add Earth, and Venus in the correct order.
            planets.Insert(1, "Venus");
            planets.Insert(2, "Earth");

            //Use Add() again to add Pluto to the end of the list.
            planets.Add("Pluto");
            // planets.ForEach(planet => Console.WriteLine(planet));

            //Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. The rocky planets will remain in the original planets list.
            //mercury venus earth and mars are the rocky planets

            List<string> rockyPlanets = planets.GetRange(0, 4);
            rockyPlanets.ForEach(planets => Console.WriteLine(planets));

            //remove pluto bc its no longer a planet
            planets.Remove("Pluto");
        }
    }
}