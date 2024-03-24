using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD06_1302223055.SayaTubeVideo
{
    internal class SayaTubeVideo
    {
        private int id;
        private String title;
        private int PlayCount;

        public SayaTubeVideo(String title, int PlayCount)
        {
            if (title == null || title == "")
            {
                throw new ArgumentException("Title cannot be null or empty");
            }
            Random r = new Random();
            this.id = r.Next(100000, 999999);
            this.title = title;
            this.PlayCount = PlayCount;
        }

        public void incrementPlayCount(int x)
        {
            try
            {
                checked
                {
                    if (x > 100000000)
                    {
                        PlayCount += 100000000;
                    }
                    else
                    {
                        PlayCount += x;
                    }

                }
            }
            catch (OverflowException e)
            {
                this.PlayCount = int.MaxValue;
                Console.WriteLine("Play count is too high to increment \n");
            }
        }

        public void printVideoDetails()
        {
            Console.WriteLine("Video ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + PlayCount);
        }
    }
}