using System;

namespace ImperialAirForce {
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Map map = new Map();

            GameEngine.AircraftList.Add(AircraftFactory.CreateHellion(new Point(4, 2, 3)));
            GameEngine.AircraftList.Add(AircraftFactory.CreateBigBurna(new Point(2, 4, 2)));
            
            map.Render();
        }
    }
}