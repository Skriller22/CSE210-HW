using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video();
        Video video2 = new Video();
        Video video3 = new Video();
        Video video4 = new Video();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.GenerateRandomVideo();
            video.CreateRandomComments(5);
            video.Print();
            video.PrintComments();
        }
    }
}

// Abstraction
// Note: There wasn't a need for creativity but I did allow for the creation of random comments just to make things easier.