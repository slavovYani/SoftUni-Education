namespace P01.Stream_Progress.Models
{
    using Contracts;

    public class StreamProgressInfo
    {
        private IProgressable file;

        // If we want to stream a music file, we can't
        public StreamProgressInfo(IProgressable file)
        {
            this.file = file;
        }

        public int CalculateCurrentPercent()
            => file.BytesSent * 100 / file.Length;
    }
}