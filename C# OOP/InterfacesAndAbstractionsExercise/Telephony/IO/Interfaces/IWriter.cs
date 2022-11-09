
namespace Telephony.IO.Interfaces
{
    public interface IWriter
    {
        
        void WriteLine();   // for empty line
        void Write(string text);
        void WriteLine(string text);
    }
}
