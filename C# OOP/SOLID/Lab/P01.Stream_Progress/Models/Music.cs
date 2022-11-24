namespace P01.Stream_Progress.Models
{
    public class Music : ProgressFile
    {
        private string artist;
        private string album;

        public Music(string artist, string album, int length, int bytesSent)
            : base(length, bytesSent)
        {
            this.artist = artist;
            this.album = album;
        }

        public string Artist
        {
            get => artist;
            private set => artist = value;
        }

        public string Album
        {
            get => album;
            private set => album = value;
        }
    }
}