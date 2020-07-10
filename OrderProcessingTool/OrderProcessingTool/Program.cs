using System;
using System.Collections.Generic;

namespace OrderProcessingTool
{
    public class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video("abcd");
        }
    }

    public class Video 
    {
        public List<string> Operations;
        public string ItemName;
        public Video(string videoName)
        {
            Operations = new List<string>();
            ItemName = videoName;
            Console.WriteLine("'First Aid' video added to the packing slip");            
        }
    }
}
