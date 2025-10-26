using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClasses
{
    public class Genre
    {
        private static int _nextId = 1;

        public readonly int Id; 
        public readonly string Name;
        public readonly string Description;

        public Genre(string name, string description)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Genre name cannot be empty.");

            Id = _nextId++;
            Name = name;
            Description = description;
        }
    }

}
