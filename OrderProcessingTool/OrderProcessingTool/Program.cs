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
        protected List<string> Operations;
        protected string ItemName;
        public abstract void GetSlip();
        public virtual void DropMail()
        {
            Operations.Add("Mail Sent");
            Console.WriteLine("Mail Sent");
        }

    }

    class Video : NonPhysicalProduct
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
}
