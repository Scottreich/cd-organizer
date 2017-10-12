using System.Collections.Generic;

namespace CdOrganizer.Models
{
    public class Cd
    {
        private string _title;
        private string _artist;
        private static List<Cd> _instances = new List<Cd>{};


        public Cd(string title, string artist)
        {
            _title = title;
            _artist = artist;
            _instances.Add(this);
        }

        public string GetTitle()
        {
            return _title;
        }
        public static List<Cd> GetAll()
        {
            return _instances;
        }

        public string GetArtist()
        {
            return _artist;
        }
    }
}
