using System;
using System.Collections.Generic;

namespace _04.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] songInfo = Console.ReadLine().Split("_");

                string type = songInfo[0];
                string name = songInfo[1];
                string time = songInfo[2];

                Song song = new Song(type, name, time);
                songs.Add(song);
            }

            string typeList = Console.ReadLine();
            if (typeList == "all")
            {
                songs.ForEach(s => Console.WriteLine(s.Name));
            }
            else
            {
                songs.ForEach(s =>
                {
                    if (s.TypeList == typeList)
                    {
                        Console.WriteLine(s.Name);
                    }
                });
            }
        }

        class Song
        {
            public Song(string type, string name, string time)
            {
                this.TypeList = type;
                this.Name = name;
                this.Time = time;
            }
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }
        }
    }
}
