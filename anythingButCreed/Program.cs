using System;
using System.Collections.Generic;
using System.Linq;

namespace anythingButCreed
{
    class Program
    {
        static void Main(string[] args)
        {
            //define new lists
            var goodSongs = new List<Song>();
            var allSongs = new List<Song>();

            //add songs to allSongs list
            allSongs.Add(new Song("The National", "England"));
            allSongs.Add(new Song("The National", "Don't Swallow the Cap"));
            allSongs.Add(new Song("Damien Jurado", "Sheets"));
            allSongs.Add(new Song("Damien Jurado", "The Last Great Washington State"));
            allSongs.Add(new Song("Fleet Foxes", "Montezuma"));
            allSongs.Add(new Song("Fleet Foxes", "I'm Not My Season"));
            allSongs.Add(new Song("Sufjan Stevens", "Casimir Pulaski Day"));
            allSongs.Add(new Song("Sufjan Stevens", "No Shade in the Shadow of the Cross"));
            allSongs.Add(new Song("Andrew Bird", "Olympians"));
            allSongs.Add(new Song("Andrew Bird", "Fake Palindromes"));
            allSongs.Add(new Song("Creed", "What Is Creed"));
            allSongs.Add(new Song("Creed", "I don't know any songs by Creed "));

            //define list goodSongs => return songs where song.artist is NOT creed and convert from IEnumberable to list
            goodSongs = allSongs.Where(s => s.Artist != "Creed").ToList();

            //print the list
            foreach (Song s in goodSongs)
            {
                Console.WriteLine($"{s.Artist} - {s.Name}");
            }
        }

    }
}
