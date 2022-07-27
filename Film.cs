using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSystemApp
{
    public class Film
    {
        public int ID { get; set; }
        public string Genre { get; set; }
        public string ProjectionType { get; set; }
        public int Duration { get; set; }
        public string FilmName { get; set; }
        
        public Film(string FilmName, string Genre, string ProjectionType, int Duration)
        {
            this.Genre = Genre; 
            this.ProjectionType = ProjectionType;
            this.Duration = Duration;
            this.FilmName = FilmName;   
        }
        public override string ToString()
        {
            return "Duration:" + Duration + "Genre: " + Genre + "ProjectionType: " + ProjectionType;
        }
    }
}
