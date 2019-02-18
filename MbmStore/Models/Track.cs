using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MbmStore.Models
{
    public class Track:MusicCD
    {

        //properties
        public string Title
        {
            get;
            set;
        }

        public string Composer
        {
            get;
            set;
        }
        public TimeSpan Length
        {
            get;
            set;
        }

        ///Constructor for Tracks
        public Track()
        {
        }
        public Track(string title, string composer, Track track)
        {
            this.Composer = composer;
            this.Title = title;
        }
    }
}