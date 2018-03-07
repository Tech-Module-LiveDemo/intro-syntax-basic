//CONFIRMED from AlenPaunov
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class January06_2017Part2
{
    public static void Main()
    {
		
		// TODO
        List<string> drivers = Console.ReadLine().Split(' ').ToList();
        double[] zones = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        List<double> indexes = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

        List<double> fuel = new List<double>();
        DriverFuel(drivers, fuel);

        var counter = 0;
        var zoneCounter = 0;
        int[] zone = new int[drivers.Count()];
        foreach (var driver in drivers)
        {
            for (int i = 0; i < zones.Length; i++)
            {
                bool isEqual = false;
                for (int k = 0; k < indexes.Count; k++)
                {
                    if (i == indexes[k])
                    {
                        isEqual = true;
                        break;
                    }
                }
                if (isEqual)
                    fuel[counter] += zones[i];
                else
                    fuel[counter] -= zones[i];
                zoneCounter++;
                if (fuel[counter] <= 0)
                {
                   zone[counter]=zoneCounter-1;
                    break;
                }
            }
            zoneCounter = 0;
            counter++;
        }
        var count = 0;
        foreach (var driver in drivers)
        {
            if (fuel[count] > 0)
            {
                Console.WriteLine($"{driver} - fuel left {fuel[count]:f2}");
            }
            else
            {
                Console.WriteLine($"{driver} - reached {zone[count]}");
            }
            count++;
        }
    }
	
	// TO DRUNK TO COMMENT
    private static void AddFuel(List<string> drivers, List<double> fuel)
    {
        foreach (var driver in drivers)
        {
            foreach (char firstCharacter in driver)
            {
                fuel.Add(firstCharacter);
                break;
            }
        }
    }

}