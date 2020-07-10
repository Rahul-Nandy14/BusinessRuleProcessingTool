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

    public abstract class NonPhysicalProduct
    {
        public List<string> Operations;
        public string ItemName;
        public abstract void GetSlip();
        public virtual void DropMail()
        {
            Operations.Add("Mail Sent");
            Console.WriteLine("Mail Sent");
        }

    }

    public class Video : NonPhysicalProduct
    {
        public Video(string videoName)
        {
            Operations = new List<string>();
            ItemName = videoName;

        }
        public override void GetSlip()
        {
            if (ItemName.ToLower().Equals("learning to ski"))
            {
                Operations.Add("Generated a packing slip.");
                Console.WriteLine("Generated a packing slip.");
                Operations.Add("'First Aid' video added to the packing slip");
                Console.WriteLine("'First Aid' video added to the packing slip");
            }
        }
    }

    public class Membership : NonPhysicalProduct
    {
        public Membership()
        {
        }
    }
}
