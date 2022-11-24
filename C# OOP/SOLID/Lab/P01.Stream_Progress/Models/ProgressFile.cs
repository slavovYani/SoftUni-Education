namespace P01.Stream_Progress.Models
{
    using Contracts;

    public abstract class ProgressFile : IProgressable
    {
        protected ProgressFile(int length, int bytesSent)
        {
            Length = length;
            BytesSent = bytesSent;
        }

        public int Length { get; private set; }

        public int BytesSent { get; private set; }
    }
}