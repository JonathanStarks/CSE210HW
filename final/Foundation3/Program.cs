using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation3 World!");

        //DateTime today = DateTime.Now;
        General birthdayParty = new General("Birthday Party", "This is my birthday party!", "March 10, 7AM", "123abc ST, City, State 12345");
        birthdayParty.DisplayGeneral();

        Console.WriteLine();
        Console.WriteLine();

        FullEvent hikeingGrandCanyon = new FullEvent("Grand Canyon Hike", "We will be hikeing the Grand Canyon from Hoover Dam to the canoe return port.", "Jan. 18th, 2077, 17:58", "Hoover Dam, NV 89005", "Outdoor");
        hikeingGrandCanyon.CheckEventType();

        Console.WriteLine();
        Console.WriteLine();

        ShortInfo missionaryLecture = new ShortInfo("Lecture", "Missionary Lecture", "Aug. 12");
        missionaryLecture.DisplayShortInfo();
    }
}