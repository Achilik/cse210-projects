using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("C# Basics Tutorial", "CodeMaster", 600);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I learned a lot."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("OOP in C#", "DevGuru", 750);
        video2.AddComment(new Comment("David", "OOP finally makes sense."));
        video2.AddComment(new Comment("Ella", "Nice examples!"));
        video2.AddComment(new Comment("Frank", "Well explained."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Abstraction Explained", "TechWorld", 500);
        video3.AddComment(new Comment("Grace", "Clear and simple."));
        video3.AddComment(new Comment("Henry", "This helped me a lot."));
        video3.AddComment(new Comment("Ivy", "Awesome content!"));
        videos.Add(video3);

        // Video 4
        Video video4 = new Video("Classes and Objects", "LearnFast", 680);
        video4.AddComment(new Comment("Jack", "Very informative."));
        video4.AddComment(new Comment("Kathy", "Loved it!"));
        video4.AddComment(new Comment("Leo", "Good pacing."));
        videos.Add(video4);

        // Display all videos
        foreach (Video video in videos)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length (seconds): {video.Length}");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
        }

        Console.WriteLine("---------------------------------");
    }
}