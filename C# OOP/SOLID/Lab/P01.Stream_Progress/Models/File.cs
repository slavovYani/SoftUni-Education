namespace P01.Stream_Progress.Models
{
    public class File : ProgressFile
    {
        private string name;

        public File(string name, int length, int bytesSent)
            : base(length, bytesSent)
        {
            this.name = name;
        }

        public string Name
        {
            get => name;
            private set => name = value;
        }
    }
}
