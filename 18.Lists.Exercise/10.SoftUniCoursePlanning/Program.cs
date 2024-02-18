using System.Collections.Generic;
using System;

namespace _10.SoftUniCoursePlanning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine()
                                           .Split(", ")
                                           .ToList();

            string input;
            while ((input = Console.ReadLine()) != "course start")
            {
                string[] command = input.Split(':');

                switch (command[0])
                {
                    case "Add":
                        if (!schedule.Contains(command[1]))
                        {
                            schedule.Add(command[1]);
                        }
                        break;
                    case "Insert":
                        if (!schedule.Contains(command[1]))
                        {
                            schedule.Insert(int.Parse(command[2]), command[1]);
                        }
                        break;
                    case "Remove":
                        if (schedule.Contains(command[1]))
                        {
                            schedule.RemoveAll(x => x.Contains(command[1]));
                        }
                        break;
                    case "Swap":
                        if (schedule.Exists(x => x.Contains(command[1])) && schedule.Exists(x => x.Contains(command[2])))
                        {

                        }
                        break;
                    case "Exercise":
                        string exercise = $"{command[1]}-Exercise";

                        if (!schedule.Contains(command[1]))
                        {
                            schedule.Add(command[1]);
                            schedule.Add(exercise);
                        }
                        else if (schedule.Contains(command[1]) && !schedule.Contains(exercise))
                        {
                            schedule.Insert(schedule.FindIndex(x => x == command[1]) + 1, exercise);

                        }

                        break;
                }
            }

            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }
    }
}