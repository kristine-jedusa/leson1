﻿using System;
using System.IO;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "../FlightPlanner/flights.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);
            foreach (var s in readText)
            {
                Console.WriteLine(s);
            }
        }
    }
}