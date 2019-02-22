using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MbmStore.Models
{
    public class Track
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
        public Track(string title, string composer, TimeSpan Length)
        {
            this.Composer = composer;
            this.Title = title;
            this.Length = Length;
        }
    }
}