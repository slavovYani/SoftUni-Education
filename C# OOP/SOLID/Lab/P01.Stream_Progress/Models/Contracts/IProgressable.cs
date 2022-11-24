namespace P01.Stream_Progress.Models.Contracts
{
    public interface IProgressable
    {
        int Length { get; }

        int BytesSent { get; }
    }
}