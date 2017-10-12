using System.Collections.Generic;

namespace CdOrganizer.Models
{
    public class Artist
    {
        private string _name;
        private static List<Artist> _instances = new List<Artist>{};
        private int _id;

        public static List<Artist> GetAll()
        {
            return _instances;
        }

        public Artist(string name)
        {
            _name = name;
            _id = _instances.Count;
            _instances.Add(this);
        }

        public string GetName()
        {
            return _name;
        }

        public int GetId()
        {
            return _id;
        }

        public static Artist Find(int searchID)
        {
            return _instances[searchID];
        }

    }
}
