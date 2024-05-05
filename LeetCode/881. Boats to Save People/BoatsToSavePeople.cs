using System.Security.Cryptography.X509Certificates;
using LeetCode.Core;

public class BoatsToSavePeople : ITask
{
    public string Name => "Boats to Save People";

    public string Description => "You are given an array people where people[i] is the weight of the ith person, and an infinite number of boats where each boat can carry a maximum weight of limit. Each boat carries at most two people at the same time, provided the sum of the weight of those people is at most limit. Return the minimum number of boats to carry every given person.";

    public Dificulty Dificulty => Dificulty.Medium;

    public void Calculate()
    {
        (int[] people, int limit) = GetInput();
        Array.Sort(people);
        var boatCount = 0;
        var i = 0;
        var j = people.Length - 1;
        while(i <= j)
        {
            if(people[i] + people[j] <= limit)
            {
                i++;
            }
            j--;
            boatCount++;
        }
        Console.WriteLine(boatCount);
    }

    public (int[], int) GetInput(){
        Console.WriteLine("Provide a lsit of weights of people as coma separated numbers: ");
        int[] people;
        try
        {
            var peopleChar = Console.ReadLine();
            people = peopleChar.Split(',').Select(x => int.Parse(x)).ToArray(); 
        }
        catch(Exception){
            Console.WriteLine("Input was in wrong format please try again");
            Console.ReadKey();
            Console.Clear();
            return GetInput();
        }

        System.Console.WriteLine("Please provide a limit of weight per boat:");
        var limit = Int32.Parse(Console.ReadLine());
        return (people, limit);
    }
}