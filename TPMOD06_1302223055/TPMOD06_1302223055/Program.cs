// See https://aka.ms/new-console-template for more information

using TPMOD06_1302223055.SayaTubeVideo;

namespace program;
class Progam
{

    public static void Main(String[] Args)
    {
        SayaTubeVideo video = new SayaTubeVideo("jejak rosul", 0);
        for (int i = 0; i < 250; i++)
        {
            video.incrementPlayCount(100000000);
            video.printVideoDetails();
        }
        Console.WriteLine("max play count :" + int.MaxValue);

    }
}