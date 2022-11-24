namespace P01.Stream_Progress
{
    using System;

    using Models;
    using Models.Contracts;

    public class StartUp
    {
        static void Main()
        {
            IProgressable file = new File("File", 350, 30);
            IProgressable song = new Music("Billie Eilish", "Happier Than Ever", 579, 256);

            StreamProgressInfo fileProgressInfo =
                new StreamProgressInfo(file);
            StreamProgressInfo songProgressInfo = new StreamProgressInfo(song);

            int fileProgress = fileProgressInfo.CalculateCurrentPercent();
            int songProgress = songProgressInfo.CalculateCurrentPercent();

            Console.WriteLine($"File progress - {fileProgress}%");
            Console.WriteLine($"Song progress - {songProgress}%");
        }
    }
}