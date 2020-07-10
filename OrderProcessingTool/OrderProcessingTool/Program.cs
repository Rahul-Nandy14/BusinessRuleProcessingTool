using System;
using System.Collections.Generic;
using static OrderProcessingTool.Program;

namespace OrderProcessingTool
{
    public class Program
    {
        public enum ProductTypes
        {
            Video,
            Membership,
            Upgrade,
            Book,
            Other
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Product type and name (if applicable) seperated by space");
            var input = Console.ReadLine().Split(' ');
            var output = OrderProcessor.ConvertInputToType(input);
            Console.WriteLine("Item Name : {0} Operations : {1}", output.ItemName, string.Join(' ', output.Operations));
            Console.ReadLine();
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
            Operations = new List<string>();
            GetSlip();
            Operations.Add("Activate that membership");
            Console.WriteLine("Activate that membership");
            base.DropMail();
        }

        public override void GetSlip()
        {
            Operations.Add("Generated a packing slip for shipping.");
            Console.WriteLine("Generated a packing slip for shipping.");
        }
    }

    public class OrderProcessor
    {
        public static NonPhysicalProduct ConvertInputToType(string[] input)
        {
            ProductTypes type;
            try
            {
                type = (ProductTypes)Enum.Parse(typeof(ProductTypes), input[0], ignoreCase: true);
            }
            catch (Exception e)
            {
                type = ProductTypes.Other;
            }
            NonPhysicalProduct product=null;
            string name = input.Length > 1 ? string.Join(' ', input, 1, input.Length - 1) : string.Empty;
            switch (type)
            {
                case ProductTypes.Membership:
                    {
                        product = new Membership();
                        break;
                    }
                
                default:
                    {
                        break;
                    }
            }
            return product;
        }
    }
}
