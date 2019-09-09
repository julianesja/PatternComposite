using System;

namespace PatronComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            FolderComposite diskComposite = new FolderComposite("Carpeta Univesidad");
            diskComposite.Add(new File("Trabajo Final", 10));
            FolderComposite music = new FolderComposite("My Music" );
            music.Add(new File("Song.mp3",  3));
            music.Add(new File("Song.mp3",  5));
            FolderComposite musicAndresCalmaro = new FolderComposite("Alta Suciedad");
            musicAndresCalmaro.Add(new File("Flaca.mp3", 4));
            music.Add(musicAndresCalmaro);
            diskComposite.Add(music);
            Console.WriteLine(diskComposite.Weight);
        }
    }
}
