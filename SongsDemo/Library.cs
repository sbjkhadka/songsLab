using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SongsDemo
{
     static class Library
    {
        static List<Song> songs=new List<Song>();
      
        public static void LoadSongs(string filename) {
            
            TextReader reader = new StreamReader(filename);
            string title, artist;
            double length;
            SongGenre genre;
            while ((title = reader.ReadLine()) != null)
            {
                artist = reader.ReadLine();
                length = Convert.ToDouble(reader.ReadLine());
                genre = (SongGenre)Enum.Parse(typeof(SongGenre),reader.ReadLine());
                
                songs.Add(new Song(title, artist, length, genre));
               
                
            }
            reader.Close();
        }

        public static void DisplaySongs()
        {
            foreach (Song song in songs)
            {
                Console.WriteLine($"{song.Title} by {song.Artist} ({song.Genre}) {song.Length}min");
            }
        }
        public static void DisplaySongs(double longerThan)
        {
            foreach (Song song in songs)
            {
                if (song.Length > longerThan)
                {
                    Console.WriteLine($"{song.Title} by {song.Artist} ({song.Genre}) {song.Length}min");
                }
                
            }

        }
        public static void DisplaySongs(SongGenre genre)
        {
            foreach (Song song in songs)
            {
                if (song.Genre ==genre)
                {
                    Console.WriteLine($"{song.Title} by {song.Artist} ({song.Genre}) {song.Length}min");
                }
            }
        }
        public static void DisplaySongs(string artist)
        {
            foreach (Song song in songs)
            {
                if (song.Artist == artist)
                {
                    Console.WriteLine($"{song.Title} by {song.Artist} ({song.Genre}) {song.Length}min");
                }
            }
        }

    }
}
