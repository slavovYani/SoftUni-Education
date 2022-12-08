
using Heroes.IO.Contracts;
using System.IO;

namespace Heroes.IO
{
    public class FileWriter : IWriter
    {
        public void Write(string message)
        {
            File.WriteAllText("../../../text.txt",message);
        }

        public void WriteLine(string message)
        {
            using (StreamWriter writer = new StreamWriter("../../../text.txt",true))
            {
                writer.WriteLine(message);
            }

        }
    }
}
