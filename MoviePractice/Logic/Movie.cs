using System;
using System.Collections.Generic;

namespace Logic
{
    public class Movie
    {
        public string Title { get; private set; }

        public string Description { get; private set; }

        private List<Genre> genres = new List<Genre>();

        public void VoegFilmToe(string genreName)
        {
            genres.Add(new Genre(genreName));
        }





    }
}
