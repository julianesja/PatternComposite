using System;

namespace PatronComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            DiskComposite diskComposite = new DiskComposite("Unidad C:");
            diskComposite.Add(new Path("Trabajo Final", 10));
            DiskComposite music = new DiskComposite("My Music" );
            music.Add(new Path("Song.mp3",  3));
            music.Add(new Path("Song.mp3",  5));
            DiskComposite musicAndresCalmaro = new DiskComposite("Alta Suciedad");
            musicAndresCalmaro.Add(new Path("Flaca.mp3", 4));
            music.Add(musicAndresCalmaro);
            diskComposite.Add(music);
            Console.WriteLine(diskComposite.Weight);
            
        }
    }
}
