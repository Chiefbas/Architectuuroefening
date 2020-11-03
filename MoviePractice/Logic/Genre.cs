using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Genre
    {
        public string  GenreName { get; private set; }

        public Genre(string genreName)
        {
            GenreName = genreName;
        }
    }
}
