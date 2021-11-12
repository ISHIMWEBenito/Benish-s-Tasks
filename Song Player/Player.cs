using System.Collections.Generic;

namespace Task3b
{
    class Player
    {
        List<Song> trackList;
        public Player()
        {
            trackList = new List<Song>();
        }
        public void Add(Song song)
        {
            trackList.Add(song);
        }
        public void Remove(int songNumber)
        {
            trackList.RemoveAt(songNumber);
        }
        public void Play(int songNumber)
        {
            trackList[songNumber].Play();
        }
        public bool IsEmpty()
        {
            return trackList.Count == 0;
        }
    }
}
