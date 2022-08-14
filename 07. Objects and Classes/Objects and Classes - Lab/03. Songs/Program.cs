using System;
using System.Collections.Generic;

namespace _03._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Songs> songs = new List<Songs>();

            int songsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < songsCount; i++)
            {
                string[] songProperties = Console.ReadLine().Split('_');

                Songs song = new Songs(songProperties[0], songProperties[1], songProperties[2]);
                songs.Add(song);
            }
            string lastType = Console.ReadLine();

            if (lastType == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songs)
                {
                    if (song.TypeList == lastType)
                    {
                    Console.WriteLine(song.Name);

                    }
                }
            }
        }
    }
    class Songs
    {
        public Songs(string TypeList, string Name , string Time)
        {
            this.TypeList = TypeList;
            this.Name = Name;
            this.Time = Time;
        }
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

    }
}
