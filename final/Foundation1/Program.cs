using System;

class Program
{
    static void Main(string[] args)
    {
       List<Video> videos = new List<Video>();
            // Create videos and add comments
            Video video1 = new Video("Avengers", "Ruso Brothers", 120);
            video1.AddComment("Kaneene", "Black Panter was incredible!");
            video1.AddComment("Ssemambo", "The story line was great.");

            Video video2 = new Video("Black Panther", "Chadwick Boseman", 150);
            video2.AddComment("Kyoyagala", "RIP Chadwick");
            video2.AddComment("Nakanwagi", "Your name will live forever Chadwick Boseman");

            //Add videos to the list
            videos.Add(video1);
            videos.Add(video2);

            //Display video information
            foreach(var video in videos)
            {
                Console.WriteLine($"Title: {video._title}");
                Console.WriteLine($"Author: {video._author}");
                Console.WriteLine($"Length: {video._length} seconds");
                Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (var comment in video._comments)
            {
                Console.WriteLine($"Comment by {comment._commenterName}: {comment._commentText}");
            }

            Console.WriteLine();
            }
    }
}