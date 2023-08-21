using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desarrolloSistemas_blockbuster
{
    class Movie
    {
        string _title = "";
        int _duration = 0;
        Genre _genre = new Genre();

        public string title => _title;
        public int duration => _duration;
        public Genre genre => _genre;

        public Movie()
        {

        }

        public Movie(string title, int duration, Genre genre)
        {
            _title = title;
            _duration = duration;
            _genre = genre;
        }
    }
}
