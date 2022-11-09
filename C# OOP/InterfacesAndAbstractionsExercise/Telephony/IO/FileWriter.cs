
namespace Telephony.IO
{
    using System;
    using System.IO;
    using Interfaces;
    public class FileWriter : IWriter
    {
        private string filePath;

        public string FilePath
        {
            get
            {
                return filePath;
            }
            private set
            {
                if (!Directory.Exists(filePath))
                {
                    throw new ArgumentException("Invalid file path!");
                }
                filePath = value;
            }
        }


        public void Write(string text)
        {
            File.WriteAllText(filePath, text);
        }

        public void WriteLine(string text)
        {
            File.WriteAllText(this.FilePath, text);
        }

        public void WriteLine()
        {
            /// empty line
        }
    }
}
