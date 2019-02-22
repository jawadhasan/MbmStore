using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class MusicCD : Product
    {
        ///fields

        List<Track> tracks = new List<Track>();
        private TimeSpan getPlayingTime;

        //properties

        /*
        public List<string> Tracks
        {
            get { return tracks; }
        }
        */
        public string Artist
        {
            get;
            set;
        }

        public string Label
        {
            get;
            set;
        }

        public short Released
        {
            get;
            set;
        }

        public List<Track> Tracks
        {
            get { return tracks; }
        }
        //contructors
        public MusicCD()
        {
        }
        public MusicCD(string title, string artist, decimal price, string ImageURL) :
        base(title, price, ImageURL)
        {
            this.Artist = artist;
        }


        /// method AddPhone --to add or drag stuff
        public void addTrack(Track track)
        {
            Tracks.Add(track);
        }

        //method to calculate the total track length
        public TimeSpan GetPlayingTime(){
            var playingTimeSec = TimeSpan.FromSeconds(Tracks.Select(t => t.Length.TotalSeconds).Sum());
            return playingTimeSec;
        }


        }

    }
    
