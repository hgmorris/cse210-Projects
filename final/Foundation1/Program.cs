using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create 3-4 videos
        List<Video> videos = new List<Video>();
        videos.Add(new Video("First Video", "John Smith", 120));
        videos.Add(new Video("Second Video", "Jane Doe", 180));
        videos.Add(new Video("Third Video", "Bob Johnson", 240));

        // Add 3-4 comments for each video
        videos[0].AddComment(new Comment("Alice", "Great video!"));
        videos[0].AddComment(new Comment("Bob", "Thanks for sharing."));
        videos[0].AddComment(new Comment("Charlie", "I learned a lot."));

        videos[1].AddComment(new Comment("David", "This video is amazing!"));
        videos[1].AddComment(new Comment("Emily", "I wish it was longer."));
        videos[1].AddComment(new Comment("Frank", "This video changed my life."));

        videos[2].AddComment(new Comment("George", "Interesting topic."));
        videos[2].AddComment(new Comment("Hannah", "Thanks for the insights."));
        videos[2].AddComment(new Comment("Isabelle", "I will share this video with my friends."));

        // Display information for each video
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length (seconds): " + video.Length);
            Console.WriteLine("Number of comments: " + video.GetCommentCount());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine(comment.Name + ": " + comment.Text);
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}